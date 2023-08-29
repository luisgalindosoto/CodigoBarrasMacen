using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class Unidades : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public Unidades()
        {
            InitializeComponent();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            


            // TODO: esta línea de código carga datos en la tabla 'dataSetPart.BRC_PART' Puede moverla o quitarla según sea necesario.


            try
            {

                string connectString = "";
                string Conexionfinal = "";
                ConnectionStringSettings settings =
                   ConfigurationManager.ConnectionStrings["brc_tags.Properties.Settings.DBPOLYConnectionString"];
                if (null != settings)
                {
                    connectString = settings.ConnectionString;
                    SqlConnectionStringBuilder builder =
                        new SqlConnectionStringBuilder(connectString);
                    builder.DataSource = Server;
                    builder.UserID = User_id;
                    builder.Password = Pass;
                    Conexionfinal = builder.ToString();
                }
                // TODO: esta línea de código carga datos en la tabla 'dataSetPart.BRC_UNITS' Puede moverla o quitarla según sea necesario.
                bRC_UNITSTableAdapter.Connection.ConnectionString = Conexionfinal;
                this.bRC_UNITSTableAdapter.Fill(this.dataSetPart.BRC_UNITS);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un erro favor contactar su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                gridView1.AddNewRow();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                bRCUNITSBindingSource.EndEdit();

                bRC_UNITSTableAdapter.Update(dataSetPart.BRC_UNITS);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
