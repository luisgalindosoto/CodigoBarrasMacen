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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class Part : Form
    {

        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string IdTipoPlantilla;
        public string CodigoSeleccionado;
        public Part()
        {
            InitializeComponent();
        }

        private void Part_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'dataSetPart.BRC_PART' Puede moverla o quitarla según sea necesario.
            

            try
            {

                string User1 = "";
                string User2 = "";
                string User3 = "";
                string User4 = "";
                string User5 = "";
                string User6 = "";
                string User7 = "";
                string User8 = "";
                string User9 = "";
                string User10 = "";

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
                bRC_PARTTableAdapter.Connection.ConnectionString = Conexionfinal;
                this.bRC_PARTTableAdapter.Fill(this.dataSetPart.BRC_PART);

                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                string ControlError = "";
                DataSet ds = new DataSet();


                ds = consulta.consultaSelect(" SELECT UNIT_OF_MEASURE AS Codigo,DESCRIPTION AS Descripcion FROM " + DB + ".DBO.BRC_UNITS", "UNIDADES", ref ControlError);
                RepositoryItemSearchLookUpEdit rep_unidad_de_medida = new RepositoryItemSearchLookUpEdit();
                rep_unidad_de_medida.DataSource = ds.Tables[0];
                rep_unidad_de_medida.ValueMember = "Codigo";
                rep_unidad_de_medida.DisplayMember = "Descripcion";
                gridView1.Columns["STOCK_UM"].ColumnEdit = rep_unidad_de_medida;


                RepositoryItemCheckEdit active = new RepositoryItemCheckEdit();
                gridView1.Columns["ACTIVO"].ColumnEdit = active;
                //Inica que valores tomara de la columna cuando sea verdader, falto o nulo
                active.NullText = "";
                active.ValueChecked = "Y";
                active.ValueUnchecked = "N";
                active.ValueGrayed = "-";
                
                ds = consulta.consultaSelect(" SELECT TEXTO_USER_1,TEXTO_USER_2,TEXTO_USER_3,TEXTO_USER_4,TEXTO_USER_5,TEXTO_USER_6,TEXTO_USER_7,TEXTO_USER_8,TEXTO_USER_9,TEXTO_USER_10 FROM "+DB+".dbo.BRC_CAMPOS_DEF_USUARIO where ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"'", "USERS", ref ControlError);

                if (ControlError == "Completado")
                {

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_1"])))
                        User1 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_1"]);
                    else
                        User1 = "User 1";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_2"])))
                        User2 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_2"]);
                    else
                        User2 = "User 2";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_3"])))
                        User3 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_3"]);
                    else
                        User3 = "User 3";


                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_4"])))
                        User4 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_4"]);
                    else
                        User4 = "User 4";


                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_5"])))
                        User5 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_5"]);
                    else
                        User5 = "User 5";


                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_5"])))
                        User5 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_5"]);
                    else
                        User5 = "User 5";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_6"])))
                        User6 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_6"]);
                    else
                        User6 = "User 6";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_7"])))
                        User7 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_7"]);
                    else
                        User7 = "User 7";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_8"])))
                        User8 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_8"]);
                    else
                        User8 = "User 8";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_9"])))
                        User9 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_9"]);
                    else
                        User9 = "User 9";

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_10"])))
                        User10 = Convert.ToString(ds.Tables[0].Rows[0]["TEXTO_USER_10"]);
                    else
                        User10 = "User 10";



                    gridView1.Columns["USER_1"].Caption = User1;
                    gridView1.Columns["USER_2"].Caption = User2;
                    gridView1.Columns["USER_3"].Caption = User3;
                    gridView1.Columns["USER_4"].Caption = User4;
                    gridView1.Columns["USER_5"].Caption = User5;
                    gridView1.Columns["USER_6"].Caption = User6;
                    gridView1.Columns["USER_7"].Caption = User7;
                    gridView1.Columns["USER_8"].Caption = User8;
                    gridView1.Columns["USER_9"].Caption = User9;
                    gridView1.Columns["USER_10"].Caption = User10;

                    if (User1.Contains("User"))
                        gridView1.Columns["USER_1"].Visible = false;

                    if (User2.Contains("User"))
                        gridView1.Columns["USER_2"].Visible = false;

                    if (User3.Contains("User"))
                        gridView1.Columns["USER_3"].Visible = false;

                    if (User4.Contains("User"))
                        gridView1.Columns["USER_4"].Visible = false;

                    if (User5.Contains("User"))
                        gridView1.Columns["USER_5"].Visible = false;

                    if (User6.Contains("User"))
                        gridView1.Columns["USER_6"].Visible = false;

                    if (User7.Contains("User"))
                        gridView1.Columns["USER_7"].Visible = false;

                    if (User8.Contains("User"))
                        gridView1.Columns["USER_8"].Visible = false;

                    if (User9.Contains("User"))
                        gridView1.Columns["USER_9"].Visible = false;

                    if (User10.Contains("User"))
                        gridView1.Columns["USER_10"].Visible = false;

                }

               
            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Ocurrio un erro favor contactar su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try 
            {

                gridView1.AddNewRow();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador: "+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                bRCPARTBindingSource.EndEdit();

                bRC_PARTTableAdapter.Update(dataSetPart.BRC_PART);
                CodigoSeleccionado = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();

                MessageBox.Show("Se guardo información correctamente","Información", MessageBoxButtons.OK);
         

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_unidades_Click(object sender, EventArgs e)
        {
            try
            {

                    Unidades formunidades = new Unidades();
                    formunidades.DB = DB;
                    formunidades.User_id = User_id;
                    formunidades.Server = Server;
                    formunidades.SMVISUAL = SMVISUAL;
                    formunidades.Pass = Pass;
                    formunidades.ShowDialog();
                   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try {

                CodigoSeleccionado = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                this.Close();

            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

                CodigoSeleccionado = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try {

                this.bRC_PARTTableAdapter.Fill(this.dataSetPart.BRC_PART);

            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try {

                if (e.Column.Name.ToString() == "colUSER_6")
                {

                    conexion consulta = new conexion();
                    consulta.SetDB(DB);
                    consulta.SetUsuario(User_id);
                    consulta.SetPassword(Pass);
                    consulta.SetServer(Server);
                    string ControlError = "";
                    
                    DataSet ds = new DataSet();
                    string Articulo = "";
                    string ExisteEtiquetas = "";
                    string Peso = "";
                    Articulo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                    Peso = consulta.ejecutaEscalar("SELECT USER_6 FROM " + DB + ".DBO.BRC_PART WHERE ID='" + Articulo + "'", ref ControlError);
                    ExisteEtiquetas = consulta.ejecutaEscalar("SELECT COUNT(ID) FROM "+DB+".DBO.BRC_PART WHERE ID='"+Articulo+"'",ref ControlError);
                    if (string.IsNullOrEmpty(Peso))
                        Peso = "0";

                    if (string.IsNullOrEmpty(ExisteEtiquetas))
                        ExisteEtiquetas = "0";

                    if (Convert.ToInt32(ExisteEtiquetas) > 0)
                    {
                        string Respuesta = "";
                        MessageBox.Show("Ya existen etiquetas con este articulo y si desea modificar el peso debera validar las credenciales.","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        ValidarCredenciales formcredenciales = new ValidarCredenciales();
                        formcredenciales.DB = DB;
                        formcredenciales.User_id = User_id;
                        formcredenciales.Pass = Pass;
                        formcredenciales.Server = Server;
                        formcredenciales.SMVISUAL = SMVISUAL;
                        formcredenciales.IdTipoPlantilla = IdTipoPlantilla;
                        formcredenciales.ShowDialog();
                        Respuesta = formcredenciales.Respuesta;

                        if (Respuesta != "OK")
                        {
                            this.bRC_PARTTableAdapter.Fill(this.dataSetPart.BRC_PART);
                            MessageBox.Show("Ingreso unas credenciales incorrectas, o no tiene permisos para modificar pesos.", "Error Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else {
                            int Seleccionado = 0;

                            Seleccionado = gridView1.FocusedRowHandle;


                            this.Validate();
                            bRCPARTBindingSource.EndEdit();

                            bRC_PARTTableAdapter.Update(dataSetPart.BRC_PART);

                            gridView1.FocusedRowHandle = Seleccionado;


                            //MessageBox.Show("El cambio de peso fue realizo con exito.!","Cambio de peso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            consulta.insertar("INSERT INTO " + DB + ".DBO.BRC_BIT_CAMBIO_PESOS(FECHA,USER_ID,PART_ID,VALOR) VALUES(GETDATE(),'" + User_id + "','" + Articulo + "','"+ gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"USER_6").ToString()  +"') ",ref ControlError);
                            
                            

                        }
                        
                    }

                }
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un mensaje favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
