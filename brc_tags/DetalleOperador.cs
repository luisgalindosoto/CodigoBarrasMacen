using brc_tags.Librerias;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class DetalleOperador : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string Origen;
        public string IdTag;
        public string IdTipoPlantilla;
        public DetalleOperador()
        {
            InitializeComponent();
        }

        private void DetalleOperador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetDetalleOperadores.BRC_DETALLE_OPERADOR' Puede moverla o quitarla según sea necesario.
            //this.bRC_DETALLE_OPERADORTableAdapter.Fill(this.dataSetDetalleOperadores.BRC_DETALLE_OPERADOR);

            try {
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
                bRC_DETALLE_OPERADORTableAdapter.Connection.ConnectionString = Conexionfinal;
                if(!string.IsNullOrEmpty( IdTag))
                bRC_DETALLE_OPERADORTableAdapter.FillObtenerDetalleOperador(dataSetDetalleOperadores.BRC_DETALLE_OPERADOR, IdTag);

                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();
                ds = consulta.consultaSelect("SELECT ID_OPERADOR AS Codigo, NOMBRE as Nombre FROM " + DB + ".DBO.PRD_OPERADOR WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "OPERADOR", ref ControlError);
               
                RepositoryItemSearchLookUpEdit repositoryItemLookUpEditOperador = new RepositoryItemSearchLookUpEdit();
                repositoryItemLookUpEditOperador.DataSource = ds.Tables[0];
                repositoryItemLookUpEditOperador.ValueMember = "Codigo";
                repositoryItemLookUpEditOperador.DisplayMember = "Nombre";
                gridView1.Columns["ID_OPERADOR"].ColumnEdit = repositoryItemLookUpEditOperador;



            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar a su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
