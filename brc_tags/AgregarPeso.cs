using brc_tags.Librerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class AgregarPeso : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string Origen;
        public DateTime FechaActual;
        public string IdTipoPlantilla;
        public string IdTag;
        bool AccesoATodo;
        public string MetrosAConvertir;
        string MarcaBascula = "";
        public bool EstaEditando;
        public string PublicUnidad1;
        public string PublicUnidad2;
        public string PublicUser1;
        public string PublicUser2;
        public string PublicUser3;
        public string PublicUser4;
        public string PublicUser5;
        public string PublicUser6;
        public string PublicUser7;
        public string PublicUser8;
        public string PublicUser9;
        public string PublicUser10;





        public AgregarPeso()
        {
            InitializeComponent();
        }

        private void AgregarPeso_Load(object sender, EventArgs e)
        {
            try
            {
                barButtonItem5.Enabled = false;
                //try
                //{
                //    if (sp1.IsOpen == true)
                //    {
                //        sp1.Close();
                //    }
                //    else
                //    {
                //        sp1.Open();
                //    }
                //}
                //catch (Exception Ex)
                //{


                //}

                string connectString = "";
                string Conexionfinal = "";
                MetrosAConvertir = "";
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
                bRC_SUMATORIATableAdapter.Connection.ConnectionString = Conexionfinal;
                bRC_SUMATORIATableAdapter.FillObtenerSumatoria(dataSetSumatoriaTags.BRC_SUMATORIA, IdTag);

                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();

                barButtonItem6.Enabled = false;
                barButtonItem11.Enabled = false;
                barButtonItem5.Enabled = false;
                barButtonItem12.Enabled = false;
                barButtonItem7.Enabled = false;
                barButtonItem16.Enabled = false;

                txt_tag.ReadOnly = true;
                txt_user1.Enabled = false;
                txt_user2.Enabled = false;
                txt_user3.Enabled = false;
                txt_user4.Enabled = false;
                txt_user5.Enabled = false;
                txt_user6.Enabled = false;
                txt_user7.Enabled = false;
                txt_user8.Enabled = false;
                txt_user9.Enabled = false;
                txt_user10.Enabled = false;
                lst_unidad1.Enabled = false;
                lst_unidad2.Enabled = false;
               
                ds = consulta.consultaSelect("SELECT UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10 FROM " + DB + ".DBO.BRC_HABILITACION_CAMPOS WHERE ID_USUARIO='" + User_id + "'", "HABILITAR_CAMPOS", ref ControlError);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    if (ds.Tables[0].Rows[0]["UNIDAD_1"].ToString() == "Y")
                        lst_unidad1.ReadOnly = false;
                    else
                        lst_unidad1.ReadOnly = true;



                    if (ds.Tables[0].Rows[0]["UNIDAD_2"].ToString() == "Y")
                        lst_unidad2.ReadOnly = false;
                    else
                        lst_unidad2.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_1"].ToString() == "Y")
                        txt_user1.ReadOnly = false;
                    else
                        txt_user1.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_2"].ToString() == "Y")
                        txt_user2.ReadOnly = false;
                    else
                        txt_user2.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_3"].ToString() == "Y")
                        txt_user3.ReadOnly = false;
                    else
                        txt_user3.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_4"].ToString() == "Y")
                        txt_user4.ReadOnly = false;
                    else
                        txt_user4.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_5"].ToString() == "Y")
                        txt_user5.ReadOnly = false;
                    else
                        txt_user5.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_6"].ToString() == "Y")
                        txt_user6.ReadOnly = false;
                    else
                        txt_user6.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_7"].ToString() == "Y")
                        txt_user7.ReadOnly = false;
                    else
                        txt_user7.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_8"].ToString() == "Y")
                        txt_user8.ReadOnly = false;
                    else
                        txt_user8.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_9"].ToString() == "Y")
                        txt_user9.ReadOnly = false;
                    else
                        txt_user9.ReadOnly = true;


                    if (ds.Tables[0].Rows[0]["USER_10"].ToString() == "Y")
                        txt_user10.ReadOnly = false;
                    else
                        txt_user10.ReadOnly = true;


                    if (lst_unidad1.ReadOnly == false &&
                        lst_unidad2.ReadOnly == false &&
                        txt_user1.ReadOnly == false &&
                        txt_user2.ReadOnly == false &&
                        txt_user3.ReadOnly == false &&
                        txt_user4.ReadOnly == false &&
                        txt_user5.ReadOnly == false &&
                        txt_user6.ReadOnly == false &&
                        txt_user7.ReadOnly == false &&
                        txt_user8.ReadOnly == false &&
                        txt_user9.ReadOnly == false &&
                        txt_user10.ReadOnly == false
                        )
                    {

                        AccesoATodo = true;
                    }
                    //-----------------------------------------------------------------------
                    //Colocacion de leyendas de los campos

                   
                    string Crear = "";
                    string Leer = "";
                    string Modificar = "";
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
                    string Unidad_1 = "";
                    string Unidad_2 = "";
                    ds = consulta.consultaSelect("SELECT ISNULL(CREAR,'N') AS CREAR,ISNULL(LEER,'N') AS LEER, ISNULL(MODIFICAR,'N') AS MODIFICAR, isnull(LECTURA_BASCULA,'') as BASCULA   FROM " + DB + ".DBO.BRC_USUARIO_DEPARTAMENTO WHERE ID_USUARIO='" + User_id + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "PERMISOS", ref ControlError);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Crear = ds.Tables[0].Rows[0]["CREAR"].ToString();
                        Leer = ds.Tables[0].Rows[0]["LEER"].ToString();
                        Modificar = ds.Tables[0].Rows[0]["MODIFICAR"].ToString();
                        MarcaBascula = ds.Tables[0].Rows[0]["BASCULA"].ToString();


                        if (MarcaBascula == "BREKNELLSIB100")
                            tm_lectura.Interval = 200;
                        else
                            tm_lectura.Interval = 500;

                        tm_lectura.Enabled = true;
                    }

                    if (Crear == "Y")
                    {
                        barButtonItem5.Enabled = true;
                        barButtonItem15.Enabled = true;
                        barButtonItem16.Enabled = true;

                    }
                    else
                    {
                        barButtonItem5.Enabled = false;
                        barButtonItem15.Enabled = false;
                        barButtonItem16.Enabled = false;
                    }

                    if (Leer == "Y")
                    {
                        barButtonItem11.Enabled = true;
                    }
                    else
                    {
                        barButtonItem11.Enabled = false;
                    }

                    if (Modificar == "Y")
                    {

                        barButtonItem12.Enabled = true;
                        barButtonItem7.Enabled = true;
                    }
                    else
                    {

                        barButtonItem12.Enabled = false;
                        barButtonItem7.Enabled = false;

                    }


                    string Sufijo = "";

                    Sufijo = consulta.ejecutaEscalar("SELECT SUFIJO FROM " + DB + ".DBO.BRC_CORRELATIVOS where ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y'", ref ControlError);


                    if (!string.IsNullOrEmpty(Sufijo))
                    {

                      
                        ds = consulta.consultaSelect("SELECT TEXTO_USER_1,TEXTO_USER_2,TEXTO_USER_3,TEXTO_USER_4,TEXTO_USER_5,TEXTO_USER_6,TEXTO_USER_7,TEXTO_USER_8,TEXTO_USER_9,TEXTO_USER_10,UNIDAD_1,UNIDAD_2 FROM " + DB + ".DBO.BRC_CAMPOS_DEF_USUARIO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "CAMPOS", ref ControlError);

                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            User1 = ds.Tables[0].Rows[0]["TEXTO_USER_1"].ToString();
                            User2 = ds.Tables[0].Rows[0]["TEXTO_USER_2"].ToString();
                            User3 = ds.Tables[0].Rows[0]["TEXTO_USER_3"].ToString();
                            User4 = ds.Tables[0].Rows[0]["TEXTO_USER_4"].ToString();
                            User5 = ds.Tables[0].Rows[0]["TEXTO_USER_5"].ToString();
                            User6 = ds.Tables[0].Rows[0]["TEXTO_USER_6"].ToString();
                            User7 = ds.Tables[0].Rows[0]["TEXTO_USER_7"].ToString();
                            User8 = ds.Tables[0].Rows[0]["TEXTO_USER_8"].ToString();
                            User9 = ds.Tables[0].Rows[0]["TEXTO_USER_9"].ToString();
                            User10 = ds.Tables[0].Rows[0]["TEXTO_USER_10"].ToString();
                            Unidad_1 = ds.Tables[0].Rows[0]["UNIDAD_1"].ToString();
                            Unidad_2 = ds.Tables[0].Rows[0]["UNIDAD_2"].ToString();
                            int Position = 0;

                            if (!string.IsNullOrEmpty(User1))
                            {
                                lbl_user1.Text = User1;
                                gridView1.Columns["SM_USER_1"].Caption = User1;
                                Position = txt_user1.Location.X - lbl_user1.Size.Width - 5;
                                lbl_user1.Location = new Point(Position, lbl_user1.Location.Y);
                                txt_user1.Visible = true;
                                lbl_user1.Visible = true;
                                gridView1.Columns["SM_USER_1"].Visible = true;
                            }
                            else
                            {
                                txt_user1.Visible = false;
                                lbl_user1.Visible = false;
                                gridView1.Columns["SM_USER_1"].Visible = false;
                            
                            }


                            if (!string.IsNullOrEmpty(User2))
                            {
                                lbl_user2.Text = User2;
                                gridView1.Columns["SM_USER_2"].Caption = User2;
                                Position = txt_user2.Location.X - lbl_user2.Size.Width - 5;
                                lbl_user2.Location = new Point(Position, lbl_user2.Location.Y);
                                txt_user2.Visible = true;
                                lbl_user2.Visible = true;
                                gridView1.Columns["SM_USER_2"].Visible = true;
                            }
                            else
                            {
                                txt_user2.Visible = false;
                                lbl_user2.Visible = false;
                                gridView1.Columns["SM_USER_2"].Visible = false;
                            }



                            if (!string.IsNullOrEmpty(User3))
                            {
                                lbl_user3.Text = User3;
                                gridView1.Columns["SM_USER_3"].Caption = User3;
                                Position = txt_user3.Location.X - lbl_user3.Size.Width - 5;
                                lbl_user3.Location = new Point(Position, lbl_user3.Location.Y);
                                txt_user3.Visible = true;
                                lbl_user3.Visible = true;
                                gridView1.Columns["SM_USER_3"].Visible = true;
                            }
                            else
                            {
                                txt_user3.Visible = false;
                                lbl_user3.Visible = false;
                                gridView1.Columns["SM_USER_3"].Visible = false;
                            }


                            if (!string.IsNullOrEmpty(User4))
                            {
                                lbl_user4.Text = User4;
                                gridView1.Columns["SM_USER_4"].Caption = User4;
                                Position = txt_user4.Location.X - lbl_user4.Size.Width - 5;
                                lbl_user4.Location = new Point(Position, lbl_user4.Location.Y);
                                txt_user4.Visible = true;
                                lbl_user4.Visible = true;
                                gridView1.Columns["SM_USER_4"].Visible = true;
                            }
                            else
                            {
                                txt_user4.Visible = false;
                                lbl_user4.Visible = false;
                                gridView1.Columns["SM_USER_4"].Visible = false;
                            }



                            if (!string.IsNullOrEmpty(User5))
                            {
                                lbl_user5.Text = User5;
                                gridView1.Columns["SM_USER_5"].Caption = User5;
                                Position = txt_user5.Location.X - lbl_user5.Size.Width - 5;
                                lbl_user5.Location = new Point(Position, lbl_user5.Location.Y);
                                txt_user5.Visible = true;
                                lbl_user5.Visible = true;
                                gridView1.Columns["SM_USER_5"].Visible = true;
                            }
                            else
                            {
                                txt_user5.Visible = false;
                                lbl_user5.Visible = false;
                                gridView1.Columns["SM_USER_5"].Visible = false;
                            }


                            if (!string.IsNullOrEmpty(User6))
                            {
                                lbl_user6.Text = User6;
                                gridView1.Columns["SM_USER_6"].Caption = User6;
                                Position = txt_user6.Location.X - lbl_user6.Size.Width - 5;
                                lbl_user6.Location = new Point(Position, lbl_user6.Location.Y);
                                txt_user6.Visible = true;
                                lbl_user6.Visible = true;
                                gridView1.Columns["SM_USER_6"].Visible = true;
                            }
                            else
                            {
                                txt_user6.Visible = false;
                                lbl_user6.Visible = false;
                                gridView1.Columns["SM_USER_6"].Visible = false;
                            }


                            if (!string.IsNullOrEmpty(User7))
                            {
                                lbl_user7.Text = User7;
                                gridView1.Columns["SM_USER_7"].Caption = User7;
                                Position = txt_user7.Location.X - lbl_user7.Size.Width - 5;
                                lbl_user7.Location = new Point(Position, lbl_user7.Location.Y);
                                txt_user7.Visible = true;
                                lbl_user7.Visible = true;
                                gridView1.Columns["SM_USER_7"].Visible = true;
                            }
                            else
                            {
                                txt_user7.Visible = false;
                                lbl_user7.Visible = false;
                                gridView1.Columns["SM_USER_7"].Visible = false;
                            }


                            if (!string.IsNullOrEmpty(User8))
                            {
                                lbl_user8.Text = User8;
                                gridView1.Columns["SM_USER_8"].Caption = User8;
                                Position = txt_user8.Location.X - lbl_user8.Size.Width - 5;
                                lbl_user8.Location = new Point(Position, lbl_user8.Location.Y);
                                txt_user8.Visible = true;
                                lbl_user8.Visible = true;
                                gridView1.Columns["SM_USER_8"].Visible = true;
                            }
                            else
                            {
                                txt_user8.Visible = false;
                                lbl_user8.Visible = false;
                                gridView1.Columns["SM_USER_8"].Visible = false;
                            }


                            if (!string.IsNullOrEmpty(User9))
                            {
                                lbl_user9.Text = User9;
                                gridView1.Columns["SM_USER_9"].Caption = User9;
                                Position = txt_user9.Location.X - lbl_user9.Size.Width - 5;
                                lbl_user9.Location = new Point(Position, lbl_user9.Location.Y);
                                txt_user9.Visible = true;
                                lbl_user9.Visible = true;
                                gridView1.Columns["SM_USER_9"].Visible = true;
                            }
                            else
                            {
                                txt_user9.Visible = false;
                                lbl_user9.Visible = false;
                                gridView1.Columns["SM_USER_9"].Visible = false;
                            }



                            if (!string.IsNullOrEmpty(User10))
                            {
                                lbl_user10.Text = User10;
                                gridView1.Columns["SM_USER_10"].Caption = User10;
                                Position = txt_user10.Location.X - lbl_user10.Size.Width - 5;
                                lbl_user10.Location = new Point(Position, lbl_user10.Location.Y);
                                txt_user10.Visible = true;
                                lbl_user10.Visible = true;
                                gridView1.Columns["SM_USER_10"].Visible = true;
                            }
                            else
                            {
                                txt_user10.Visible = false;
                                lbl_user10.Visible = false;
                                gridView1.Columns["SM_USER_10"].Visible = false;
                            }


                            if (!string.IsNullOrEmpty(Unidad_1))
                            {
                                //SM_UNIDAD_1
                                lbl_unidad_1.Text = Unidad_1;
                                gridView1.Columns["SM_UNIDAD_1"].Caption = Unidad_1;
                                Position = lbl_unidad_1.Location.X - lbl_unidad_1.Size.Width - 5 + 52;
                                lbl_unidad_1.Location = new Point(Position, lbl_unidad_1.Location.Y);
                                lst_unidad1.Visible = true;
                                lbl_unidad_1.Visible = true;
                                gridView1.Columns["SM_UNIDAD_1"].Visible = true;
                            }
                            else
                            {
                                lst_unidad1.Visible = false;
                                lbl_unidad_1.Visible = false;
                                gridView1.Columns["SM_UNIDAD_1"].Visible = false;
                            }



                            if (!string.IsNullOrEmpty(Unidad_2))
                            {
                                //SM_UNIDAD_1
                                lbl_unidad_2.Text = Unidad_2;
                                gridView1.Columns["SM_UNIDAD_2"].Caption = Unidad_2;
                                Position = lbl_unidad_2.Location.X - lbl_unidad_2.Size.Width - 5 + 52;
                                lbl_unidad_2.Location = new Point(Position, lbl_unidad_2.Location.Y);
                                lst_unidad2.Visible = true;
                                lbl_unidad_2.Visible = true;
                                gridView1.Columns["SM_UNIDAD_2"].Visible = true;
                            }
                            else
                            {
                                lst_unidad2.Visible = false;
                                lbl_unidad_2.Visible = false;
                                gridView1.Columns["SM_UNIDAD_2"].Visible = false;
                            }
                        }

                        barButtonItem11.PerformClick();
                    }
                    else
                    {

                        MessageBox.Show("Debe seleccionar un departamento y una fecha para poder buscar los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }




                }

                string CuentaSumatoria = "";
                CuentaSumatoria = consulta.ejecutaEscalar( "SELECT COUNT(ID_SUMATORIA) FROM "+DB+".DBO.BRC_SUMATORIA WHERE ID_TAGS='"+IdTag+"'",ref ControlError);
                
                if (string.IsNullOrEmpty(CuentaSumatoria))
                    CuentaSumatoria = "0";

                if (Convert.ToInt32( CuentaSumatoria) == 0)
                {
                    

                    if (Convert.ToDecimal(PublicUnidad1) > 0 && Convert.ToDecimal(PublicUnidad2) > 0) {

                        consulta.insertar("INSERT INTO "+DB+".DBO.BRC_SUMATORIA(ID_TAGS,SM_UNIDAD_1,SM_UNIDAD_2,SM_USER_1,SM_USER_2,SM_USER_3,SM_USER_4,SM_USER_5,SM_USER_6,SM_USER_7,SM_USER_8,SM_USER_9,SM_USER_10,FECHA_CREACION) VALUES('"+IdTag+"',"+PublicUnidad1+","+PublicUnidad2+",'"+PublicUser1+"','"+PublicUser2+"','"+PublicUser3+"','"+PublicUser4+"','"+PublicUser5+"','"+PublicUser6+"','"+PublicUser7+"','"+PublicUser8+"','"+PublicUser9+"','"+PublicUser10+"',GETDATE())",ref ControlError);
                        if (ControlError != "Completado") {
                            MessageBox.Show("Ocurrio un error favor contactar con su administrador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        
                        }

                        bRC_SUMATORIATableAdapter.FillObtenerSumatoria(dataSetSumatoriaTags.BRC_SUMATORIA, IdTag);


                      
                    }
                    
                
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex + " ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
        }


        public void CalcularFormulas()
        {

            string ControlError = "";
            conexion consulta = new conexion();
            consulta.SetDB(DB);
            consulta.SetUsuario(User_id);
            consulta.SetPassword(Pass);
            consulta.SetServer(Server);
            DataSet ds = new DataSet();
            if (EstaEditando == true)
            {
                ds = consulta.consultaSelect("SELECT ORDEN,FORMULA,CAMPO_DEF_USR FROM " + DB + ".DBO.BRC_FORMULAS WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' ORDER BY ORDEN ASC", "FORMULAS", ref ControlError);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string Campo = "";
                    string Formula = "";
                    string Resultado = "";
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
                    string Unidad_1 = "";
                    string Unidad_2 = "";


                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        Campo = ds.Tables[0].Rows[i]["CAMPO_DEF_USR"].ToString();
                        Formula = ds.Tables[0].Rows[i]["FORMULA"].ToString();
                        Formula = Formula.Replace("@TAG", txt_tag.EditValue.ToString());


                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user1.EditValue)))
                            User1 = txt_user1.EditValue.ToString();
                        else
                            User1 = "";


                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user2.EditValue)))
                            User2 = txt_user2.EditValue.ToString();
                        else
                            User2 = "";


                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user3.EditValue)))
                            User3 = txt_user3.EditValue.ToString();
                        else
                            User3 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user4.EditValue)))
                            User4 = txt_user4.EditValue.ToString();
                        else
                            User4 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user5.EditValue)))
                            User5 = txt_user5.EditValue.ToString();
                        else
                            User5 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user6.EditValue)))
                            User6 = txt_user6.EditValue.ToString();
                        else
                            User6 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user7.EditValue)))
                            User7 = txt_user7.EditValue.ToString();
                        else
                            User7 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user8.EditValue)))
                            User8 = txt_user8.EditValue.ToString();
                        else
                            User8 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user9.EditValue)))
                            User9 = txt_user9.EditValue.ToString();
                        else
                            User9 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(txt_user10.EditValue)))
                            User10 = txt_user10.EditValue.ToString();
                        else
                            User10 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                            Unidad_1 = lst_unidad1.EditValue.ToString();
                        else
                            Unidad_1 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                            Unidad_2 = lst_unidad2.EditValue.ToString();
                        else
                            Unidad_2 = "";





                        if (User1 != "")
                            Formula = Formula.Replace("USER_1", User1);
                        else
                            Formula = Formula.Replace("USER_1", "NULL");


                        if (User2 != "")
                            Formula = Formula.Replace("USER_2", User2);
                        else
                            Formula = Formula.Replace("USER_2", "NULL");


                        if (User3 != "")
                            Formula = Formula.Replace("USER_3", User3);
                        else
                            Formula = Formula.Replace("USER_3", "NULL");



                        if (User4 != "")
                            Formula = Formula.Replace("USER_4", User4);
                        else
                            Formula = Formula.Replace("USER_4", "NULL");


                        if (User5 != "")
                            Formula = Formula.Replace("USER_5", User5);
                        else
                            Formula = Formula.Replace("USER_5", "NULL");


                        if (User6 != "")
                            Formula = Formula.Replace("USER_6", User6);
                        else
                            Formula = Formula.Replace("USER_6", "NULL");


                        if (User7 != "")
                            Formula = Formula.Replace("USER_7", User7);
                        else
                            Formula = Formula.Replace("USER_7", "NULL");


                        if (User8 != "")
                            Formula = Formula.Replace("USER_8", User8);
                        else
                            Formula = Formula.Replace("USER_8", "NULL");


                        if (User9 != "")
                            Formula = Formula.Replace("USER_9", User9);
                        else
                            Formula = Formula.Replace("USER_9", "NULL");


                        if (User10 != "")
                            Formula = Formula.Replace("USER_10", User10);
                        else
                            Formula = Formula.Replace("USER_10", "NULL");


                        if (Unidad_1 != "")
                            Formula = Formula.Replace("UNIDAD_1", Unidad_1);
                        else
                            Formula = Formula.Replace("UNIDAD_1", "NULL");


                        if (Unidad_2 != "")
                            Formula = Formula.Replace("UNIDAD_2", Unidad_2);
                        else
                            Formula = Formula.Replace("UNIDAD_2", "NULL");


                        Resultado = consulta.ejecutaEscalar(Formula, ref ControlError);

                        if (Campo == "TEXTO_USER_01")
                            txt_user1.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_02")
                            txt_user2.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_03")
                            txt_user3.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_04")
                            txt_user4.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_05")
                            txt_user5.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_06")
                            txt_user6.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_07")
                            txt_user7.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_08")
                            txt_user8.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_09")
                            txt_user9.EditValue = Resultado;

                        if (Campo == "TEXTO_USER_10")
                            txt_user10.EditValue = Resultado;

                        if (Campo == "UNIDAD_1")
                        {

                            if (string.IsNullOrEmpty(Resultado))
                                lst_unidad1.EditValue = "0";
                            else
                                lst_unidad1.EditValue = Resultado;

                        }
                        if (Campo == "UNIDAD_2")
                        {
                            if (string.IsNullOrEmpty(Resultado))
                                lst_unidad2.EditValue = "0";
                            else
                                lst_unidad2.EditValue = Resultado;
                        }
                    }


                }


            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            //try
            //{
            //    tm_lectura.Enabled = false;
            //    Thread.Sleep(200);
            //    if (sp1.IsOpen == true)
            //    {
            //        sp1.Close();
            //    }
            //    else
            //    {
            //        sp1.Open();
            //    }
            //}
            //catch (Exception Ex)
            //{


            //}

            this.Close();
        }
        public string Concatenados = "";
        private void sp1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //try
            //{
            //    string DatosRecibidos;
            //    Concatenados =Concatenados+ sp1.ReadLine();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}

            //try
            //{
            //    if (sp1.IsOpen)
            //    {
            //        string DatosRecibidos;


            //        if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "TOLEDOIND221")
            //        {
            //            Concatenados = Concatenados + sp1.ReadLine();
            //        }
            //        if (MarcaBascula == "BREKNELLSIB100")
            //        {
            //            DatosRecibidos = sp1.ReadLine();
            //            if ((DatosRecibidos.ToLower().Contains("kg") || DatosRecibidos.ToLower().Contains("kls")) && DatosRecibidos.Contains("Gro") == true)
            //                Concatenados = Concatenados + DatosRecibidos;
            //        }
            //    }
            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }
        public bool IsNumeric(object Expression)
        {

            bool isNum;

            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;

        }
        private void tm_lectura_Tick(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "TOLEDOIND221")
            //{

            //    if (sp1.IsOpen == true)
            //        sp1.WriteLine("S\r\n");


            //    lbl_kls.Text = "Kls: " + Concatenados.Replace("kg", "").Replace("SS", "").Replace("SD", "").Replace(" ", "").Replace("ES", "").Replace("SS", "").Replace("SD", "");

            //    Concatenados = "";
            //}


            //if (MarcaBascula == "BREKNELLSIB100")
            //{

            //    if (sp1.IsOpen == true)
            //        sp1.WriteLine("W\r\n");


            //    lbl_kls.Text = "Kls: " + Concatenados.Replace("kg", "").Replace("0p1", "").Replace("?", "").Replace(" ", "");

            //    Concatenados = "";
            //}

            if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "TOLEDOIND221")
            {

                //if (sp1.IsOpen == true)
                //    sp1.WriteLine("S\r\n");


                lbl_kls.Text = "Kls: " + Concatenados.Replace("kg", "").Replace("SS", "").Replace("SD", "").Replace(" ", "").Replace("ES", "").Replace("SS", "").Replace("SD", "");

                Concatenados = "";
            }

       


            if (MarcaBascula == "BREKNELLSIB100" || MarcaBascula == "BREKNELLSIB505")
            {
                string ValorProcesado = "";
                decimal ValorTruncado = 0;
                bool BienConvertido = false;
                //if (sp1.IsOpen == true)
                //    sp1.WriteLine("W\r\n");

               
                //ValorProcesado = Concatenados.Replace("kg", "").Replace("0p1", "").Replace("?", "").Replace(" ", "").Replace("2p2", "").Replace("2p", "").Replace("p2", "").Replace(Convert.ToChar(13), Convert.ToChar(32)).Replace(Convert.ToChar(3), Convert.ToChar(32)).Replace(" ", "").Replace("p", "").Replace(Convert.ToChar(13),Convert.ToChar(32));
                //ValorProcesado = Concatenados.Replace(" ", "").Replace(Convert.ToChar(13), Convert.ToChar(32)).Replace("kg", "").Replace(Convert.ToChar(3), Convert.ToChar(32)).Replace("Gross", "").Replace(":", "");

                //DevExpress.XtraEditors.LabelControl TextoTemporal = (DevExpress.XtraEditors.LabelControl)Form1.f1.Controls["lbl_kls"];
                ValorProcesado = Form1.f1.ValorLabel;
                //if (!string.IsNullOrEmpty(ValorProcesado))
                //{
                //    try
                //    {

                //        ValorTruncado = Convert.ToDecimal(ValorProcesado);
                //        BienConvertido = true;
                //    }
                //    catch (Exception ex)
                //    {
                //        BienConvertido = false;
                //        Concatenados = "";
                //    }
                //}
                //else
                //{

                //    BienConvertido = false;


                //}
                //if (IsNumeric(ValorProcesado) == true)
                //{
                //    BienConvertido = true;
                //}
                //else {
                //    BienConvertido = false;
                //    Concatenados = "";

                //}

                //if (BienConvertido == true)
                //{
                    lbl_kls.Text = ValorProcesado;
                  //  Concatenados = "";


                    //lbl_kls.Text = "Kls: " + Concatenados.Replace(" ","").Replace(Convert.ToChar(13),Convert.ToChar(32)).Replace("kg","").Replace(Convert.ToChar(3), Convert.ToChar(32)).Replace("Gross","").Replace(":","");

                    //Concatenados = "";
                //}
                //char tempvalor;
                //for (int i = 0; i < lbl_kls.Text.ToString().Length; i++) {
                //    tempvalor = lbl_kls.Text.ToString()[i];
                //}


            }
        
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                bRC_SUMATORIATableAdapter.FillObtenerSumatoria(dataSetSumatoriaTags.BRC_SUMATORIA, IdTag);
            
            }
            catch(Exception ex){

                MessageBox.Show("Ocurrio un error favor contactar a su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                string ErrorSql = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);

                txt_tag.ReadOnly = true;
                txt_user1.Enabled = true;
                txt_user2.Enabled = true;
                txt_user3.Enabled = true;
                txt_user4.Enabled = true;
                txt_user5.Enabled = true;
                txt_user6.Enabled = true;
                txt_user7.Enabled = true;
                txt_user8.Enabled = true;
                txt_user9.Enabled = true;
                txt_user10.Enabled = true;
                lst_unidad1.Enabled = true;
                lst_unidad2.Enabled = true;
      
                //Evento del boton nuevo
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido 
                //Agrega un nuevo registro de los programas
              
                
                txt_tag.EditValue = IdTag;
                txt_user2.EditValue = PublicUser2;
                txt_user3.EditValue = PublicUser3;
                txt_user4.EditValue = PublicUser4;
                txt_user5.EditValue = PublicUser5;
                txt_user6.EditValue = PublicUser6;
                txt_user7.EditValue = PublicUser7;
                txt_user8.EditValue = PublicUser8;
                txt_user9.EditValue = PublicUser9;
                txt_user10.EditValue = PublicUser10;

              
                lst_unidad1.EditValue = "0";
                lst_unidad2.EditValue = "0";
                barButtonItem6.Enabled = true;
                EstaEditando = true;
                lst_unidad1.Focus();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_user1_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user2_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user3_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user4_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user5_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user6_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user7_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user8_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user9_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void txt_user10_EditValueChanged(object sender, EventArgs e)
        {
            if (EstaEditando == true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
        }

        private void lst_unidad1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                barButtonItem16.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactarse con su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (lst_unidad2.Enabled == true)
                {
                    if (string.IsNullOrEmpty(lbl_kls.Text.ToString().Replace("Kls:", "").Trim()))
                        txt_user1.EditValue = "0";
                    else
                        txt_user1.EditValue = lbl_kls.Text.ToString().Replace("Kls:", "").Trim();

                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                        lst_unidad1.EditValue = "0";

                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                        lst_unidad2.EditValue = "0";

                    if (EstaEditando == true)
                        if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                        {
                            CalcularFormulas();
                            //this.Validate();
                            //bRCTAGSBindingSource.EndEdit();

                            //bRC_TAGSTableAdapter.Update(dataSetTags);
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactar al administrador:" + ex.Message.ToString());

            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                //barButtonItem16.PerformClick();
                CalcularFormulas();
                string ControlError="";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);

                if (lst_unidad2.Visible == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad2.Focus();
                        return;
                    }
                }

                if (lst_unidad1.Visible == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad1.Focus();
                        return;
                    }
                }

                if (txt_user1.Visible == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(txt_user1.EditValue)))
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_user1.Focus();
                        return;
                    }
                }

                if (lst_unidad2.Visible == true)
                {
                    if (Convert.ToDecimal(lst_unidad2.EditValue.ToString()) <= 0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad2.Focus();
                        return;
                    }
                }

                if (lst_unidad1.Visible == true)
                {
                    if (Convert.ToDecimal(lst_unidad1.EditValue.ToString()) <= 0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad1.Focus();
                        return;
                    }
                }

                if (txt_user1.Visible == true)
                {
                    if (Convert.ToDecimal(txt_user1.EditValue.ToString()) <= 0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_user1.Focus();
                        return;
                    }
                }

                
                if (txt_tag.EditValue.ToString() == "-")
                {
                    MessageBox.Show("Debe de ingresar bien un correlativo antes de guardar, si no puede hacerlo , presione el boton cancelar he intente ingresarlo nuevametne.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
             
                CalcularFormulas();
                if (txt_tag.EditValue.ToString() == "-")
                {
                    MessageBox.Show("Debe de ingresar bien un correlativo antes de guardar, si no puede hacerlo , presione el boton cancelar he intente ingresarlo nuevametne.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lst_unidad2.Visible == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad2.Focus();
                        return;
                    }
                }

                if (lst_unidad1.Visible == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad1.Focus();
                        return;
                    }
                }


                if (txt_user1.Visible == true)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(txt_user1.EditValue)))
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_user1.Focus();
                        return;
                    }
                }

                if (lst_unidad2.Visible == true)
                {
                    if (Convert.ToDecimal(lst_unidad2.EditValue.ToString()) <= 0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad2.Focus();
                        return;
                    }
                }

                if (lst_unidad1.Visible == true)
                {
                    if (Convert.ToDecimal(lst_unidad1.EditValue.ToString()) <= 0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lst_unidad1.Focus();
                        return;
                    }
                }

                if (txt_user1.Visible == true)
                {
                    if (Convert.ToDecimal(txt_user1.EditValue.ToString()) <= 0)
                    {
                        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_user1.Focus();
                        return;
                    }
                }


                string TempUnidad1 = "";
                string TempUnidad2 = "";
                string TempUser1 = "";
                string TempUser2 = "";
                string TempUser3 = "";
                string TempUser4 = "";
                string TempUser5 = "";
                string TempUser6 = "";
                string TempUser7 = "";
                string TempUser8 = "";
                string TempUser9 = "";
                string TempUser10 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                    TempUnidad1 = Convert.ToString(lst_unidad1.EditValue);
                else
                    TempUnidad1 = "0";

                if (!string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                    TempUnidad2 = Convert.ToString(lst_unidad2.EditValue);
                else
                    TempUnidad2 = "0";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user1.EditValue)))
                    TempUser1 = Convert.ToString(txt_user1.EditValue);
                else
                    TempUser1 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user2.EditValue)))
                    TempUser2 = Convert.ToString(txt_user2.EditValue);
                else
                    TempUser2 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user3.EditValue)))
                    TempUser3 = Convert.ToString(txt_user3.EditValue);
                else
                    TempUser3 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user4.EditValue)))
                    TempUser4 = Convert.ToString(txt_user4.EditValue);
                else
                    TempUser4 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user5.EditValue)))
                    TempUser5 = Convert.ToString(txt_user5.EditValue);
                else
                    TempUser5 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user6.EditValue)))
                    TempUser6 = Convert.ToString(txt_user6.EditValue);
                else
                    TempUser6 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user7.EditValue)))
                    TempUser7 = Convert.ToString(txt_user7.EditValue);
                else
                    TempUser7 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user8.EditValue)))
                    TempUser8 = Convert.ToString(txt_user8.EditValue);
                else
                    TempUser8 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user9.EditValue)))
                    TempUser9 = Convert.ToString(txt_user9.EditValue);
                else
                    TempUser9 = "";

                if (!string.IsNullOrEmpty(Convert.ToString(txt_user10.EditValue)))
                    TempUser10 = Convert.ToString(txt_user10.EditValue);
                else
                    TempUser10 = "";





                consulta.insertar("INSERT INTO " + DB + ".DBO.BRC_SUMATORIA(ID_TAGS,SM_UNIDAD_1,SM_UNIDAD_2,SM_USER_1,SM_USER_2,SM_USER_3,SM_USER_4,SM_USER_5,SM_USER_6,SM_USER_7,SM_USER_8,SM_USER_9,SM_USER_10,FECHA_CREACION) VALUES('" + IdTag + "'," + TempUnidad1 + "," + TempUnidad2 + ",'" + TempUser1 + "','" + TempUser2 + "','" + TempUser3 + "','" + TempUser4 + "','" + TempUser5 + "','" + TempUser6 + "','" + TempUser7 + "','" + TempUser8 + "','" + TempUser9 + "','" + TempUser10 + "',GETDATE())", ref ControlError);
                if (ControlError != "Completado")
                {
                    MessageBox.Show("Ocurrio un error favor contactar con su administrador:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                txt_user1.Enabled = false;
                txt_user2.Enabled = false;
                txt_user3.Enabled = false;
                txt_user4.Enabled = false;
                txt_user5.Enabled = false;
                txt_user6.Enabled = false;
                txt_user7.Enabled = false;
                txt_user8.Enabled = false;
                txt_user9.Enabled = false;
                txt_user10.Enabled = false;
                lst_unidad1.Enabled = false;
                lst_unidad2.Enabled = false;

                txt_user1.EditValue = "";
                txt_user2.EditValue = "";
                txt_user3.EditValue = "";
                txt_user4.EditValue = "";
                txt_user5.EditValue = "";
                txt_user6.EditValue = "";
                txt_user7.EditValue = "";
                txt_user8.EditValue = "";
                txt_user9.EditValue = "";
                txt_user10.EditValue = "";
                lst_unidad1.EditValue = "";
                lst_unidad2.EditValue = "";


                bRC_SUMATORIATableAdapter.FillObtenerSumatoria(dataSetSumatoriaTags.BRC_SUMATORIA, IdTag);

                
                barButtonItem6.Enabled = false;
                EstaEditando = false;


            }
            catch(Exception Ex){
                MessageBox.Show("Ocurrio un error favor contactar al administrador:"+Ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {
                string MinRegistro = "";
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DialogResult Resultado = MessageBox.Show(" *** ¿Esta seguro de borrar el pesaje?  ***", "Borrar Pesaje", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                if (Resultado == DialogResult.OK)
                {
                    MinRegistro = consulta.ejecutaEscalar("SELECT MIN(ID_SUMATORIA) FROM "+DB+".DBO.BRC_SUMATORIA WHERE ID_TAGS='"+IdTag+"'", ref ControlError);

                    if (ControlError == "Completado")
                    {
                        if (MinRegistro == gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_SUMATORIA").ToString())
                        {
                            bRC_SUMATORIATableAdapter.FillObtenerSumatoria(dataSetSumatoriaTags.BRC_SUMATORIA, IdTag);
                            MessageBox.Show("No puede borrar el primer registro guardado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;


                        }
                        else
                        {
                            consulta.insertar("DELETE " + DB + ".DBO.BRC_SUMATORIA where ID_TAGS='" + IdTag + "' and ID_SUMATORIA=" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_SUMATORIA").ToString(), ref ControlError);
                            bRC_SUMATORIATableAdapter.FillObtenerSumatoria(dataSetSumatoriaTags.BRC_SUMATORIA, IdTag);
                        }


                    }
                    else {
                        MessageBox.Show("Ocurrio un error favor contactar a su administrador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    
                    }
                }
            

            
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar a su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Evento del boton primero
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido

                //Mueve al primer registro del los programas

                bRCSUMATORIABindingSource.MoveFirst();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Evento del boton previo
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido
                //Mueve al anterior registro los registros de los programas
                bRCSUMATORIABindingSource.MovePrevious();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Evento del boton siguiente
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido 
                //Mueve al siguiente registro de los programas
                bRCSUMATORIABindingSource.MoveNext();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Evento del boton ultimo
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido 
                //Mueve al ulltimo registro de los programas
                bRCSUMATORIABindingSource.MoveLast();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
