using brc_tags.Librerias;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace brc_tags
{
    public partial class DatosTagConsecutivos : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string Origen;
        public string Respuesta;
        public string IdTipoPlantilla;
        public string Fecha;
        public string ResetearLectura;
        //------------------
        public string Turno;
        public string Maquina;
        public string Articulo;
        public string Op;
        public string Operador;
        public string Unidad1;
        public string Unidad2;

        public string User1;
        public string User2;
        public string User3;
        public string User4;
        public string User5;
        public string User6;
        public string User7;
        public string User8;
        public string User9;
        public string USer10;
        public string Cantidad;
        public ArrayList CodigoUniversalInfoMaquina;
        public ArrayList CodigoUniversalTurno;
        public string FechaBuscada;
        public DatosTagConsecutivos()
        {
            InitializeComponent();
        }

        private void DatosTagConsecutivos_Load(object sender, EventArgs e)
        {

            try {

                CodigoUniversalInfoMaquina = new ArrayList();
                CodigoUniversalTurno = new ArrayList();

                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();


                string Sufijo = "";

                Sufijo = consulta.ejecutaEscalar("SELECT SUFIJO FROM " + DB + ".DBO.BRC_CORRELATIVOS where ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y'", ref ControlError);

                ds = consulta.consultaSelect("SELECT 'A' AS Codigo ,'Turno A' as Nombre UNION SELECT 'B' AS Codigo ,'Turno B' as Nombre ", "TURNO", ref ControlError);
                lst_turno.Properties.DataSource = ds.Tables[0];
                lst_turno.Properties.ValueMember = "Codigo";
                lst_turno.Properties.DisplayMember = "Nombre";
                lst_turno.EditValue = "A";

                ds = consulta.consultaSelect("SELECT ID AS Codigo,DESCRIPTION AS Nombre FROM " + DB + ".DBO.BRC_PART  ", "ARTICULO", ref ControlError);
                lst_articulo.Properties.DataSource = ds.Tables[0];
                lst_articulo.Properties.ValueMember = "Codigo";
                lst_articulo.Properties.DisplayMember = "Nombre";


                ds = consulta.consultaSelect("SELECT W.BASE_ID AS Codigo,W.PART_ID COLLATE DATABASE_DEFAULT  +' - '+P.DESCRIPTION as Nombre FROM " + SMVISUAL + ".DBO.WORK_ORDER AS W WITH (NOLOCK)," + DB + ".DBO.BRC_PART AS P WITH (NOLOCK) WHERE W.BASE_ID LIKE '%-" + Sufijo + "' AND W.TYPE='W' AND W.PART_ID COLLATE DATABASE_DEFAULT  =P.ID COLLATE DATABASE_DEFAULT  ", "OP", ref ControlError);
                lst_op.Properties.DataSource = ds.Tables[0];
                lst_op.Properties.ValueMember = "Codigo";
                lst_op.Properties.DisplayMember = "Codigo";

                ds = consulta.consultaSelect("SELECT DISTINCT M.ID_MAQUINA as Codigo,S.DESCRIPTION AS Nombre FROM " + DB + ".DBO.PRD_USUARIO_MAQUINA AS M ," + SMVISUAL + ".DBO.SHOP_RESOURCE AS S WHERE M.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND M.ID_MAQUINA COLLATE DATABASE_DEFAULT =S.ID COLLATE DATABASE_DEFAULT ", "MAQUINAS", ref ControlError);
                lst_maquina.Properties.DataSource = ds.Tables[0];
                lst_maquina.Properties.ValueMember = "Codigo";
                lst_maquina.Properties.DisplayMember = "Nombre";

                ds = consulta.consultaSelect("SELECT ID_OPERADOR AS Codigo, NOMBRE as Nombre FROM " + DB + ".DBO.PRD_OPERADOR WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "OPERADOR", ref ControlError);
                lst_operador.Properties.DataSource = ds.Tables[0];
                lst_operador.Properties.ValueMember = "Codigo";
                lst_operador.Properties.DisplayMember = "Nombre";

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
                ds = consulta.consultaSelect("SELECT ISNULL(CREAR,'N') AS CREAR,ISNULL(LEER,'N') AS LEER, ISNULL(MODIFICAR,'N') AS MODIFICAR FROM " + DB + ".DBO.BRC_USUARIO_DEPARTAMENTO WHERE ID_USUARIO='" + User_id + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "PERMISOS", ref ControlError);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Crear = ds.Tables[0].Rows[0]["CREAR"].ToString();
                    Leer = ds.Tables[0].Rows[0]["LEER"].ToString();
                    Modificar = ds.Tables[0].Rows[0]["MODIFICAR"].ToString();
                }

               


                if (!string.IsNullOrEmpty(Sufijo))
                {

                    ds = consulta.consultaSelect("SELECT W.BASE_ID AS Codigo,W.PART_ID COLLATE DATABASE_DEFAULT +' - '+P.DESCRIPTION as Nombre FROM " + SMVISUAL + ".DBO.WORK_ORDER AS W WITH (NOLOCK)," + DB + ".DBO.BRC_PART AS P WITH (NOLOCK) WHERE W.BASE_ID LIKE '%-" + Sufijo + "' AND W.TYPE='W' AND W.PART_ID COLLATE DATABASE_DEFAULT =P.ID COLLATE DATABASE_DEFAULT ", "OP", ref ControlError);
                    lst_op.Properties.DataSource = ds.Tables[0];
                    lst_op.Properties.ValueMember = "Codigo";
                    lst_op.Properties.DisplayMember = "Codigo";

                    ds = consulta.consultaSelect("SELECT DISTINCT M.ID_MAQUINA as Codigo,S.DESCRIPTION AS Nombre FROM " + DB + ".DBO.PRD_USUARIO_MAQUINA AS M ," + SMVISUAL + ".DBO.SHOP_RESOURCE AS S WHERE M.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND M.ID_MAQUINA COLLATE DATABASE_DEFAULT =S.ID COLLATE DATABASE_DEFAULT ", "MAQUINAS", ref ControlError);
                    lst_maquina.Properties.DataSource = ds.Tables[0];
                    lst_maquina.Properties.ValueMember = "Codigo";
                    lst_maquina.Properties.DisplayMember = "Nombre";

                    ds = consulta.consultaSelect("SELECT ID_OPERADOR AS Codigo, NOMBRE as Nombre FROM " + DB + ".DBO.PRD_OPERADOR WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "OPERADOR", ref ControlError);
                    lst_operador.Properties.DataSource = ds.Tables[0];
                    lst_operador.Properties.ValueMember = "Codigo";
                    lst_operador.Properties.DisplayMember = "Nombre";



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
                            Position = txt_user1.Location.X - lbl_user1.Size.Width - 5;
                            lbl_user1.Location = new Point(Position, lbl_user1.Location.Y);
                            txt_user1.Visible = true;
                            lbl_user1.Visible = true;
                        }
                        else
                        {
                            txt_user1.Visible = false;
                            lbl_user1.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(User2))
                        {
                            lbl_user2.Text = User2;
                            Position = txt_user2.Location.X - lbl_user2.Size.Width - 5;
                            lbl_user2.Location = new Point(Position, lbl_user2.Location.Y);
                            txt_user2.Visible = true;
                            lbl_user2.Visible = true;
                        }
                        else
                        {
                            txt_user2.Visible = false;
                            lbl_user2.Visible = false;
                        }



                        if (!string.IsNullOrEmpty(User3))
                        {
                            lbl_user3.Text = User3;
                            Position = txt_user3.Location.X - lbl_user3.Size.Width - 5;
                            lbl_user3.Location = new Point(Position, lbl_user3.Location.Y);
                            txt_user3.Visible = true;
                            lbl_user3.Visible = true;
                        }
                        else
                        {
                            txt_user3.Visible = false;
                            lbl_user3.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(User4))
                        {
                            lbl_user4.Text = User4;
                            Position = txt_user4.Location.X - lbl_user4.Size.Width - 5;
                            lbl_user4.Location = new Point(Position, lbl_user4.Location.Y);
                            txt_user4.Visible = true;
                            lbl_user4.Visible = true;
                        }
                        else
                        {
                            txt_user4.Visible = false;
                            lbl_user4.Visible = false;
                        }



                        if (!string.IsNullOrEmpty(User5))
                        {
                            lbl_user5.Text = User5;
                            Position = txt_user5.Location.X - lbl_user5.Size.Width - 5;
                            lbl_user5.Location = new Point(Position, lbl_user5.Location.Y);
                            txt_user5.Visible = true;
                            lbl_user5.Visible = true;
                        }
                        else
                        {
                            txt_user5.Visible = false;
                            lbl_user5.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(User6))
                        {
                            lbl_user6.Text = User6;
                            Position = txt_user6.Location.X - lbl_user6.Size.Width - 5;
                            lbl_user6.Location = new Point(Position, lbl_user6.Location.Y);
                            txt_user6.Visible = true;
                            lbl_user6.Visible = true;
                        }
                        else
                        {
                            txt_user6.Visible = false;
                            lbl_user6.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(User7))
                        {
                            lbl_user7.Text = User7;
                            Position = txt_user7.Location.X - lbl_user7.Size.Width - 5;
                            lbl_user7.Location = new Point(Position, lbl_user7.Location.Y);
                            txt_user7.Visible = true;
                            lbl_user7.Visible = true;
                        }
                        else
                        {
                            txt_user7.Visible = false;
                            lbl_user7.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(User8))
                        {
                            lbl_user8.Text = User8;
                            Position = txt_user8.Location.X - lbl_user8.Size.Width - 5;
                            lbl_user8.Location = new Point(Position, lbl_user8.Location.Y);
                            txt_user8.Visible = true;
                            lbl_user8.Visible = true;
                        }
                        else
                        {
                            txt_user8.Visible = false;
                            lbl_user8.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(User9))
                        {
                            lbl_user9.Text = User9;
                            Position = txt_user9.Location.X - lbl_user9.Size.Width - 5;
                            lbl_user9.Location = new Point(Position, lbl_user9.Location.Y);
                            txt_user9.Visible = true;
                            lbl_user9.Visible = true;
                        }
                        else
                        {
                            txt_user9.Visible = false;
                            lbl_user9.Visible = false;
                        }



                        if (!string.IsNullOrEmpty(User10))
                        {
                            lbl_user10.Text = User10;
                            Position = txt_user10.Location.X - lbl_user10.Size.Width - 5;
                            lbl_user10.Location = new Point(Position, lbl_user10.Location.Y);
                            txt_user10.Visible = true;
                            lbl_user10.Visible = true;
                        }
                        else
                        {
                            txt_user10.Visible = false;
                            lbl_user10.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(Unidad_1))
                        {
                            lbl_unidad_1.Text = Unidad_1;
                            Position = lbl_unidad_1.Location.X - lbl_unidad_1.Size.Width - 5 + 52;
                            lbl_unidad_1.Location = new Point(Position, lbl_unidad_1.Location.Y);
                            txt_unidad1.Visible = true;
                            lbl_unidad_1.Visible = true;
                        }
                        else
                        {
                            txt_unidad1.Visible = false;
                            lbl_unidad_1.Visible = false;
                        }


                        if (!string.IsNullOrEmpty(Unidad_2))
                        {
                            lbl_unidad_2.Text = Unidad_2;
                            Position = lbl_unidad_2.Location.X - lbl_unidad_2.Size.Width - 5 + 52;
                            lbl_unidad_2.Location = new Point(Position, lbl_unidad_2.Location.Y);
                            txt_unidad2.Visible = true;
                            lbl_unidad_2.Visible = true;
                        }
                        else
                        {
                            txt_unidad2.Visible = false;
                            lbl_unidad_2.Visible = false;
                        }
                    }

                    
                }
                else
                {

                    MessageBox.Show("Debe seleccionar un departamento y una fecha para poder buscar los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar a su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Respuesta="CANCELADO";

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Respuesta = "CANCELADO";
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txt_unidad2.Visible == true)
            {
                if (string.IsNullOrEmpty(Convert.ToString(txt_unidad2.EditValue)))
                {
                    MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_unidad2.Focus();
                    return;
                }
            }


            if (txt_unidad1.Visible == true)
            {
                if (string.IsNullOrEmpty(Convert.ToString(txt_unidad1.EditValue)))
                {
                    MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_unidad1.Focus();
                    return;
                }
            }


            //if (txt_user1.Visible == true)
            //{
            //    if (string.IsNullOrEmpty(Convert.ToString(txt_user1.EditValue)))
            //    {
            //        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txt_user1.Focus();
            //        return;
            //    }
            //}

            if (txt_unidad2.Visible == true)
            {
                if (Convert.ToDecimal(txt_unidad2.EditValue.ToString()) <= 0)
                {
                    MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_unidad2.Focus();
                    return;
                }
            }


            if (txt_unidad1.Visible == true)
            {
                if (Convert.ToDecimal(txt_unidad1.EditValue.ToString()) <= 0)
                {
                    MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_unidad1.Focus();
                    return;
                }
            }

            //if (txt_user1.Visible == true)
            //{
            //    if (Convert.ToDecimal(txt_user1.EditValue.ToString()) <= 0)
            //    {
            //        MessageBox.Show("Debe ingresar un valor mayor a cero en alguno de los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txt_user1.Focus();
            //        return;
            //    }
            //}

            
            if (string.IsNullOrEmpty(Convert.ToString(txt_cantidad.EditValue))) {
                MessageBox.Show("Debe de ingresar una cantidad de tags.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }

            if (Convert.ToDecimal(txt_cantidad.EditValue.ToString()) <= 0) {

                MessageBox.Show("Debe de ingresar una cantidad de tags mayor a cero.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_cantidad.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Convert.ToString(lst_turno.EditValue))) {
                MessageBox.Show("Debe de seleccionar un turno, favor seleccionarlo antes de crear los tags.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            
            
            }
            if (string.IsNullOrEmpty(Convert.ToString(lst_articulo.EditValue)))
            {
                MessageBox.Show("Debe de seleccionar un articulo, favor seleccionarlo antes de crear los tags.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            if(!string.IsNullOrEmpty(Convert.ToString(lst_turno.EditValue)))
                Turno=lst_turno.EditValue.ToString();
                
            else
                Turno="";

            if(!string.IsNullOrEmpty(Convert.ToString(lst_maquina.EditValue)))
                Maquina=lst_maquina.EditValue.ToString();
            else
                Maquina="";

            if(!string.IsNullOrEmpty(Convert.ToString(lst_articulo.EditValue)))
                Articulo=lst_articulo.EditValue.ToString();
            else
                Articulo="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(lst_op.EditValue)))
                Op=lst_op.EditValue.ToString();
            else
                Op="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(lst_operador.EditValue)))
                Operador=lst_operador.EditValue.ToString();
            else
                Operador="";

            if(!string.IsNullOrEmpty(Convert.ToString(txt_unidad1.EditValue)))
                Unidad1=txt_unidad1.EditValue.ToString();
            else
                Unidad1="";

            if(!string.IsNullOrEmpty(Convert.ToString(txt_unidad2.EditValue)))
                Unidad2=txt_unidad2.EditValue.ToString();
            else
                Unidad2="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user1.EditValue)))
                User1=txt_user1.EditValue.ToString();
            else
                User1="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user2.EditValue)))
                User2=txt_user2.EditValue.ToString();
            else
                User2="";

            if(!string.IsNullOrEmpty(Convert.ToString(txt_user3.EditValue)))
                User3=txt_user3.EditValue.ToString();
            else
                User3="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user4.EditValue)))
                User4=txt_user4.EditValue.ToString();
            else
                User4="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user5.EditValue)))
                User5=txt_user5.EditValue.ToString();
            else
                User5="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user6.EditValue)))
                User6=txt_user6.EditValue.ToString();
            else
                User6="";

            if(!string.IsNullOrEmpty(Convert.ToString(txt_user7.EditValue)))
                User7=txt_user7.EditValue.ToString();
            else
                User7="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user8.EditValue)))
                User8=txt_user8.EditValue.ToString();
            else
                User8="";
            
            if(!string.IsNullOrEmpty(Convert.ToString(txt_user9.EditValue)))
                 User9 = txt_user9.EditValue.ToString();
            else
                 User9 = "";

            if (!string.IsNullOrEmpty(Convert.ToString(txt_user10.EditValue)))
                USer10 = txt_user10.EditValue.ToString();
            else
                USer10 = "";


            if (!string.IsNullOrEmpty(Convert.ToString(txt_cantidad.EditValue)))
                Cantidad = txt_cantidad.EditValue.ToString();
            else
                Cantidad = "";




            Respuesta = "OK";
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            try { 
            
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            string ControlError = "";
            conexion consulta = new conexion();
            consulta.SetDB(DB);
            consulta.SetUsuario(User_id);
            consulta.SetPassword(Pass);
            consulta.SetServer(Server);

            DataSet TagsNoImpresos = new DataSet();
            string IdMaquinaNoImpresos = "";
            string TagsConcatenados = "";
            string Respuesta = "";
            DataSet ds=new DataSet();


             ds = consulta.consultaSelect("SELECT ISNULL(CREAR,'N') AS CREAR,ISNULL(LEER,'N') AS LEER, ISNULL(MODIFICAR,'N') AS MODIFICAR, isnull(LECTURA_BASCULA,'') as BASCULA, isnull(RESETEAR_LECTURA,'N') AS RESETEAR_LECTURA   FROM " + DB + ".DBO.BRC_USUARIO_DEPARTAMENTO WHERE ID_USUARIO='" + User_id + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "PERMISOS", ref ControlError);

                    if (ds.Tables[0].Rows.Count > 0) {
                        
                        ResetearLectura = ds.Tables[0].Rows[0]["RESETEAR_LECTURA"].ToString();
                        
                    }

            ArrayList CodigosInformacionMaquina = new ArrayList();

            ArrayList CodigosTurnos = new ArrayList();

            ObtenerCodigosConsecutivos LecturaCodigos = new ObtenerCodigosConsecutivos();
            LecturaCodigos.ResetearLectura = ResetearLectura;
            if (CodigoUniversalInfoMaquina.Count > 0 && CodigoUniversalTurno.Count > 0)
            {
                LecturaCodigos.DefaultInformacionMaquina = CodigoUniversalInfoMaquina;
                LecturaCodigos.DefaultTurnos = CodigoUniversalTurno;
            }
            LecturaCodigos.ShowDialog();

            Respuesta = LecturaCodigos.Respueta;
            CodigosInformacionMaquina = LecturaCodigos.CodigosInformacionMaquina;
            CodigosTurnos = LecturaCodigos.CodigosTurnos;

            if (Respuesta == "OK")
            {

                CodigoUniversalInfoMaquina = CodigosInformacionMaquina;
                CodigoUniversalTurno = CodigosTurnos;

            }

            if (Respuesta == "OK")
            {
               
                string IdMaquina = "";
                string Op = "";
                string CodArticulo = "";
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



               

                ds = consulta.consultaSelect("SELECT ID_TIPO_PLANTILLA,ID_MAQUINA,OP,COD_ARTICULO,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10 FROM " + DB + ".DBO.PRD_INFO_MAQUINAS WHERE ID_INFO_MAQUINA=" + CodigosInformacionMaquina[0].ToString(), "INFOMAQUINA", ref ControlError);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    IdTipoPlantilla = ds.Tables[0].Rows[0]["ID_TIPO_PLANTILLA"].ToString();
                    IdMaquina = ds.Tables[0].Rows[0]["ID_MAQUINA"].ToString();
                    Op = ds.Tables[0].Rows[0]["OP"].ToString();
                    CodArticulo = ds.Tables[0].Rows[0]["COD_ARTICULO"].ToString();

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_1"])))
                        User1 = Convert.ToString(ds.Tables[0].Rows[0]["USER_1"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_2"])))
                        User2 = Convert.ToString(ds.Tables[0].Rows[0]["USER_2"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_3"])))
                        User3 = Convert.ToString(ds.Tables[0].Rows[0]["USER_3"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_4"])))
                        User4 = Convert.ToString(ds.Tables[0].Rows[0]["USER_4"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_5"])))
                        User5 = Convert.ToString(ds.Tables[0].Rows[0]["USER_5"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_6"])))
                        User6 = Convert.ToString(ds.Tables[0].Rows[0]["USER_6"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_7"])))
                        User7 = Convert.ToString(ds.Tables[0].Rows[0]["USER_7"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_8"])))
                        User8 = Convert.ToString(ds.Tables[0].Rows[0]["USER_8"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_9"])))
                        User9 = Convert.ToString(ds.Tables[0].Rows[0]["USER_9"]);

                    if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_10"])))
                        User10 = Convert.ToString(ds.Tables[0].Rows[0]["USER_10"]);

                }

                IdMaquinaNoImpresos = consulta.ejecutaEscalar("SELECT ID_MAQUINA FROM " + DB + ".DBO.PRD_INFO_MAQUINAS WHERE ID_INFO_MAQUINA=" + CodigoUniversalInfoMaquina[0].ToString(), ref ControlError);

                if (!string.IsNullOrEmpty(IdMaquinaNoImpresos))
                {

                    TagsNoImpresos = consulta.consultaSelect("SELECT BT.ID_TAGS FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP ON BT.ID_TAGS=BTRP.TAG WHERE BT.ID_MAQUINA='" + IdMaquinaNoImpresos + "' AND BT.FECHA_TRANSACCION='" + Convert.ToDateTime(FechaBuscada).Year.ToString() + "-" + Convert.ToDateTime(FechaBuscada).Month.ToString() + "-" + Convert.ToDateTime(FechaBuscada).Day.ToString() + "' AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.ACTIVO='Y'	AND BTRP.TAG IS NULL", "DATOS", ref ControlError);

                    if (TagsNoImpresos.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < TagsNoImpresos.Tables[0].Rows.Count; i++)
                        {

                            TagsConcatenados = TagsConcatenados + " " + TagsNoImpresos.Tables[0].Rows[i]["ID_TAGS"].ToString();

                        }
                        MessageBox.Show("No se puede generar nuevamente un tag de la maquina " + IdMaquinaNoImpresos + " ya que existen estos tags no impresos, favor imprimirlo para poder generar un nuevo, (si este tags tiene algun error imprimalo 'NO PEGUE EL TAG' y guardelo para presentarselo al secretario y anular dicho tag.). TAG: " + TagsConcatenados, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }


               
                    lst_op.EditValue = Op;
                    lst_articulo.EditValue = CodArticulo;
                    lst_maquina.EditValue = IdMaquina;
                    lst_turno.EditValue = CodigosTurnos[0].ToString();

                    if (User1 != "")
                        txt_user1.EditValue = User1;

                    if (User2 != "")
                        txt_user2.EditValue = User2;

                    if (User3 != "")
                        txt_user3.EditValue = User3;

                    if (User4 != "")
                        txt_user4.EditValue = User4;

                    if (User5 != "")
                        txt_user5.EditValue = User5;

                    if (User6 != "")
                        txt_user6.EditValue = User6;

                    if (User7 != "")
                        txt_user7.EditValue = User7;

                    if (User8 != "")
                        txt_user8.EditValue = User8;

                    if (User9 != "")
                        txt_user9.EditValue = User9;

                    if (User10 != "")
                        txt_user10.EditValue = User10;

                   // lst_fecha_transaccion.EditValue = FechaBuscada;

                  

                    string IdOperadorDefault = "";


                    if (!string.IsNullOrEmpty(IdTipoPlantilla) && !string.IsNullOrEmpty(CodigosTurnos[0].ToString()) && !string.IsNullOrEmpty(IdMaquina))
                        IdOperadorDefault = consulta.ejecutaEscalar("SELECT POM.ID_OPERADOR FROM " + DB + ".DBO.PRD_OPERADOR_MAQUINA AS POM," + DB + ".DBO.PRD_OPERADOR_PUESTO AS POP WHERE POM.ID_MAQUINA='" + IdMaquina + "' AND POM.TURNO='" + CodigosTurnos[0].ToString() + "' AND POM.ID_OPERADOR=POP.ID_OPERADOR AND POP.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND POP.ID_PUESTO IN ( 	SELECT ID_PUESTO FROM " + DB + ".DBO.PRD_PUESTO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND NOMBRE LIKE '%OPER%' ) ", ref ControlError);
                    if (!string.IsNullOrEmpty(IdOperadorDefault))
                        lst_operador.EditValue = IdOperadorDefault;

                
                

            }
        }

        private void lst_articulo_EditValueChanged(object sender, EventArgs e)
        {
            try {
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


                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();

                if (!string.IsNullOrEmpty(Convert.ToString(lst_articulo.EditValue)))
                {
                    ds = consulta.consultaSelect("SELECT USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10 FROM " + DB + ".DBO.BRC_PART WHERE ID='" + lst_articulo.EditValue.ToString() + "'", "DATOS", ref ControlError);

                    if (ControlError == "Completado")
                    {

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_1"])))
                            User1 = Convert.ToString(ds.Tables[0].Rows[0]["USER_1"]);
                        else
                            User1 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_2"])))
                            User2 = Convert.ToString(ds.Tables[0].Rows[0]["USER_2"]);
                        else
                            User2 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_3"])))
                            User3 = Convert.ToString(ds.Tables[0].Rows[0]["USER_3"]);
                        else
                            User3 = "";


                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_4"])))
                            User4 = Convert.ToString(ds.Tables[0].Rows[0]["USER_4"]);
                        else
                            User4 = "";


                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_5"])))
                            User5 = Convert.ToString(ds.Tables[0].Rows[0]["USER_5"]);
                        else
                            User5 = "";


                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_6"])))
                            User6 = Convert.ToString(ds.Tables[0].Rows[0]["USER_6"]);
                        else
                            User6 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_7"])))
                            User7 = Convert.ToString(ds.Tables[0].Rows[0]["USER_7"]);
                        else
                            User7 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_8"])))
                            User8 = Convert.ToString(ds.Tables[0].Rows[0]["USER_8"]);
                        else
                            User8 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_9"])))
                            User9 = Convert.ToString(ds.Tables[0].Rows[0]["USER_9"]);
                        else
                            User9 = "";

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["USER_10"])))
                            User10 = Convert.ToString(ds.Tables[0].Rows[0]["USER_10"]);
                        else
                            User10 = "";

                        if (string.IsNullOrEmpty(Convert.ToString( txt_user1.EditValue))
)                            txt_user1.EditValue = User1;

                        txt_user2.EditValue = User2;
                        txt_user3.EditValue = User3;
                        txt_user4.EditValue = User4;
                        txt_user5.EditValue = User5;
                        txt_user6.EditValue = User6;
                        txt_user7.EditValue = User7;
                        txt_user8.EditValue = User8;
                        txt_user9.EditValue = User9;
                        txt_user10.EditValue = User10;

                        if (!string.IsNullOrEmpty(User10))
                            txt_unidad2.EditValue = User10;

                       

                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
