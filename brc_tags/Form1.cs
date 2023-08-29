using brc_tags.Librerias;
using DevExpress.Data.Filtering;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace brc_tags
{
    public partial class Form1 : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string Origen;
        public DateTime FechaActual;
        public int Hora;
        public int Minuto;
        public string FechaString;
        private string[] parametors;
        public bool DetalleExpandido;
        public DataSet dtTiempos;
        public string MetrosAConvertir;
        public bool EstaEditando;
        public string EsDevolucion;
        public ArrayList CodigoUniversalInfoMaquina;
        public ArrayList CodigoUniversalTurno;
        public string ResetearLectura;
        public string ModificacionPublica;
        bool AccesoATodo;
        string MarcaBascula = "";
        string GlobalIdCalculo = "";
        string GlobalIdTipoPlantilla = "";
        DateTime Globalfecha;
        public static Form1 f1;
        public string EsEntarimadoACompletar;
        public bool EstadEditandoAuditoria;
        public Form1(string[] args)
        {
            try
            {

                string ErrorSql = "";
                InitializeComponent();
                parametors = args;
                //---**Asignacion de parametros de conexion**---
                //Toma los parametros que se envian a la aplicacion y los divide segun los primeros 2 caracteres del parametro
                //-S para el parametro de servidor
                //-D para el parametro de la base de datos
                //-U para el parametro de usuario
                //-P para el parametro de password
                for (int i = 0; i < parametors.Length; i++)
                {
                    if (parametors[i].ToString().Contains("-S") == true) Server = parametors[i].ToString().Substring(2, parametors[i].ToString().Length - 2);
                    if (parametors[i].ToString().Contains("-U") == true) User_id = parametors[i].ToString().Substring(2, parametors[i].ToString().Length - 2);
                    if (parametors[i].ToString().Contains("-P") == true) Pass = parametors[i].ToString().Substring(2, parametors[i].ToString().Length - 2);
                    if (parametors[i].ToString().Contains("-O") == true) Origen = parametors[i].ToString().Substring(2, parametors[i].ToString().Length - 2);
                }


                //Se crea libreria conexion para obtener los parametros de configuracion del archivo ini
                conexion nuevaconexion = new conexion();
                DB = nuevaconexion.ObtenerConfiguracionIni(System.IO.Directory.GetCurrentDirectory().ToString() + "\\" + "configuracion.ini", "BASESDATOS", "POLY");
                SMVISUAL = nuevaconexion.ObtenerConfiguracionIni(System.IO.Directory.GetCurrentDirectory().ToString() + "\\" + "configuracion.ini", "BASESDATOS", "VISUAL");

                nuevaconexion.SetDB(DB);
                nuevaconexion.SetUsuario(User_id);
                nuevaconexion.SetServer(Server);
                nuevaconexion.SetPassword(Pass);


                FechaString = nuevaconexion.ejecutaEscalar("select CONVERT(nvarchar(30), GETDATE(), 120) ", ref ErrorSql);
                //FechaString = "2018-04-06 06:01:43.587";
                //  MessageBox.Show(FechaString);
                FechaActual = Convert.ToDateTime(FechaString);
                Hora = FechaActual.Hour;
                Minuto = FechaActual.Minute;
                DetalleExpandido = false;
                EstaEditando = false;
                AccesoATodo = false;
                Form1.f1 = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public string BuscarTag(string Server,
                                string DB,
                                string UserId,
                                string Pass,
                                string IdTipoPlantilla,
                                string IdCalculo,
                                string Fecha,
                                string Tag
                               )
        {
            string Respuesta = "";

            try
            {
            //    DataSet dsDatosTag = new DataSet();

            //    string SumaTags = "";

            //    string ControlError = "";
            //    string TagFechaTransaccion = "";
            //    string TagTurno = "";
            //    string TagTipoPlantilla = "";
            //    string TagOp = "";
            //    string TagCodigoArticulo = "";
            //    string TagQty = "";
            //    string TagUnidad1 = "";
            //    string TagDescripcionArticulo = "";
            //    string IdReciboPt = "";
            //    string ExisteTag = "";
            //    string ExisteTagNoConfirmado = "";
            //    string EsDevolucion = "";
            //    conexion NuevaConexion = new conexion();
            //    NuevaConexion.SetServer(Server);
            //    NuevaConexion.SetDB(DB);
            //    NuevaConexion.SetUsuario(UserId);
            //    NuevaConexion.SetPassword(Pass);

                //    dsDatosTag = NuevaConexion.consultaSelect("SELECT CAST(BT.FECHA_TRANSACCION AS DATE) AS FECHA_TRANSACCION,BT.TURNO,BT.ID_TIPO_PLANTILLA,BT.OP,BT.COD_ARTICULO,P.DESCRIPTION,BT.UNIDAD_2 AS QTY,BT.UNIDAD_1 FROM " + DB + ".DBO.BRC_TAGS  AS BT WITH (NOLOCK), "+SMVISUAL+".DBO.PART	AS P WITH (NOLOCK) WHERE BT.COD_ARTICULO=P.ID AND ID_TAGS='" + Tag + "' AND ACTIVO='Y' ", "DATOS_TAG", ref ControlError);
            //    if (ControlError == "Completado")
            //    {
            //        if (dsDatosTag.Tables[0].Rows.Count > 0)
            //        {

            //            ExisteTag = NuevaConexion.ejecutaEscalar("SELECT COUNT(ID_TAGS_RECIBO) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + Tag + "'", ref ControlError);
            //            if (string.IsNullOrEmpty(ExisteTag))
            //                ExisteTag = "0";




            //            if (Convert.ToInt32(ExisteTag) > 0)
            //            {
            //                NuevaConexion.insertar("DELETE " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + Tag + "'", ref ControlError);
            //            }


            //            TagFechaTransaccion = dsDatosTag.Tables[0].Rows[0]["FECHA_TRANSACCION"].ToString();
            //            TagTurno = dsDatosTag.Tables[0].Rows[0]["TURNO"].ToString();
            //            TagTipoPlantilla = dsDatosTag.Tables[0].Rows[0]["ID_TIPO_PLANTILLA"].ToString();
            //            TagOp = dsDatosTag.Tables[0].Rows[0]["OP"].ToString();
            //            TagCodigoArticulo = dsDatosTag.Tables[0].Rows[0]["COD_ARTICULO"].ToString();
            //            TagQty = dsDatosTag.Tables[0].Rows[0]["QTY"].ToString();
            //            TagUnidad1 = dsDatosTag.Tables[0].Rows[0]["UNIDAD_1"].ToString();
            //            TagDescripcionArticulo = dsDatosTag.Tables[0].Rows[0]["DESCRIPTION"].ToString();

                  

            //            if (IdTipoPlantilla == TagTipoPlantilla && Convert.ToDateTime(Fecha).ToShortDateString() == Convert.ToDateTime(TagFechaTransaccion).ToShortDateString())
            //            {

            //                EsDevolucion = NuevaConexion.ejecutaEscalar("SELECT ES_DEVOLUCION FROM "+DB+".DBO.PRD_TIPO_PLANTILLA WHERE ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"'",ref ControlError);

            //                if (string.IsNullOrEmpty(EsDevolucion))
            //                    EsDevolucion = "N";



            //                if (TagTurno == "A" && EsDevolucion == "N")
            //                    IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE OP='" + TagOp + "' AND CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);

            //                if (TagTurno == "B" && EsDevolucion == "N")
            //                    IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE OP='" + TagOp + "' AND CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND  FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);

            //                if (TagTurno == "A" && EsDevolucion == "Y")
            //                    IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE  CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);

            //                if (TagTurno == "B" && EsDevolucion == "Y")
            //                    IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE  CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND  FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);



            //                if (!string.IsNullOrEmpty(IdReciboPt))
            //                {

            //                    NuevaConexion.insertar("INSERT INTO " + DB + ".DBO.BRC_TAGS_RECIBO_PT(ID_RECIBO_PT,TURNO,QTY,TAG) VALUES(" + IdReciboPt + ",'" + TagTurno + "'," + TagQty + ",'" + Tag + "')", ref ControlError);
            //                    if (ControlError == "Completado")
            //                    {
            //                        SumaTags = NuevaConexion.ejecutaEscalar("SELECT ISNULL(SUM(ISNULL(QTY,0)),0) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE ID_RECIBO_PT=" + IdReciboPt + " AND TURNO='" + TagTurno + "'", ref ControlError);
            //                        if (ControlError == "Completado")
            //                        {
            //                            if (string.IsNullOrEmpty(SumaTags)) SumaTags = "0";

            //                            if (TagTurno == "A")
            //                                NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_RECIBIDA=" + SumaTags + ",DIF=QTY-(" + SumaTags + ") WHERE ID_RECIBO_PT=" + IdReciboPt, ref ControlError);

            //                            if (TagTurno == "B")
            //                                NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_RECIBIDA_TB=" + SumaTags + ",DIF_TB=QTY_TB-(" + SumaTags + ") WHERE ID_RECIBO_PT=" + IdReciboPt, ref ControlError);

            //                            if (ControlError == "Completado")
            //                            {
            //                                Respuesta = "Completado";
            //                            }
            //                            else
            //                            {
            //                                Respuesta = "Ocurrio un error favor contacar su administrador:" + ControlError;
            //                            }

            //                        }
            //                        else
            //                        {
            //                            Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
            //                        }

            //                    }
            //                    else
            //                    {
            //                        Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
            //                    }
            //                }
            //                else
            //                {
            //                    Respuesta = "No se encontro ningun registro en el recibo de prducto terminado que coincidan con los datos del tag, favor contactar al secretario." + "SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE OP='" + TagOp + "' AND CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND CONVERT(VARCHAR(10), FECHA, 103)  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'";
            //                }

            //            }
            //            else
            //            {
            //                if (IdTipoPlantilla != TagTipoPlantilla) Respuesta = "El departamento que esta tratango de ingresar el tag no corresponde al departamento que tiene asignado el tag, contacte al secretario para corregir el dato.";
            //                if (Convert.ToDateTime(Fecha).ToShortDateString() != Convert.ToDateTime(TagFechaTransaccion).ToShortDateString()) Respuesta = "La fecha que esta tratando de ingresar el tag no corresponde a la fecha del tag, favor contactar al secretario para corregirlo.";


            //            }

            //        }
            //        else
            //        {
            //            Respuesta = "Favor verificar con el secretario el tag, posiblemente este anulado.";
            //        }
            //    }
            //    else
            //    {
            //        Respuesta = "Ocurrio un error: " + ControlError;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Respuesta = "Ocurrio un error favor contactar a su administrador: " + ex.Message.ToString();

            //}
                DataSet dsDatosTag = new DataSet();

                string SumaTags = "";

                string ControlError = "";
                string TagFechaTransaccion = "";
                string TagTurno = "";
                string TagTipoPlantilla = "";
                string TagOp = "";
                string TagCodigoArticulo = "";
                string TagQty = "";
                string TagUnidad1 = "";
                string TagDescripcionArticulo = "";
                string IdReciboPt = "";
                string ExisteTag = "";
                string ExisteTagNoConfirmado = "";
                string EsDevolucion = "";

                // PARA PLANTILLA CONFSAC-04 Y CONFJMB-05
                string Completado = "";
                int Estado = 0;
                string IdRecibo = "";

                conexion NuevaConexion = new conexion();
                NuevaConexion.SetServer(Server);
                NuevaConexion.SetDB(DB);
                NuevaConexion.SetUsuario(UserId);
                NuevaConexion.SetPassword(Pass);

                dsDatosTag = NuevaConexion.consultaSelect("SELECT CAST(BT.FECHA_TRANSACCION AS DATE) AS FECHA_TRANSACCION,BT.TURNO,BT.ID_TIPO_PLANTILLA,BT.OP,BT.COD_ARTICULO,P.DESCRIPTION,BT.UNIDAD_2 AS QTY,BT.UNIDAD_1 FROM " + DB + ".DBO.BRC_TAGS  AS BT WITH (NOLOCK), " + DB + ".DBO.BRC_PART	AS P WITH (NOLOCK) WHERE BT.COD_ARTICULO COLLATE DATABASE_DEFAULT  = P.ID COLLATE DATABASE_DEFAULT  AND ID_TAGS='" + Tag + "' AND BT.ACTIVO='Y' ", "DATOS_TAG", ref ControlError);
                if (ControlError == "Completado")
                {
                    if (dsDatosTag.Tables[0].Rows.Count > 0)
                    {

                        ExisteTag = NuevaConexion.ejecutaEscalar("SELECT COUNT(ID_TAGS_RECIBO) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + Tag + "'", ref ControlError);
                        if (string.IsNullOrEmpty(ExisteTag))
                            ExisteTag = "0";




                        if (Convert.ToInt32(ExisteTag) > 0)
                        {
                            NuevaConexion.insertar("DELETE " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + Tag + "'", ref ControlError);
                        }


                        TagFechaTransaccion = dsDatosTag.Tables[0].Rows[0]["FECHA_TRANSACCION"].ToString();
                        TagTurno = dsDatosTag.Tables[0].Rows[0]["TURNO"].ToString();
                        TagTipoPlantilla = dsDatosTag.Tables[0].Rows[0]["ID_TIPO_PLANTILLA"].ToString();
                        TagOp = dsDatosTag.Tables[0].Rows[0]["OP"].ToString();
                        TagCodigoArticulo = dsDatosTag.Tables[0].Rows[0]["COD_ARTICULO"].ToString();
                        TagQty = dsDatosTag.Tables[0].Rows[0]["QTY"].ToString();
                        TagUnidad1 = dsDatosTag.Tables[0].Rows[0]["UNIDAD_1"].ToString();
                        TagDescripcionArticulo = dsDatosTag.Tables[0].Rows[0]["DESCRIPTION"].ToString();



                        if (IdTipoPlantilla == TagTipoPlantilla && Convert.ToDateTime(Fecha).ToShortDateString() == Convert.ToDateTime(TagFechaTransaccion).ToShortDateString())
                        {

                            EsDevolucion = NuevaConexion.ejecutaEscalar("SELECT ES_DEVOLUCION FROM " + DB + ".DBO.PRD_TIPO_PLANTILLA WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", ref ControlError);

                            if (string.IsNullOrEmpty(EsDevolucion))
                                EsDevolucion = "N";



                            if (TagTurno == "A" && EsDevolucion == "N")
                                IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE OP='" + TagOp + "' AND CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);

                            if (TagTurno == "B" && EsDevolucion == "N")
                                IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE OP='" + TagOp + "' AND CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND  FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);

                            if (TagTurno == "A" && EsDevolucion == "Y")
                                IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE  CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);

                            if (TagTurno == "B" && EsDevolucion == "Y")
                                IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE  CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND  FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'", ref ControlError);



                            if (!string.IsNullOrEmpty(IdReciboPt))
                            {
                                // QUERY DE WICHO
                                if (lst_tipo_plantilla.EditValue.ToString() != "CONFSAC-04" 
                                    && lst_tipo_plantilla.EditValue.ToString() != "CONFJMB-05" 
                                    && lst_tipo_plantilla.EditValue.ToString() != "CONFMACEN"
                                    && lst_tipo_plantilla.EditValue.ToString() != "TELMACEN"
                                    
                                    )
                                {


                                    NuevaConexion.insertar("INSERT INTO " + DB + ".DBO.BRC_TAGS_RECIBO_PT(ID_RECIBO_PT,TURNO,QTY,TAG,REVISADO) VALUES(" + IdReciboPt + ",'" + TagTurno + "'," + TagQty + ",'" + Tag + "','Y')", ref ControlError);
                                    if (ControlError == "Completado")
                                    {
                                        SumaTags = NuevaConexion.ejecutaEscalar("SELECT ISNULL(SUM(ISNULL(QTY,0)),0) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE ID_RECIBO_PT=" + IdReciboPt + " AND TURNO='" + TagTurno + "'", ref ControlError);
                                        if (ControlError == "Completado")
                                        {
                                            if (string.IsNullOrEmpty(SumaTags)) SumaTags = "0";

                                            if (TagTurno == "A")
                                                NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_RECIBIDA=" + SumaTags + ",QTY= " + SumaTags + " WHERE ID_RECIBO_PT=" + IdReciboPt, ref ControlError);

                                            if (TagTurno == "B")
                                                NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_RECIBIDA_TB=" + SumaTags + ",QTY_TB = " + SumaTags + " WHERE ID_RECIBO_PT=" + IdReciboPt, ref ControlError);

                                            if (ControlError == "Completado")
                                            {
                                                Respuesta = "Completado";
                                            }
                                            else
                                            {
                                                Respuesta = "Ocurrio un error favor contacar su administrador:" + ControlError;
                                            }

                                        }
                                        else
                                        {
                                            Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                        }

                                    }
                                    else
                                    {
                                        Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                    }
                                }


                                // INGRESAR ID_RECIBO_PT A CONFSAC-04 Y CONFJMB-05
                                if (lst_tipo_plantilla.EditValue.ToString() == "CONFSAC-04" 
                                    || lst_tipo_plantilla.EditValue.ToString() == "CONFJMB-05"
                                    || lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN"
                                    || lst_tipo_plantilla.EditValue.ToString() == "TELMACEN"


                                    )
                                {

                                    Completado = NuevaConexion.ejecutaEscalar("select COUNT(ESTADO_RECIBO) from " + DB + ".DBO.PRD_RECIBO_PT WHERE OP = '" + TagOp + "' AND CODIGO_ARTICULO = '" + TagCodigoArticulo
                                                                        + "'AND FECHA ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString()
                                                                         + "'AND ESTADO_RECIBO = 'N' AND ESTADO IS NULL AND ESTADO_TB IS NULL", ref ControlError);

                                    Estado = Convert.ToInt32(Completado);

                                    if (Estado == 1)
                                    {
                                        IdRecibo = NuevaConexion.ejecutaEscalar("select ID_RECIBO_PT from " + DB + ".DBO.PRD_RECIBO_PT WHERE OP = '" + TagOp + "' AND CODIGO_ARTICULO = '" + TagCodigoArticulo
                                                                        + "'AND FECHA ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString()
                                                                         + "'AND ESTADO_RECIBO = 'N' AND ESTADO IS NULL AND ESTADO_TB IS NULL", ref ControlError);


                                        NuevaConexion.insertar("INSERT INTO " + DB + ".DBO.BRC_TAGS_RECIBO_PT(ID_RECIBO_PT,TURNO,QTY,TAG,REVISADO) VALUES(" + IdReciboPt + ",'" + TagTurno + "'," + TagQty + ",'" + Tag + "','Y')", ref ControlError);
                                        //  NuevaConexion.insertar("UPDATE DBPOLY.DBO.BRC_TAGS SET ID_RECIBO_PT =  " + IdRecibo + " WHERE ID_TAGS = '" + Tag + "'", ref ControlError);

                                        if (ControlError == "Completado")
                                        {
                                            SumaTags = NuevaConexion.ejecutaEscalar("SELECT ISNULL(SUM(ISNULL(QTY,0)),0) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE ID_RECIBO_PT=" + /*IdReciboPt*/ IdRecibo + " AND TURNO='" + TagTurno + "'", ref ControlError);
                                            if (ControlError == "Completado")
                                            {
                                                if (string.IsNullOrEmpty(SumaTags)) SumaTags = "0";

                                                if (TagTurno == "A")
                                                    NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET /* QTY_RECIBIDA*/ QTY =" + SumaTags + ",QTY_RECIBIDA= /* QTY- */ (" + SumaTags + ") WHERE ID_RECIBO_PT=" + /*IdReciboPt*/ IdRecibo, ref ControlError);

                                                if (TagTurno == "B")
                                                    NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET /* QTY_RECIBIDA_TB */ =" + SumaTags + ",QTY_RECIBIDA_TB= /* QTY_TB- */(" + SumaTags + ") WHERE ID_RECIBO_PT=" + /*IdReciboPt*/ IdRecibo, ref ControlError);

                                                if (ControlError == "Completado")
                                                {
                                                    Respuesta = "Completado";
                                                }
                                                else
                                                {
                                                    Respuesta = "Ocurrio un error favor contacar su administrador:" + ControlError;
                                                }

                                            }
                                            else
                                            {
                                                Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                            }

                                        }
                                        else
                                        {
                                            Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                        }
                                    }


                                    Completado = NuevaConexion.ejecutaEscalar("select COUNT(ESTADO_RECIBO) from " + DB + ".DBO.PRD_RECIBO_PT WHERE OP = '" + TagOp + "' AND CODIGO_ARTICULO = '" + TagCodigoArticulo
                                                                      + "'AND FECHA ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString()
                                                                       + "'AND ESTADO_RECIBO = 'N' AND ESTADO IS NULL AND ESTADO_TB IS NULL", ref ControlError);

                                    Estado = Convert.ToInt32(Completado);

                                    if (Estado != 1)
                                    {
                                        IdRecibo = NuevaConexion.ejecutaEscalar("select ID_RECIBO_PT from " + DB + ".DBO.PRD_RECIBO_PT WHERE OP = '" + TagOp + "' AND CODIGO_ARTICULO = '" + TagCodigoArticulo
                                                                        + "'AND FECHA ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString()
                                                                         + "' AND (ESTADO is not null  or ESTADO_TB IS not NULL)", ref ControlError);
                                       //        + "' AND ESTADO is not null  AND ESTADO_TB IS NULL", ref ControlError);


                                        NuevaConexion.insertar("INSERT INTO " + DB + ".DBO.BRC_TAGS_RECIBO_PT(ID_RECIBO_PT,TURNO,QTY,TAG,REVISADO) VALUES(" + IdReciboPt + ",'" + TagTurno + "'," + TagQty + ",'" + Tag + "','Y')", ref ControlError);
                                        //  NuevaConexion.insertar("UPDATE DBPOLY.DBO.BRC_TAGS SET ID_RECIBO_PT =  " + IdRecibo + " WHERE ID_TAGS = '" + Tag + "'", ref ControlError);

                                        if (ControlError == "Completado")
                                        {
                                            //SumaTags = NuevaConexion.ejecutaEscalar("SELECT ISNULL(SUM(ISNULL(QTY,0)),0) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE ID_RECIBO_PT=" + /*IdReciboPt*/ IdRecibo + " AND TURNO='" + TagTurno + "'", ref ControlError);
                                            if (ControlError == "Completado")
                                            {
                                                if (string.IsNullOrEmpty(SumaTags)) SumaTags = "0";

                                                // if (TagTurno == "A")
                                                //NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET /* QTY_RECIBIDA*/ QTY =" + SumaTags + ",DIF= /* QTY- */ (" + SumaTags + ") WHERE ID_RECIBO_PT=" + /*IdReciboPt*/ IdRecibo, ref ControlError);

                                                //   if (TagTurno == "B")
                                                // NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET /* QTY_RECIBIDA_TB */ =" + SumaTags + ",DIF_TB= /* QTY_TB- */(" + SumaTags + ") WHERE ID_RECIBO_PT=" + /*IdReciboPt*/ IdRecibo, ref ControlError);

                                                if (ControlError == "Completado")
                                                {
                                                    Respuesta = "Completado";
                                                }
                                                else
                                                {
                                                    Respuesta = "Ocurrio un error favor contacar su administrador:" + ControlError;
                                                }

                                            }
                                            else
                                            {
                                                Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                            }

                                        }
                                        else
                                        {
                                            Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                        }
                                    }


                                }



                            }
                            else
                            {
                                Respuesta = "No se encontro ningun registro en el recibo de prducto terminado que coincidan con los datos del tag, favor contactar al secretario." + "SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE OP='" + TagOp + "' AND CODIGO_ARTICULO='" + TagCodigoArticulo + "' AND CONVERT(VARCHAR(10), FECHA, 103)  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + TagTipoPlantilla + "'";
                            }

                        }
                        else
                        {
                            if (IdTipoPlantilla != TagTipoPlantilla) Respuesta = "El departamento que esta tratango de ingresar el tag no corresponde al departamento que tiene asignado el tag, contacte al secretario para corregir el dato.";
                            if (Convert.ToDateTime(Fecha).ToShortDateString() != Convert.ToDateTime(TagFechaTransaccion).ToShortDateString()) Respuesta = "La fecha que esta tratando de ingresar el tag no corresponde a la fecha del tag, favor contactar al secretario para corregirlo.";


                        }

                    }
                    else
                    {
                        Respuesta = "Favor verificar con el secretario el tag, posiblemente este anulado.";
                    }
                }
                else
                {
                    Respuesta = "Ocurrio un error: " + ControlError;
                }


            }
            catch (Exception ex)
            {
                Respuesta = "Ocurrio un error favor contactar a su administrador: " + ex.Message.ToString();

            }



            return Respuesta;
        }
        public int BuscaOrden(DataSet grid, string Orden, string Articulo, string Turno)
        {
            int Estado = 0;
            string OrdenTemporal = "";
            string EstadoOrdenTemporal = "";

            if (string.IsNullOrEmpty(Orden))
                Orden = Articulo;

            for (int i = 0; i < grid.Tables[0].Rows.Count; i++)
            {

                if (Turno == "A")
                {

                    OrdenTemporal = grid.Tables[0].Rows[i]["OP"].ToString();
                    
                    if(string.IsNullOrEmpty(OrdenTemporal))
                        OrdenTemporal = grid.Tables[0].Rows[i]["CODIGO_ARTICULO"].ToString();

                    EstadoOrdenTemporal = grid.Tables[0].Rows[i]["ESTADO"].ToString();

                }
                if (Turno == "B")
                {

                    OrdenTemporal = grid.Tables[0].Rows[i]["OP"].ToString();

                    if (string.IsNullOrEmpty(OrdenTemporal))
                        OrdenTemporal = grid.Tables[0].Rows[i]["CODIGO_ARTICULO"].ToString();

                    EstadoOrdenTemporal = grid.Tables[0].Rows[i]["ESTADO_TB"].ToString();

                }


                if (Orden == OrdenTemporal && EstadoOrdenTemporal == "")
                {
                    Estado = 1;
                    i = grid.Tables[0].Rows.Count;
                }
                if (Orden == OrdenTemporal && EstadoOrdenTemporal != "")
                {
                    Estado = 2;
                    i = grid.Tables[0].Rows.Count;
                }



            }


            return Estado;
        }

        public void ListaFechasPorRecibirPT(string Server, string DB, string UserId, string Pass, string IdTipoPlantilla, ref string Respuesta)
        {
            DataSet dsTable = new DataSet();
            try
            {
                string ControlError = "";
                string Fecha = "";
                string Query = "";
                conexion NuevaConexion = new conexion();
                NuevaConexion.SetServer(Server);
                NuevaConexion.SetDB(DB);
                NuevaConexion.SetUsuario(UserId);
                NuevaConexion.SetPassword(Pass);
                string FechaTemporal = "";
                string CodigoTemproal = "";
                string Departamento = "";
                string Correlativo = "";

                Query = "SELECT FECHAS.Codigo as Codigo,FECHAS.Fecha FROM ( ";
                Query = Query + " SELECT (SELECT PCE.ID_CALCULO FROM "+DB+".DBO.PRD_CALCULO_ENCABEZADO AS PCE ";
                Query = Query + " WHERE PCE.FECHA=TEMP.FECHA_TRANSACCION AND PCE.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "') AS Codigo,";
                Query = Query + " TEMP.FECHA_TRANSACCION AS Fecha FROM ( ";
                Query = Query + " SELECT FECHA_TRANSACCION ";
                Query = Query + " FROM " + DB + ".DBO.BRC_TAGS ";
                Query = Query + " WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' ";
                Query = Query + " GROUP BY FECHA_TRANSACCION ";
                Query = Query + " ) AS TEMP ) AS FECHAS WHERE FECHAS.Fecha NOT IN (";
                Query = Query + " SELECT FECHA FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ( ISNULL(ESTADO,'')<>'' OR ISNULL(ESTADO_TB,'')<>''))";

                dsTable = NuevaConexion.consultaSelect(Query, "FECHAS", ref ControlError);
                Respuesta = "Completado";
                if (ControlError == "Completado")
                {


                    for (int i = 0; i < dsTable.Tables[0].Rows.Count; i++)
                    {
                        CodigoTemproal = Convert.ToString(dsTable.Tables[0].Rows[i]["Codigo"]);
                        FechaTemporal = Convert.ToString(dsTable.Tables[0].Rows[i]["Fecha"]);

                        if (string.IsNullOrEmpty(CodigoTemproal))
                            CodigoTemproal = "";

                        if (CodigoTemproal == "0")
                            CodigoTemproal = "";


                        if (string.IsNullOrEmpty(CodigoTemproal))
                        {


                            Departamento = NuevaConexion.ejecutaEscalar("SELECT ID_DEPARTAMENTO FROM " + DB + ".DBO.PRD_TIPO_PLANTILLA WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", ref ControlError);
                            if (ControlError == "Completado")
                            {

                                Correlativo = NuevaConexion.ejecutaEscalar("SELECT isnull(MAX(isnull(CORRELATIVO_REPORTE,0))+1,1) FROM " + DB + ".DBO.PRD_CALCULO_ENCABEZADO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", ref ControlError);
                                if (ControlError == "Completado")
                                {
                                    NuevaConexion.insertar("INSERT INTO " + DB + ".DBO.PRD_CALCULO_ENCABEZADO(FECHA,ID_USUARIO,ID_TIPO_PLANTILLA,ID_DEPARTAMENTO,HORA_INICIOTA,HORA_FIN_TA,HORA_INICIOTB,HORA_FIN_TB,CAMBIO_HORA,CORRELATIVO_REPORTE) VALUES('" + Convert.ToDateTime(FechaTemporal).Year.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Month.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Day.ToString() + "','" + UserId + "','" + IdTipoPlantilla + "','" + Departamento + "','" + Convert.ToDateTime(FechaTemporal).Year.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Month.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Day.ToString() + " 06:00:00.000','" + Convert.ToDateTime(FechaTemporal).Year.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Month.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Day.ToString() + " 18:00:00.000','" + Convert.ToDateTime(FechaTemporal).Year.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Month.ToString() + "-" + Convert.ToDateTime(FechaTemporal).Day.ToString() + " 18:00:00.000','" + Convert.ToDateTime(FechaTemporal).AddDays(1).Year.ToString() + "-" + Convert.ToDateTime(FechaTemporal).AddDays(1).Month.ToString() + "-" + Convert.ToDateTime(FechaTemporal).AddDays(1).Day.ToString() + " 06:00:00.000','Y'," + Correlativo + ")", ref ControlError);

                                    if (ControlError != "Completado")
                                    {
                                        Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                        i = dsTable.Tables[0].Rows.Count;
                                    }
                                }
                                else
                                {
                                    Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                    i = dsTable.Tables[0].Rows.Count;
                                }
                            }
                            else
                            {
                                Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                                i = dsTable.Tables[0].Rows.Count;
                            }
                        }
                    }
                }
               

            }
            catch (Exception ex)
            {

                Respuesta = "Ocurrio un Error favor contactarse con su administrador:" + ex.Message.ToString();
               
            }

        }

        public void ObtenerProductosARecibir(string Server, string DB, string UserId, string Pass, string IdTipoPlantilla, string IdCalculo, string Fecha, ref string Respuesta)
        {
            DataSet dsTable = new DataSet();
            try
            {
                //DataSet ds = new DataSet();
                //DataSet dsReciboPtGridView = new DataSet();
                //string ControlError = "";

                //string Query = "";
                //conexion NuevaConexion = new conexion();
                //NuevaConexion.SetServer(Server);
                //NuevaConexion.SetDB(DB);
                //NuevaConexion.SetUsuario(UserId);
                //NuevaConexion.SetPassword(Pass);
                //string QuerysAcumulados = "";
                //DataSet dsUsersDefine = NuevaConexion.consultaSelect("SELECT USER_1,USER_2,USER_3,USER_4,USER_5 FROM " + DB + ".DBO.PRD_USUARIO WHERE ID_USUARIO='" + UserId + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "USERS", ref ControlError);


                //string FiltroProducto = "";

                //if (dsUsersDefine.Tables[0].Rows.Count > 0)
                //{
                //    if (!string.IsNullOrEmpty(Convert.ToString(dsUsersDefine.Tables[0].Rows[0]["USER_1"])))
                //    {
                //        FiltroProducto = dsUsersDefine.Tables[0].Rows[0]["USER_1"].ToString();
                //    }
                //}

               


                //Query = "SELECT TEMP.OP, TEMP.COD_ARTICULO AS CODIGO_ARTICULO,";
                //Query = Query + " isnull((SELECT SUM(T1.UNIDAD_2) ";
                //Query = Query + "  FROM " + DB + ".DBO.BRC_TAGS AS T1";
                //Query = Query + "  WHERE ISNULL(T1.OP,T1.COD_ARTICULO)=ISNULL(TEMP.OP,TEMP.COD_ARTICULO) AND T1.COD_ARTICULO=TEMP.COD_ARTICULO  ";
                //Query = Query + "  AND T1.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' ";
                //Query = Query + "  AND  T1.FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND T1.TURNO='A' AND T1.ACTIVO='Y' ),0)  AS QTY_TA,";
                //Query = Query + " isnull((SELECT SUM(T1.UNIDAD_2) ";
                //Query = Query + " FROM " + DB + ".DBO.BRC_TAGS AS T1 ";
                //Query = Query + " WHERE ISNULL(T1.OP,T1.COD_ARTICULO)=ISNULL(TEMP.OP,TEMP.COD_ARTICULO) AND T1.COD_ARTICULO=TEMP.COD_ARTICULO   ";
                //Query = Query + " AND T1.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'";
                //Query = Query + " AND  T1.FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND T1.TURNO='B' AND T1.ACTIVO='Y' ),0)  AS QTY_TB";
                //Query = Query + " FROM ( ";
                //Query = Query + " SELECT OP,COD_ARTICULO FROM " + DB + ".DBO.BRC_TAGS ";
                //Query = Query + " WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ACTIVO='Y'";
                //Query = Query + " GROUP BY  OP,COD_ARTICULO ";
                //Query = Query + " ) AS TEMP";

                //if (!string.IsNullOrEmpty(FiltroProducto))
                //    Query = Query + " WHERE TEMP.COD_ARTICULO LIKE '%" + FiltroProducto + "%'";

                //ds = NuevaConexion.consultaSelect(Query, "TIPOPLANTILLA", ref ControlError);
                //QuerysAcumulados = QuerysAcumulados + Query;
                //if (ControlError == "Completado")
                //{
                //    if (IdTipoPlantilla != "CONFSAC-01")
                //        dsReciboPtGridView = NuevaConexion.consultaSelect("SELECT ID_RECIBO_PT,OP,CODIGO_ARTICULO,QTY,ESTADO_RECIBO,ESTADO,ID_CALCULO,WAREHOUSE_ID,LOCATION_ID,QTY_RECIBIDA, DIF,FECHA_CREACION,ID_USUARIO,PENDING_ID,FECHA,ID_TIPO_PLANTILLA,QTY_TB,QTY_RECIBIDA_TB,DIF_TB, PENDING_ID_TB,ESTADO_TB FROM PRD_RECIBO_PT WHERE   FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND CODIGO_ARTICULO LIKE '%" + FiltroProducto + "%'", "RECIBO_PT", ref ControlError);

                //    if (IdTipoPlantilla == "CONFSAC-01")
                //        dsReciboPtGridView = NuevaConexion.consultaSelect("SELECT ID_RECIBO_PT,OP,CODIGO_ARTICULO,QTY,ESTADO_RECIBO,ESTADO,ID_CALCULO,WAREHOUSE_ID,LOCATION_ID,QTY_RECIBIDA, DIF,FECHA_CREACION,ID_USUARIO,PENDING_ID,FECHA,ID_TIPO_PLANTILLA,QTY_TB,QTY_RECIBIDA_TB,DIF_TB, PENDING_ID_TB,ESTADO_TB FROM PRD_RECIBO_PT WHERE FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "RECIBO_PT", ref ControlError);



                //    if (ControlError == "Completado")
                //    {
                //        bool EstadoEncontroOrden = false;
                //        string OpABuscar = "";
                //        string CodigoArticulo = "";
                //        string CantidadTA = "";
                //        string CantidadTB = "";
                //        string WarehouseId = "";

                //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //        {
                //            OpABuscar = ds.Tables[0].Rows[i]["OP"].ToString();
                //            CodigoArticulo = ds.Tables[0].Rows[i]["CODIGO_ARTICULO"].ToString();

                         
                //            CantidadTA = ds.Tables[0].Rows[i]["QTY_TA"].ToString();
                //            CantidadTB = ds.Tables[0].Rows[i]["QTY_TB"].ToString();

                //            if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 1)
                //            {
                //                NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY=" + CantidadTA + " WHERE   FECHA='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND OP='" + OpABuscar + "'", ref ControlError);
                //            }
                //            if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 1)
                //            {
                //                NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_TB=" + CantidadTB + " WHERE FECHA='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND OP='" + OpABuscar + "'", ref ControlError);
                //            }

                //            if (ControlError == "Completado")
                //            {
                //                if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 0)
                //                {
                //                    NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + CantidadTA + "," + CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                //                }

                //                if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") != 0)
                //                {
                //                    NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + CantidadTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                //                }

                //                if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") != 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 0)
                //                {
                //                    NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                //                }

                //                if (ControlError == "Completado")
                //                {


                //                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 2)
                //                    {
                //                        //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                //                        decimal QtyTemporalTA = 0;
                //                        decimal QtyFinalTA = 0;
                //                        decimal QtyTemporalTB = 0;
                //                        decimal QtyFinalTB = 0;

                //                        for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                //                        {
                //                            if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                //                            {
                //                                QtyTemporalTA = QtyTemporalTA + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY"].ToString());
                //                                QtyTemporalTB = QtyTemporalTB + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY_TB"].ToString());
                //                            }
                //                        }

                //                        QtyFinalTA = Convert.ToDecimal(CantidadTA) - QtyTemporalTA;

                //                        QtyFinalTB = Convert.ToDecimal(CantidadTB) - QtyTemporalTB;

                //                        if (QtyFinalTA != 0 && QtyFinalTB != 0)
                //                        {

                //                            NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + "," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                //                        }
                //                        if (QtyFinalTA != 0 && QtyFinalTB == 0)
                //                        {

                //                            NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                //                        }
                //                        if (QtyFinalTA == 0 && QtyFinalTB != 0)
                //                        {

                //                            NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                //                        }

                //                    }

                //                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") != 2)
                //                    {
                //                        //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                //                        decimal QtyTemporalTA = 0;
                //                        decimal QtyFinalTA = 0;


                //                        for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                //                        {
                //                            if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                //                            {
                //                                QtyTemporalTA = QtyTemporalTA + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY"].ToString());
                //                            }
                //                        }

                //                        QtyFinalTA = Convert.ToDecimal(CantidadTA) - QtyTemporalTA;



                //                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);

                //                    }
                //                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") != 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 2)
                //                    {
                //                        //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                //                        decimal QtyTemporalTB = 0;
                //                        decimal QtyFinalTB = 0;


                //                        for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                //                        {
                //                            if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                //                            {
                //                                QtyTemporalTB = QtyTemporalTB + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY_TB"].ToString());
                //                            }
                //                        }

                //                        QtyFinalTB = Convert.ToDecimal(CantidadTB) - QtyTemporalTB;



                //                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);

                //                    }


                //                    if (ControlError == "Completado")
                //                        Respuesta = "Completado";
                //                    else
                //                        Respuesta = "Error de conexion:" + ControlError;


                //                }
                //                else
                //                {
                //                    Respuesta = "Ocurrio un error favor contactar a su administrador 4.:" + ControlError;
                //                }


                //            }
                //            else
                //            {
                //                Respuesta = "Ocurrio un error favor contactar a su administrador 3.:" + ControlError;
                //            }



                //        }
                //        if (IdTipoPlantilla != "CONFSAC-01")
                //            Query = "SELECT PT.ID_RECIBO_PT,PT.OP,PT.CODIGO_ARTICULO,P.DESCRIPTION,(SELECT COUNT(BTRP.TAG) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='A') AS CONT_TAGS_TURNO_A, PT.QTY,PT.ESTADO_RECIBO,PT.ESTADO,PT.ID_CALCULO,PT.WAREHOUSE_ID,PT.LOCATION_ID,PT.QTY_RECIBIDA, PT.DIF,PT.FECHA_CREACION,PT.ID_USUARIO,PT.PENDING_ID,PT.FECHA,PT.ID_TIPO_PLANTILLA,(SELECT COUNT(BTRP.TAG) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='B') AS CONT_TAGS_TURNO_B, PT.QTY_TB,PT.QTY_RECIBIDA_TB,PT.DIF_TB, PT.PENDING_ID_TB,PT.ESTADO_TB FROM " + DB + ".DBO.PRD_RECIBO_PT  AS PT WITH (NOLOCK) ,"+SMVISUAL+".DBO.PART AS P WITH (NOLOCK) WHERE   PT.FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND PT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND PT.CODIGO_ARTICULO LIKE '%" + FiltroProducto + "%' AND P.ID=PT.CODIGO_ARTICULO";

                //        if (IdTipoPlantilla == "CONFSAC-01")
                //            Query = "SELECT PT.ID_RECIBO_PT,PT.OP,PT.CODIGO_ARTICULO,P.DESCRIPTION,(SELECT COUNT(BTRP.TAG) FROM DBPOLY.DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='A') AS CONT_TAGS_TURNO_A, PT.QTY,PT.ESTADO_RECIBO,PT.ESTADO,PT.ID_CALCULO,PT.WAREHOUSE_ID,PT.LOCATION_ID,PT.QTY_RECIBIDA, PT.DIF,PT.FECHA_CREACION,PT.ID_USUARIO,PT.PENDING_ID,PT.FECHA,PT.ID_TIPO_PLANTILLA,(SELECT COUNT(BTRP.TAG) FROM DBPOLY.DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='B') AS CONT_TAGS_TURNO_B, PT.QTY_TB,PT.QTY_RECIBIDA_TB,PT.DIF_TB, PT.PENDING_ID_TB,PT.ESTADO_TB FROM " + DB + ".DBO.PRD_RECIBO_PT  AS PT WITH (NOLOCK) ,"+SMVISUAL+".DBO.PART AS P WITH (NOLOCK) WHERE   PT.FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND PT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND P.ID=PT.CODIGO_ARTICULO";

                //        dsTable = NuevaConexion.consultaSelect(Query, "RECIBO_PT", ref ControlError);

                //        if (ControlError != "Completado")
                //        {

                //            Respuesta = "Ocurrio un error favor contactar a su administrador:"+ControlError;
                //        }
                //        else {
                //            Respuesta = "Completado";
                        
                //        }

                //    }
                //    else
                //    {
                //        Respuesta = "Ocurrio un error favor contactar a su administrador 2.:" + ControlError;
                //    }

                //}
                //else
                //{
                //    Respuesta = "Ocurrio un error favor contactar a su administrador 1.:" + ControlError;
                //}

                DataSet ds = new DataSet();
                DataSet dsReciboPtGridView = new DataSet();
                string ControlError = "";

                string Query = "";
                conexion NuevaConexion = new conexion();
                NuevaConexion.SetServer(Server);
                NuevaConexion.SetDB(DB);
                NuevaConexion.SetUsuario(UserId);
                NuevaConexion.SetPassword(Pass);
                string QuerysAcumulados = "";
                DataSet dsUsersDefine = NuevaConexion.consultaSelect("SELECT USER_1,USER_2,USER_3,USER_4,USER_5 FROM " + DB + ".DBO.PRD_USUARIO WHERE ID_USUARIO='" + UserId + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "USERS", ref ControlError);


                string FiltroProducto = "";

                if (dsUsersDefine.Tables[0].Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(dsUsersDefine.Tables[0].Rows[0]["USER_1"])))
                    {
                        FiltroProducto = dsUsersDefine.Tables[0].Rows[0]["USER_1"].ToString();
                    }
                }


                //     if (User_id.ToString() == "OPENFAR1" || User_id.ToString() == "OPENFA2" || User_id.ToString() == "LGARCIA" || User_id.ToString() == "JJUAREZ" || User_id.ToString() == "DOPENFAR" || User_id.ToString() == "DOPENF2")
                if (lst_tipo_plantilla.EditValue.ToString() == "DENFARDA"
                    || lst_tipo_plantilla.EditValue.ToString() == "DENFJUMBO"
                    || lst_tipo_plantilla.EditValue.ToString() == "CONFSAC-04"
                    || lst_tipo_plantilla.EditValue.ToString() == "CONFJMB-05"
                    || lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN"
                    || lst_tipo_plantilla.EditValue.ToString() == "TELMACEN"
                    
                    )
                {
                    Query = "SELECT TEMP.OP, TEMP.COD_ARTICULO AS CODIGO_ARTICULO,";
                    Query = Query + " isnull((SELECT SUM(T1.UNIDAD_2) ";
                    Query = Query + "  FROM " + DB + ".DBO.BRC_TAGS AS T1";
                    Query = Query + "  WHERE ISNULL(T1.OP,T1.COD_ARTICULO)=ISNULL(TEMP.OP,TEMP.COD_ARTICULO)  AND T1.COD_ARTICULO=TEMP.COD_ARTICULO  ";
                    Query = Query + "  AND T1.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' ";
                    Query = Query + "  AND  T1.FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND T1.TURNO='A' AND T1.ACTIVO='Y'  AND ID_RECIBO_PT IS NULL ),0)  AS QTY_TA,";
                    Query = Query + " isnull((SELECT SUM(T1.UNIDAD_2) ";
                    Query = Query + " FROM " + DB + ".DBO.BRC_TAGS AS T1 ";
                    Query = Query + " WHERE ISNULL(T1.OP,T1.COD_ARTICULO)=ISNULL(TEMP.OP,TEMP.COD_ARTICULO) AND T1.COD_ARTICULO=TEMP.COD_ARTICULO   ";
                    Query = Query + " AND T1.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'";
                    Query = Query + " AND  T1.FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND T1.TURNO='B' AND T1.ACTIVO='Y'  AND ID_RECIBO_PT IS NULL ),0)  AS QTY_TB";
                    Query = Query + " FROM ( ";
                    Query = Query + " SELECT  OP,COD_ARTICULO FROM " + DB + ".DBO.BRC_TAGS ";
                    Query = Query + " WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ACTIVO='Y'";
                    Query = Query + " GROUP BY   OP,COD_ARTICULO ";
                    Query = Query + " ) AS TEMP";

                    if (!string.IsNullOrEmpty(FiltroProducto))
                        Query = Query + " WHERE TEMP.COD_ARTICULO LIKE '%" + FiltroProducto + "%'";

                    ds = NuevaConexion.consultaSelect(Query, "TIPOPLANTILLA", ref ControlError);
                    QuerysAcumulados = QuerysAcumulados + Query;
                    if (ControlError == "Completado")
                    {
                        if (IdTipoPlantilla != "CONFSAC-01")
                            dsReciboPtGridView = NuevaConexion.consultaSelect("SELECT ID_RECIBO_PT,OP,CODIGO_ARTICULO,QTY,ESTADO_RECIBO,ESTADO,ID_CALCULO,WAREHOUSE_ID,LOCATION_ID,QTY_RECIBIDA, DIF,FECHA_CREACION,ID_USUARIO,PENDING_ID,FECHA,ID_TIPO_PLANTILLA,QTY_TB,QTY_RECIBIDA_TB,DIF_TB, PENDING_ID_TB,ESTADO_TB FROM PRD_RECIBO_PT WHERE   FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND CODIGO_ARTICULO LIKE '%" + FiltroProducto + "%'", "RECIBO_PT", ref ControlError);

                        if (IdTipoPlantilla == "CONFSAC-01")
                            dsReciboPtGridView = NuevaConexion.consultaSelect("SELECT ID_RECIBO_PT,OP,CODIGO_ARTICULO,QTY,ESTADO_RECIBO,ESTADO,ID_CALCULO,WAREHOUSE_ID,LOCATION_ID,QTY_RECIBIDA, DIF,FECHA_CREACION,ID_USUARIO,PENDING_ID,FECHA,ID_TIPO_PLANTILLA,QTY_TB,QTY_RECIBIDA_TB,DIF_TB, PENDING_ID_TB,ESTADO_TB FROM PRD_RECIBO_PT WHERE FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "RECIBO_PT", ref ControlError);



                        if (ControlError == "Completado")
                        {
                            bool EstadoEncontroOrden = false;
                            string OpABuscar = "";
                            string CodigoArticulo = "";
                            string CantidadTA = "";
                            string CantidadTB = "";
                            string WarehouseId = "";
                            string IdReciboPt = "";
                            string EstadoRecibo = "";




                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {


                                OpABuscar = ds.Tables[0].Rows[i]["OP"].ToString();
                                CodigoArticulo = ds.Tables[0].Rows[i]["CODIGO_ARTICULO"].ToString();

                                CantidadTA = ds.Tables[0].Rows[i]["QTY_TA"].ToString();
                                CantidadTB = ds.Tables[0].Rows[i]["QTY_TB"].ToString();

                                //  IdReciboPt = NuevaConexion.ejecutaEscalar("SELECT ID_RECIBO_PT FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE  OP ='" + OpABuscar + "' AND QTY = " + CantidadTA + " AND QTY_TB = " + CantidadTB + " AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "'", ref ControlError);
                                //     EstadoRecibo = NuevaConexion.ejecutaEscalar("SELECT ESTADO_RECIBO FROM " + DB + ".DBO.PRD_RECIBO_PT WHERE ID_RECIBO_PT = " + IdReciboPt, ref ControlError);





                                // buscar orden segun el estado recibido
                              //  if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 1)
                              //  {
                                    //NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY=" + CantidadTA + " WHERE   FECHA='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND OP='" + OpABuscar + "'", ref ControlError);

                             //   }
                            //    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 1)
                           //     {
                                    // NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_TB=" + CantidadTB + " WHERE FECHA ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA ='" + IdTipoPlantilla + "' AND OP ='" + OpABuscar + "'", ref ControlError);

                              //  }

                                if (ControlError == "Completado")
                                {


                                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 0)
                                    {
                                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + CantidadTA + "," + CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                    }

                                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") != 0)
                                    {
                                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + CantidadTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                    }
                                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") != 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 0)
                                    {
                                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                    }

                                    if (ControlError == "Completado")
                                    {


                                        if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 2)
                                        {
                                            //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                                            decimal QtyTemporalTA = 0;
                                            decimal QtyFinalTA = 0;
                                            decimal QtyTemporalTB = 0;
                                            decimal QtyFinalTB = 0;

                                            for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                                            {
                                                if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                                                {
                                                    QtyTemporalTA = QtyTemporalTA + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY"].ToString());
                                                    QtyTemporalTB = QtyTemporalTB + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY_TB"].ToString());
                                                }
                                            }

                                            QtyFinalTA = Convert.ToDecimal(CantidadTA) - QtyTemporalTA;

                                            QtyFinalTB = Convert.ToDecimal(CantidadTB) - QtyTemporalTB;

                                            if (QtyFinalTA != 0 && QtyFinalTB != 0)
                                            {

                                                NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + "," + /* QtyFinalTB */ CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                            }
                                            if (QtyFinalTA != 0 && QtyFinalTB == 0)
                                            {

                                                NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                            }
                                            if (QtyFinalTA == 0 && QtyFinalTB != 0)
                                            {

                                                NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                            }

                                        }

                                        if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") != 2)
                                        {
                                            //   Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                                            decimal QtyTemporalTA = 0;
                                            decimal QtyFinalTA = 0;
                                            string Completado = "";
                                            string NoCompletado = "";
                                            int Estado = 0;


                                            for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                                            {


                                                if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar && EstadoRecibo == "N")
                                                {
                                                    QtyTemporalTA = QtyTemporalTA + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY"].ToString());
                                                }
                                            }

                                            QtyFinalTA = Convert.ToDecimal(CantidadTA) - QtyTemporalTA;



                                            Completado = NuevaConexion.ejecutaEscalar("select COUNT(ESTADO_RECIBO) from " + DB + ".DBO.PRD_RECIBO_PT where ESTADO = 'Completado' and OP = '" + OpABuscar + "'  AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' ", ref ControlError);


                                            Estado = Convert.ToInt32(Completado);

                                            if (Estado == 1 && OpABuscar == lst_op.EditValue.ToString())
                                            {
                                                NoCompletado = NuevaConexion.ejecutaEscalar("select COUNT(ESTADO_RECIBO) from " + DB + ".DBO.PRD_RECIBO_PT where ESTADO is null and OP = '" + OpABuscar + "'  AND FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "'", ref ControlError);

                                                Estado = Convert.ToInt32(NoCompletado);

                                                if (Estado == 0)
                                                {
                                                    NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                                }

                                            }

                                        }


                                        if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") != 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 2)
                                        {
                                            //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                                            decimal QtyTemporalTB = 0;
                                            decimal QtyFinalTB = 0;


                                            for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                                            {
                                                if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                                                {
                                                    QtyTemporalTB = QtyTemporalTB + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY_TB"].ToString());
                                                }
                                            }

                                            QtyFinalTB = Convert.ToDecimal(CantidadTB) - QtyTemporalTB;

                                            NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + /*QtyFinalTB */ CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);

                                        }


                                        if (ControlError == "Completado")
                                            Respuesta = "Completado";
                                        else
                                            Respuesta = "Error de conexion:" + ControlError;


                                    }
                                    else
                                    {
                                        Respuesta = "Ocurrio un error favor contactar a su administrador 4.:" + ControlError;
                                    }


                                }
                                else
                                {
                                    Respuesta = "Ocurrio un error favor contactar a su administrador 3.:" + ControlError;
                                }



                            }
                            if (IdTipoPlantilla != "CONFSAC-01")
                                Query = "SELECT PT.ID_RECIBO_PT,PT.OP,PT.CODIGO_ARTICULO,P.DESCRIPTION,(SELECT COUNT(BTRP.TAG) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='A') AS CONT_TAGS_TURNO_A, PT.QTY,PT.ESTADO_RECIBO,PT.ESTADO,PT.ID_CALCULO,PT.WAREHOUSE_ID,PT.LOCATION_ID,PT.QTY_RECIBIDA, PT.DIF,PT.FECHA_CREACION,PT.ID_USUARIO,PT.PENDING_ID,PT.FECHA,PT.ID_TIPO_PLANTILLA,(SELECT COUNT(BTRP.TAG) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='B') AS CONT_TAGS_TURNO_B, PT.QTY_TB,PT.QTY_RECIBIDA_TB,PT.DIF_TB, PT.PENDING_ID_TB,PT.ESTADO_TB FROM " + DB + ".DBO.PRD_RECIBO_PT  AS PT WITH (NOLOCK) ," + DB + ".DBO.BRC_PART AS P WITH (NOLOCK) WHERE   PT.FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND PT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND PT.CODIGO_ARTICULO LIKE '%" + FiltroProducto + "%' AND P.ID COLLATE DATABASE_DEFAULT = PT.CODIGO_ARTICULO COLLATE DATABASE_DEFAULT ";

                            if (IdTipoPlantilla == "CONFSAC-01")
                                Query = "SELECT PT.ID_RECIBO_PT,PT.OP,PT.CODIGO_ARTICULO,P.DESCRIPTION,(SELECT COUNT(BTRP.TAG) FROM DBPOLY.DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='A') AS CONT_TAGS_TURNO_A, PT.QTY,PT.ESTADO_RECIBO,PT.ESTADO,PT.ID_CALCULO,PT.WAREHOUSE_ID,PT.LOCATION_ID,PT.QTY_RECIBIDA, PT.DIF,PT.FECHA_CREACION,PT.ID_USUARIO,PT.PENDING_ID,PT.FECHA,PT.ID_TIPO_PLANTILLA,(SELECT COUNT(BTRP.TAG) FROM DBPOLY.DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='B') AS CONT_TAGS_TURNO_B, PT.QTY_TB,PT.QTY_RECIBIDA_TB,PT.DIF_TB, PT.PENDING_ID_TB,PT.ESTADO_TB FROM " + DB + ".DBO.PRD_RECIBO_PT  AS PT WITH (NOLOCK) ," + DB + ".DBO.BRC_PART AS P WITH (NOLOCK) WHERE   PT.FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND PT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND P.ID COLLATE DATABASE_DEFAULT = PT.CODIGO_ARTICULO COLLATE DATABASE_DEFAULT ";

                            dsTable = NuevaConexion.consultaSelect(Query, "RECIBO_PT", ref ControlError);

                            if (ControlError != "Completado")
                            {

                                Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                            }
                            else
                            {
                                Respuesta = "Completado";

                            }

                        }
                        else
                        {
                            Respuesta = "Ocurrio un error favor contactar a su administrador 2.:" + ControlError;
                        }

                    }
                    else
                    {
                        Respuesta = "Ocurrio un error favor contactar a su administrador 1.:" + ControlError;
                    }
                }






        //      if ( User_id.ToString() != "OPENFAR1"  && User_id.ToString() != "OPENFA2" &&  User_id.ToString() != "LGARCIA" && User_id.ToString() != "JJUAREZ" && User_id.ToString() != "DOPENFAR" && User_id.ToString() != "DOPENF2")
                //    if (lst_tipo_plantilla.EditValue.ToString() != "DENFARDA" 
                //|| lst_tipo_plantilla.EditValue.ToString() != "DENFJUMBO" 
                //|| lst_tipo_plantilla.EditValue.ToString() != "CONFSAC-04" 
                //|| lst_tipo_plantilla.EditValue.ToString() != "CONFJMB-05")
                else
                {
                    Query = "SELECT TEMP.OP, TEMP.COD_ARTICULO AS CODIGO_ARTICULO,";
                    Query = Query + " isnull((SELECT SUM(T1.UNIDAD_2) ";
                    Query = Query + "  FROM " + DB + ".DBO.BRC_TAGS AS T1";
                    Query = Query + "  WHERE ISNULL(T1.OP,T1.COD_ARTICULO)=ISNULL(TEMP.OP,TEMP.COD_ARTICULO) AND T1.COD_ARTICULO=TEMP.COD_ARTICULO  ";
                    Query = Query + "  AND T1.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' ";
                    Query = Query + "  AND  T1.FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND T1.TURNO='A' AND T1.ACTIVO='Y' ),0)  AS QTY_TA,";
                    Query = Query + " isnull((SELECT SUM(T1.UNIDAD_2) ";
                    Query = Query + " FROM " + DB + ".DBO.BRC_TAGS AS T1 ";
                    Query = Query + " WHERE ISNULL(T1.OP,T1.COD_ARTICULO)=ISNULL(TEMP.OP,TEMP.COD_ARTICULO) AND T1.COD_ARTICULO=TEMP.COD_ARTICULO   ";
                    Query = Query + " AND T1.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'";
                    Query = Query + " AND  T1.FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND T1.TURNO='B' AND T1.ACTIVO='Y' ),0)  AS QTY_TB";
                    Query = Query + " FROM ( ";
                    Query = Query + " SELECT OP,COD_ARTICULO FROM " + DB + ".DBO.BRC_TAGS ";
                    Query = Query + " WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND FECHA_TRANSACCION='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ACTIVO='Y'";
                    Query = Query + " GROUP BY  OP,COD_ARTICULO ";
                    Query = Query + " ) AS TEMP";

                    if (!string.IsNullOrEmpty(FiltroProducto))
                        Query = Query + " WHERE TEMP.COD_ARTICULO LIKE '%" + FiltroProducto + "%'";

                    ds = NuevaConexion.consultaSelect(Query, "TIPOPLANTILLA", ref ControlError);
                    QuerysAcumulados = QuerysAcumulados + Query;
                    if (ControlError == "Completado")
                    {
                        if (IdTipoPlantilla != "CONFSAC-01")
                            dsReciboPtGridView = NuevaConexion.consultaSelect("SELECT ID_RECIBO_PT,OP,CODIGO_ARTICULO,QTY,ESTADO_RECIBO,ESTADO,ID_CALCULO,WAREHOUSE_ID,LOCATION_ID,QTY_RECIBIDA, DIF,FECHA_CREACION,ID_USUARIO,PENDING_ID,FECHA,ID_TIPO_PLANTILLA,QTY_TB,QTY_RECIBIDA_TB,DIF_TB, PENDING_ID_TB,ESTADO_TB FROM PRD_RECIBO_PT WHERE   FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND CODIGO_ARTICULO LIKE '%" + FiltroProducto + "%'", "RECIBO_PT", ref ControlError);

                        if (IdTipoPlantilla == "CONFSAC-01")
                            dsReciboPtGridView = NuevaConexion.consultaSelect("SELECT ID_RECIBO_PT,OP,CODIGO_ARTICULO,QTY,ESTADO_RECIBO,ESTADO,ID_CALCULO,WAREHOUSE_ID,LOCATION_ID,QTY_RECIBIDA, DIF,FECHA_CREACION,ID_USUARIO,PENDING_ID,FECHA,ID_TIPO_PLANTILLA,QTY_TB,QTY_RECIBIDA_TB,DIF_TB, PENDING_ID_TB,ESTADO_TB FROM PRD_RECIBO_PT WHERE FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "'", "RECIBO_PT", ref ControlError);



                        if (ControlError == "Completado")
                        {
                            bool EstadoEncontroOrden = false;
                            string OpABuscar = "";
                            string CodigoArticulo = "";
                            string CantidadTA = "";
                            string CantidadTB = "";
                            string WarehouseId = "";

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                OpABuscar = ds.Tables[0].Rows[i]["OP"].ToString();
                                CodigoArticulo = ds.Tables[0].Rows[i]["CODIGO_ARTICULO"].ToString();


                                CantidadTA = ds.Tables[0].Rows[i]["QTY_TA"].ToString();
                                CantidadTB = ds.Tables[0].Rows[i]["QTY_TB"].ToString();

                                if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 1)
                                {
                                    NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY=" + CantidadTA + " WHERE   FECHA='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND OP='" + OpABuscar + "'", ref ControlError);
                                }
                                if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 1)
                                {
                                    NuevaConexion.insertar("UPDATE " + DB + ".DBO.PRD_RECIBO_PT SET QTY_TB=" + CantidadTB + " WHERE FECHA='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND OP='" + OpABuscar + "'", ref ControlError);
                                }

                                if (ControlError == "Completado")
                                {
                                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 0)
                                    {
                                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + CantidadTA + "," + CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                    }

                                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") != 0)
                                    {
                                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + CantidadTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                    }

                                    if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") != 0 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 0)
                                    {
                                        NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + CantidadTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                    }

                                    if (ControlError == "Completado")
                                    {


                                        if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 2)
                                        {
                                            //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                                            decimal QtyTemporalTA = 0;
                                            decimal QtyFinalTA = 0;
                                            decimal QtyTemporalTB = 0;
                                            decimal QtyFinalTB = 0;

                                            for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                                            {
                                                if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                                                {
                                                    QtyTemporalTA = QtyTemporalTA + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY"].ToString());
                                                    QtyTemporalTB = QtyTemporalTB + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY_TB"].ToString());
                                                }
                                            }

                                            QtyFinalTA = Convert.ToDecimal(CantidadTA) - QtyTemporalTA;

                                            QtyFinalTB = Convert.ToDecimal(CantidadTB) - QtyTemporalTB;

                                            if (QtyFinalTA != 0 && QtyFinalTB != 0)
                                            {

                                                NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + "," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                            }
                                            if (QtyFinalTA != 0 && QtyFinalTB == 0)
                                            {

                                                NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                            }
                                            if (QtyFinalTA == 0 && QtyFinalTB != 0)
                                            {

                                                NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);
                                            }

                                        }

                                        if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") == 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") != 2)
                                        {
                                            //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                                            decimal QtyTemporalTA = 0;
                                            decimal QtyFinalTA = 0;


                                            for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                                            {
                                                if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                                                {
                                                    QtyTemporalTA = QtyTemporalTA + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY"].ToString());
                                                }
                                            }

                                            QtyFinalTA = Convert.ToDecimal(CantidadTA) - QtyTemporalTA;



                                            NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "'," + QtyFinalTA + ",0,'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);

                                        }
                                        if (BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "A") != 2 && BuscaOrden(dsReciboPtGridView, OpABuscar, CodigoArticulo, "B") == 2)
                                        {
                                            //Proceso de buscar o sumar la cantidades de la orden ya completada o en proceso y crear un nuevo registro

                                            decimal QtyTemporalTB = 0;
                                            decimal QtyFinalTB = 0;


                                            for (int l = 0; l < dsReciboPtGridView.Tables[0].Rows.Count; l++)
                                            {
                                                if (dsReciboPtGridView.Tables[0].Rows[l]["OP"].ToString() == OpABuscar)
                                                {
                                                    QtyTemporalTB = QtyTemporalTB + Convert.ToDecimal(dsReciboPtGridView.Tables[0].Rows[l]["QTY_TB"].ToString());
                                                }
                                            }

                                            QtyFinalTB = Convert.ToDecimal(CantidadTB) - QtyTemporalTB;



                                            NuevaConexion.insertar("INSERT INTO  " + DB + ".DBO.PRD_RECIBO_PT(OP,CODIGO_ARTICULO,QTY,QTY_TB,ESTADO_RECIBO,ESTADO,FECHA,ID_TIPO_PLANTILLA,FECHA_CREACION,ID_USUARIO,ID_CALCULO) VALUES('" + OpABuscar + "','" + CodigoArticulo + "',0," + QtyFinalTB + ",'N',NULL,'" + Convert.ToDateTime(Fecha).Year + "-" + Convert.ToDateTime(Fecha).Month + "-" + Convert.ToDateTime(Fecha).Day + "','" + IdTipoPlantilla + "',GETDATE(),'" + UserId + "'," + IdCalculo.ToString() + ")", ref ControlError);

                                        }


                                        if (ControlError == "Completado")
                                            Respuesta = "Completado";
                                        else
                                            Respuesta = "Error de conexion:" + ControlError;


                                    }
                                    else
                                    {
                                        Respuesta = "Ocurrio un error favor contactar a su administrador 4.:" + ControlError;
                                    }


                                }
                                else
                                {
                                    Respuesta = "Ocurrio un error favor contactar a su administrador 3.:" + ControlError;
                                }



                            }
                            if (IdTipoPlantilla != "CONFSAC-01")
                                Query = "SELECT PT.ID_RECIBO_PT,PT.OP,PT.CODIGO_ARTICULO,P.DESCRIPTION,(SELECT COUNT(BTRP.TAG) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='A') AS CONT_TAGS_TURNO_A, PT.QTY,PT.ESTADO_RECIBO,PT.ESTADO,PT.ID_CALCULO,PT.WAREHOUSE_ID,PT.LOCATION_ID,PT.QTY_RECIBIDA, PT.DIF,PT.FECHA_CREACION,PT.ID_USUARIO,PT.PENDING_ID,PT.FECHA,PT.ID_TIPO_PLANTILLA,(SELECT COUNT(BTRP.TAG) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='B') AS CONT_TAGS_TURNO_B, PT.QTY_TB,PT.QTY_RECIBIDA_TB,PT.DIF_TB, PT.PENDING_ID_TB,PT.ESTADO_TB FROM " + DB + ".DBO.PRD_RECIBO_PT  AS PT WITH (NOLOCK) ," + DB + ".DBO.BRC_PART AS P WITH (NOLOCK) WHERE   PT.FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND PT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND PT.CODIGO_ARTICULO LIKE '%" + FiltroProducto + "%' AND P.ID=PT.CODIGO_ARTICULO";

                            if (IdTipoPlantilla == "CONFSAC-01")
                                Query = "SELECT PT.ID_RECIBO_PT,PT.OP,PT.CODIGO_ARTICULO,P.DESCRIPTION,(SELECT COUNT(BTRP.TAG) FROM DBPOLY.DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='A') AS CONT_TAGS_TURNO_A, PT.QTY,PT.ESTADO_RECIBO,PT.ESTADO,PT.ID_CALCULO,PT.WAREHOUSE_ID,PT.LOCATION_ID,PT.QTY_RECIBIDA, PT.DIF,PT.FECHA_CREACION,PT.ID_USUARIO,PT.PENDING_ID,PT.FECHA,PT.ID_TIPO_PLANTILLA,(SELECT COUNT(BTRP.TAG) FROM DBPOLY.DBO.BRC_TAGS_RECIBO_PT AS BTRP WHERE BTRP.ID_RECIBO_PT=PT.ID_RECIBO_PT AND BTRP.TURNO='B') AS CONT_TAGS_TURNO_B, PT.QTY_TB,PT.QTY_RECIBIDA_TB,PT.DIF_TB, PT.PENDING_ID_TB,PT.ESTADO_TB FROM " + DB + ".DBO.PRD_RECIBO_PT  AS PT WITH (NOLOCK) ," + DB + ".DBO.BRC_PART AS P WITH (NOLOCK) WHERE   PT.FECHA  ='" + Convert.ToDateTime(Fecha).Year.ToString() + "-" + Convert.ToDateTime(Fecha).Month.ToString() + "-" + Convert.ToDateTime(Fecha).Day.ToString() + "' AND PT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND P.ID=PT.CODIGO_ARTICULO";

                            dsTable = NuevaConexion.consultaSelect(Query, "RECIBO_PT", ref ControlError);

                            if (ControlError != "Completado")
                            {

                                Respuesta = "Ocurrio un error favor contactar a su administrador:" + ControlError;
                            }
                            else
                            {
                                Respuesta = "Completado";

                            }

                        }
                        else
                        {
                            Respuesta = "Ocurrio un error favor contactar a su administrador 2.:" + ControlError;
                        }

                    }
                    else
                    {
                        Respuesta = "Ocurrio un error favor contactar a su administrador 1.:" + ControlError;
                    }


                }


            }
            catch (Exception ex)
            {
                Respuesta = "Ocurrio un Error favor contactarse con su administrador:" + ex.Message.ToString();
                
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                barButtonItem5.Enabled = false;
                try
                {
                    if (sp1.IsOpen == true)
                    {
                        sp1.Close();
                    }
                    else
                    {
                        sp1.Open();
                    }
                }
                catch (Exception Ex) { 
                
                
                }

                btn_detalle_tarimas.Visible = false;
                btn_entarimar.Visible = false;
                EsDevolucion = "N";
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
                bRC_TAGSTableAdapter.Connection.ConnectionString = Conexionfinal;
                sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter.Connection.ConnectionString = Conexionfinal;



                ctrlTitulo1.AppTitulo1 = "Usuario:" + User_id;
                ctrlTitulo1.AppTitulo2 = "Conexion:" + Server;
                ctrlTitulo1.AppTitulo3 = "Fecha:" + FechaActual.ToShortDateString();
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();

                ds = consulta.consultaSelect("SELECT PU.ID_TIPO_PLANTILLA AS Codigo,PTP.NOMBRE_PLANTILLA as Nombre FROM "+DB+".dbo.PRD_USUARIO AS PU,"+DB+".DBO.PRD_TIPO_PLANTILLA AS PTP WHERE PU.ID_USUARIO='"+User_id+"' AND PU.ID_TIPO_PLANTILLA=PTP.ID_TIPO_PLANTILLA AND PTP.ID_TIPO_PLANTILLA IN ( SELECT ID_TIPO_PLANTILLA FROM "+DB+".DBO.BRC_USUARIO_DEPARTAMENTO  WHERE ID_USUARIO='"+User_id+"') ", "TIPO_PLANTILLA", ref ControlError);
                RepositoryItemSearchLookUpEdit repositoryItemLookUpEdit1 = new RepositoryItemSearchLookUpEdit();
                repositoryItemLookUpEdit1.DataSource = ds.Tables[0];
                repositoryItemLookUpEdit1.ValueMember = "Codigo";
                repositoryItemLookUpEdit1.DisplayMember = "Nombre";

                lst_tipo_plantilla.Edit = repositoryItemLookUpEdit1;

               

                ds = consulta.consultaSelect("SELECT 'A' AS Codigo ,'Turno A' as Nombre UNION SELECT 'B' AS Codigo ,'Turno B' as Nombre ", "TURNO", ref ControlError);
                lst_turno.Properties.DataSource = ds.Tables[0];
                lst_turno.Properties.ValueMember = "Codigo";
                lst_turno.Properties.DisplayMember = "Nombre";

                ds = consulta.consultaSelect("SELECT ID AS Codigo,DESCRIPTION AS Nombre FROM " + DB + ".DBO.BRC_PART WITH(NOLOCK)  ", "ARTICULO", ref ControlError);
                lst_articulo.Properties.DataSource = ds.Tables[0];
                lst_articulo.Properties.ValueMember = "Codigo";
                lst_articulo.Properties.DisplayMember = "Nombre";
                

                barButtonItem6.Enabled = false;
                barButtonItem11.Enabled = false;
                barButtonItem5.Enabled = false;
                barButtonItem12.Enabled = false;
                EstadEditandoAuditoria = false;
              
                barButtonItem16.Enabled = false;

                txt_tag.ReadOnly = true;
                txt_tipo_plantilla.ReadOnly = true;
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
                txt_usuario_creo.ReadOnly = true;
                lst_articulo.Enabled = false;
                lst_fecha_creacion.ReadOnly = true;
                lst_operador.Enabled = false;
                lst_fecha_transaccion.Enabled = false;
                lst_maquina.Enabled = false;
                lst_op.Enabled = false;
                lst_turno.Enabled = false;
                lst_unidad1.Enabled = false;
                lst_unidad2.Enabled = false;
                chk_activo.Enabled = false;

                if (Hora >= 0 && Hora < 6)
                {

                    lst_fecha.EditValue = Convert.ToDateTime(FechaActual.AddDays(-1).ToShortDateString());
                }
                else {
                    lst_fecha.EditValue = Convert.ToDateTime(FechaActual.ToShortDateString());
                }

               
                
                
                txt_no_copias.EditValue = "1";
                CodigoUniversalInfoMaquina=new ArrayList();
                CodigoUniversalTurno = new ArrayList();

                ds = consulta.consultaSelect("SELECT UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10 FROM "+DB+".DBO.BRC_HABILITACION_CAMPOS WHERE ID_USUARIO='"+User_id+"'", "HABILITAR_CAMPOS", ref ControlError);

                if (ds.Tables[0].Rows.Count > 0) {

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
                        ) {

                            AccesoATodo = true;
                    }

                    barButtonItem17.Enabled = false;
                    barButtonItem15.Enabled = false;
                    barButtonItem14.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex + " ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            tm_lectura.Enabled = false;
            try
            {
                if (sp1.IsOpen == true)
                {
                    sp1.Close();
                }
                else
                {
                    sp1.Open();
                }
            }
            catch (Exception Ex)
            {


            }

            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                //Evento del boton primero
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido

                //Mueve al primer registro del los programas

                bRCTAGSBindingSource.MoveFirst();


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
                bRCTAGSBindingSource.MovePrevious();
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
                bRCTAGSBindingSource.MoveNext();

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
                bRCTAGSBindingSource.MoveLast();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void uNIDAD_2TextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void lst_tipo_plantilla_EditValueChanged(object sender, EventArgs e)
        {
            try {
                // ds = consulta.consultaSelect("SELECT CREAR,LEER,MODIFICAR FROM "+DB+".DBO.BRC_USUARIO_DEPARTAMENTO WHERE ID_USUARIO='"+User_id+"' AND ID_TIPO_PLANTILLA='"++"'", "", ref ControlError);

                if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue))
                    && !string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue)))
                {

                    if (lst_tipo_plantilla.EditValue.ToString().Contains("EXT-TUBBA") == true
                        || lst_tipo_plantilla.EditValue.ToString().Contains("EXT-TUBTOR") == true
                        || lst_tipo_plantilla.EditValue.ToString().Contains("KIANG-TZ")==true
                        || lst_tipo_plantilla.EditValue.ToString().Contains("CONFJMB-05") == true
                      
                        )
                    {
                        btn_detalle_tarimas.Visible = true;
                        btn_entarimar.Visible = true;
                    
                    }



                    lst_fecha_transaccion.Focus();
                    string ControlError = "";
                    conexion consulta = new conexion();
                    consulta.SetDB(DB);
                    consulta.SetUsuario(User_id);
                    consulta.SetPassword(Pass);
                    consulta.SetServer(Server);
                    DataSet ds = new DataSet();
                    string ExisteFormulaPorUsuario = "";
                    string Crear="";
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

                    EsEntarimadoACompletar = consulta.ejecutaEscalar("SELECT ISNULL(REP_ENT,'N') FROM "+DB+".DBO.PRD_TIPO_PLANTILLA WHERE ID_TIPO_PLANTILLA='"+lst_tipo_plantilla.EditValue.ToString()+"'",ref ControlError);
                    if (string.IsNullOrEmpty(EsEntarimadoACompletar))
                        EsEntarimadoACompletar = "N";


                    EsDevolucion = consulta.ejecutaEscalar("SELECT ISNULL(ES_DEVOLUCION,'N') FROM "+DB+".DBO.PRD_TIPO_PLANTILLA WHERE ID_TIPO_PLANTILLA='"+lst_tipo_plantilla.EditValue.ToString()+"' ", ref ControlError);
                    if (string.IsNullOrEmpty(EsDevolucion))
                        EsDevolucion = "N";
                    
                    ds = consulta.consultaSelect("SELECT ISNULL(CREAR,'N') AS CREAR,ISNULL(LEER,'N') AS LEER, ISNULL(MODIFICAR,'N') AS MODIFICAR, isnull(LECTURA_BASCULA,'') as BASCULA, isnull(RESETEAR_LECTURA,'N') AS RESETEAR_LECTURA   FROM " + DB + ".DBO.BRC_USUARIO_DEPARTAMENTO WHERE ID_USUARIO='" + User_id + "' AND ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "'", "PERMISOS", ref ControlError);

                    if (ds.Tables[0].Rows.Count > 0) {
                        Crear = ds.Tables[0].Rows[0]["CREAR"].ToString();
                        Leer = ds.Tables[0].Rows[0]["LEER"].ToString();
                        Modificar = ds.Tables[0].Rows[0]["MODIFICAR"].ToString();
                        ModificacionPublica = Modificar;
                        MarcaBascula = ds.Tables[0].Rows[0]["BASCULA"].ToString();
                        ResetearLectura = ds.Tables[0].Rows[0]["RESETEAR_LECTURA"].ToString();
                        if (MarcaBascula == "BREKNELLSIB100")
                            tm_lectura.Interval = 100;
                        else
                            tm_lectura.Interval = 500;

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
                    }
                    else
                    {
                 
                        barButtonItem12.Enabled = false;
                    }


                    string Sufijo = "";
                    string QueryFormulas = "";
                    Sufijo = consulta.ejecutaEscalar("SELECT SUFIJO FROM "+DB+".DBO.BRC_CORRELATIVOS where ID_TIPO_PLANTILLA='"+lst_tipo_plantilla.EditValue.ToString()+"' AND ACTIVO='Y'", ref ControlError);


                    if (!string.IsNullOrEmpty(Sufijo))
                    {

                        ds = consulta.consultaSelect("SELECT W.BASE_ID AS Codigo,W.PART_ID+' - '+P.DESCRIPTION as Nombre FROM " + SMVISUAL + ".DBO.WORK_ORDER AS W WITH (NOLOCK)," + SMVISUAL + ".DBO.PART AS P WITH (NOLOCK) WHERE W.BASE_ID LIKE '%-" + Sufijo + "' AND W.TYPE='W' AND W.PART_ID=P.ID ", "OP", ref ControlError);
                        lst_op.Properties.DataSource = ds.Tables[0];
                        lst_op.Properties.ValueMember = "Codigo";
                        lst_op.Properties.DisplayMember = "Codigo";

                        ds = consulta.consultaSelect("SELECT DISTINCT M.ID_MAQUINA as Codigo,S.DESCRIPTION AS Nombre FROM " + DB + ".DBO.PRD_USUARIO_MAQUINA AS M ," + SMVISUAL + ".DBO.SHOP_RESOURCE AS S WHERE M.ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND M.ID_MAQUINA COLLATE DATABASE_DEFAULT = S.ID COLLATE DATABASE_DEFAULT ", "MAQUINAS", ref ControlError);
                        lst_maquina.Properties.DataSource = ds.Tables[0];
                        lst_maquina.Properties.ValueMember = "Codigo";
                        lst_maquina.Properties.DisplayMember = "Nombre";

                        ds = consulta.consultaSelect("SELECT ID_OPERADOR AS Codigo, NOMBRE as Nombre FROM "+DB+".DBO.PRD_OPERADOR WHERE ID_TIPO_PLANTILLA='"+lst_tipo_plantilla.EditValue.ToString()+"'", "OPERADOR", ref ControlError);
                        lst_operador.Properties.DataSource = ds.Tables[0];
                        lst_operador.Properties.ValueMember = "Codigo";
                        lst_operador.Properties.DisplayMember = "Nombre";


                        ExisteFormulaPorUsuario = consulta.ejecutaEscalar("SELECT COUNT(ID_TIPO_PLANTILLA) FROM "+DB+".DBO.BRC_CAMPOS_DEF_USUARIO_USR AS BC WHERE BC.ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ID_USUARIO='"+User_id+"' ", ref ControlError);
                        
                        if (string.IsNullOrEmpty(ExisteFormulaPorUsuario))
                            ExisteFormulaPorUsuario = "0";

                        if (Convert.ToInt32(ExisteFormulaPorUsuario) > 0)
                        {
                            QueryFormulas = "SELECT TEXTO_USER_1,TEXTO_USER_2,TEXTO_USER_3,TEXTO_USER_4,TEXTO_USER_5,TEXTO_USER_6,TEXTO_USER_7,TEXTO_USER_8,TEXTO_USER_9,TEXTO_USER_10,UNIDAD_1,UNIDAD_2 FROM " + DB + ".DBO.BRC_CAMPOS_DEF_USUARIO_USR AS BC WHERE BC.ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ID_USUARIO='" + User_id + "'";
                        }
                        else {

                            QueryFormulas = "SELECT TEXTO_USER_1,TEXTO_USER_2,TEXTO_USER_3,TEXTO_USER_4,TEXTO_USER_5,TEXTO_USER_6,TEXTO_USER_7,TEXTO_USER_8,TEXTO_USER_9,TEXTO_USER_10,UNIDAD_1,UNIDAD_2 FROM " + DB + ".DBO.BRC_CAMPOS_DEF_USUARIO WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "'";
                        }

                        //ds = consulta.consultaSelect("SELECT TEXTO_USER_1,TEXTO_USER_2,TEXTO_USER_3,TEXTO_USER_4,TEXTO_USER_5,TEXTO_USER_6,TEXTO_USER_7,TEXTO_USER_8,TEXTO_USER_9,TEXTO_USER_10,UNIDAD_1,UNIDAD_2 FROM " + DB + ".DBO.BRC_CAMPOS_DEF_USUARIO WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "'", "CAMPOS", ref ControlError);
                        ds = consulta.consultaSelect(QueryFormulas,"DATOS",ref ControlError);


                        if (ds.Tables[0].Rows.Count > 0) {

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
                                Position = txt_user2.Location.X - lbl_user2.Size.Width-5;
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
                                Position = lbl_unidad_1.Location.X - lbl_unidad_1.Size.Width - 5+52;
                                lbl_unidad_1.Location = new Point(Position, lbl_unidad_1.Location.Y);
                                lst_unidad1.Visible = true;
                                lbl_unidad_1.Visible = true;
                            }
                            else
                            {
                                lst_unidad1.Visible = false;
                                lbl_unidad_1.Visible = false;
                            }


                            if (!string.IsNullOrEmpty(Unidad_2))
                            {
                                lbl_unidad_2.Text = Unidad_2;
                                Position = lbl_unidad_2.Location.X - lbl_unidad_2.Size.Width - 5+52;
                                lbl_unidad_2.Location = new Point(Position, lbl_unidad_2.Location.Y);
                                lst_unidad2.Visible = true;
                                lbl_unidad_2.Visible = true;
                            }
                            else
                            {
                                lst_unidad2.Visible = false;
                                lbl_unidad_2.Visible = false;
                            }
                        }

                        barButtonItem11.PerformClick();
                    }
                    else {

                        MessageBox.Show("Debe seleccionar un departamento y una fecha para poder buscar los registros.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }


                    if (lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN")
                    {
                        ds = consulta.consultaSelect("SELECT 'Producido' as Codigo union select 'Etiquetado' as Codigo ", "TIPO", ref ControlError);
                        txt_user3.Properties.DataSource = ds.Tables[0];
                        txt_user3.Properties.ValueMember = "Codigo";
                        txt_user3.Properties.DisplayMember = "Codigo";
                    }


                }

                if (lst_tipo_plantilla.EditValue.ToString() == "EXT-PTL" 
                    || lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02")
                {
                    barButtonItem14.Enabled = false;
                    barButtonItem19.Enabled = false;
                    barButtonItem17.Enabled = false;
                }



               


            }catch(Exception ex){

                MessageBox.Show("Ocurrio un error favor contactar al administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }



          



        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //prueba cambio
            string ControlError = "";
            conexion consulta = new conexion();
            consulta.SetDB(DB);
            consulta.SetUsuario(User_id);
            consulta.SetPassword(Pass);
            consulta.SetServer(Server);

            if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)) 
                && !string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue)) && AccesoATodo == false)
            {
                //this.bRC_TAGSTableAdapter.FillObtenerTagsTipoPlantilla(this.dataSetTags.BRC_TAGS, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "N");
                this.sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter.FillObtenerTags(dataSetEncabezado.SP_BRC_OBTENER_TAGS_TIPO_PLANTILLA, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "N");
            }


            if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue))
                && !string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue)) && AccesoATodo == true)
            {
                //this.bRC_TAGSTableAdapter.FillObtenerTagsTipoPlantilla(this.dataSetTags.BRC_TAGS, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "Y");

                this.sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter.FillObtenerTags(dataSetEncabezado.SP_BRC_OBTENER_TAGS_TIPO_PLANTILLA, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "Y");
            }

            if(gridView1.DataRowCount==0)
                bRC_TAGSTableAdapter.FillObtenerTag(dataSetTags.BRC_TAGS, "-----");


            if (User_id != "BREYES")
            {

                ListaFechasPorRecibirPT(Server, DB, User_id, Pass, lst_tipo_plantilla.EditValue.ToString(), ref ControlError);



                if (ControlError != "Completado")
                {


                    MessageBox.Show("Ocurrio un error al recibir el producto:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                Globalfecha = Convert.ToDateTime(lst_fecha.EditValue.ToString());
                GlobalIdTipoPlantilla = Convert.ToString(lst_tipo_plantilla.EditValue);

                GlobalIdCalculo = consulta.ejecutaEscalar("SELECT ID_CALCULO FROM " + DB + ".DBO.PRD_CALCULO_ENCABEZADO WHERE ID_TIPO_PLANTILLA='" + GlobalIdTipoPlantilla + "' AND FECHA='" + Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString() + "'", ref ControlError);
            }

        }

        private void lst_tipo_plantilla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
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
                txt_tipo_plantilla.ReadOnly = true;
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
                txt_usuario_creo.ReadOnly = true;
                lst_articulo.Enabled = true;
                lst_fecha_creacion.ReadOnly = true;
                lst_fecha_transaccion.Enabled = true;
                lst_operador.Enabled = true;
                lst_maquina.Enabled = true;
                lst_op.Enabled = true;
                lst_turno.Enabled = true;
                lst_unidad1.Enabled = true;
                lst_unidad2.Enabled = true;
                chk_activo.ReadOnly = true;

             

                //Evento del boton nuevo
                //Verifica si se esta expandiendo el detalle del grid por medio de la variable DetalleExpandido 
                //Agrega un nuevo registro de los programas
                bRCTAGSBindingSource.AddNew();
                lst_fecha_transaccion.EditValue = lst_fecha.EditValue;
                txt_usuario_creo.EditValue = User_id;
                txt_tipo_plantilla.EditValue = lst_tipo_plantilla.EditValue.ToString();

                FechaString = consulta.ejecutaEscalar("select CONVERT(nvarchar(30), GETDATE(), 120) ", ref ErrorSql);
                
                FechaActual = Convert.ToDateTime(FechaString);

                lst_fecha_creacion.EditValue = FechaActual;
                chk_activo.EditValue = "Y";
                barButtonItem6.Enabled = true;
                barButtonItem17.Enabled = false;
                barButtonItem15.Enabled = false;
               
                txt_tag.EditValue = "-";
                lst_turno.Focus();
                lst_turno.EditValue = "A";
                //lst_fecha_transaccion.Focus();
                lst_unidad1.EditValue = "0";
                lst_unidad2.EditValue = "0";


                if (string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                {
                    lst_unidad1.EditValue = "0";

                }

                if ((lst_tipo_plantilla.EditValue.ToString() == "EXT-PTL" 
                    || lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" 
                    || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBBAB" 
                    || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBTOR" 
                    || lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER"
                    || lst_tipo_plantilla.EditValue.ToString() == "CONFSAC-04"
                    || lst_tipo_plantilla.EditValue.ToString() == "DENFARDA" 
                    /*|| lst_tipo_plantilla.EditValue.ToString() == "CONFJMB-05"*/
                    || lst_tipo_plantilla.EditValue.ToString() == "DENFJUMBO"
                    || lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN"
                    || lst_tipo_plantilla.EditValue.ToString() == "TELMACEN"
                    ) 
                    && lst_unidad1.EditValue.ToString() == "0")
                        lst_unidad1.EditValue = "1";


                EstaEditando = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error, favor contactarse con el administrador: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lst_op_EditValueChanged(object sender, EventArgs e)
        {
            try {


                if (!string.IsNullOrEmpty(Convert.ToString(lst_op.EditValue)) 
                    
                    &&
                    
                    !string.IsNullOrEmpty(Convert.ToString(lst_articulo.EditValue))) {

                    string ControlError = "";
                    conexion consulta = new conexion();
                    consulta.SetDB(DB);
                    consulta.SetUsuario(User_id);
                    consulta.SetPassword(Pass);
                    consulta.SetServer(Server);
                    string ArticuloDeOp = "";
                    string Articulo = lst_articulo.EditValue.ToString();
                    ArticuloDeOp = consulta.ejecutaEscalar("SELECT PART_ID FROM " + SMVISUAL + ".DBO.WORK_ORDER WITH(NOLOCK) WHERE BASE_ID='" + lst_op.EditValue.ToString() + "'", ref ControlError);

                    if (Articulo != ArticuloDeOp) {

                        MessageBox.Show("Usted debe de selecionar una Orden de produccion que corresponda al articulo seleccionado, favor cambiar la Orden o el Articulo ya selecionados.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        lst_op.EditValue = null;
                    }

                
                }

                if (!string.IsNullOrEmpty(Convert.ToString(lst_op.EditValue.ToString())) &&
                    string.IsNullOrEmpty(Convert.ToString(lst_articulo.EditValue.ToString()))
                    ) {

                        string ControlError = "";
                        conexion consulta = new conexion();
                        consulta.SetDB(DB);
                        consulta.SetUsuario(User_id);
                        consulta.SetPassword(Pass);
                        consulta.SetServer(Server);
                        string ArticuloDeOp = "";
                        string Articulo = lst_articulo.EditValue.ToString();
                        ArticuloDeOp = consulta.ejecutaEscalar("SELECT PART_ID FROM " + SMVISUAL + ".DBO.WORK_ORDER WITH(NOLOCK) WHERE BASE_ID='" + lst_op.EditValue.ToString() + "'", ref ControlError);

                        lst_articulo.EditValue = ArticuloDeOp;
                
                }


                


            }catch(Exception ex){

                MessageBox.Show("Ocurrio un error favor contactar con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             try {

                     CalcularFormulas();
                     bool EsNuevo = false;
                     string IdMaquinSeleccionada = "";
                     string ExisteCorrelativoMaquina = "";
                     string ControlError = "";
                     conexion consulta = new conexion();
                     consulta.SetDB(DB);
                     consulta.SetUsuario(User_id);
                     consulta.SetPassword(Pass);
                     consulta.SetServer(Server);
                     string QueryTemp = "";

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

                     string Correlativo = "";

                     if (txt_tag.EditValue.ToString() == "-")
                     {

                         if (!string.IsNullOrEmpty(Convert.ToString(lst_maquina.EditValue)))
                             IdMaquinSeleccionada = lst_maquina.EditValue.ToString();
                         else
                             IdMaquinSeleccionada = "";



                         ExisteCorrelativoMaquina = consulta.ejecutaEscalar("SELECT COUNT(ID) FROM " + DB + ".DBO.BRC_CORRELATIVOS WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y' AND ID_MAQUINA ='" + IdMaquinSeleccionada + "'", ref ControlError);

                         if (Convert.ToInt32(ExisteCorrelativoMaquina) > 0)
                             Correlativo = consulta.ejecutaEscalar("SELECT PREFIJO+RIGHT(CEROS + Ltrim(Rtrim(CORRELATIVO)),CANTIDAD_CEROS)+SUFIJO FROM " + DB + ".DBO.BRC_CORRELATIVOS WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y' AND ID_MAQUINA='" + IdMaquinSeleccionada + "'", ref ControlError);
                         if (Convert.ToInt32(ExisteCorrelativoMaquina) == 0)
                             Correlativo = consulta.ejecutaEscalar("SELECT PREFIJO+RIGHT(CEROS + Ltrim(Rtrim(CORRELATIVO)),CANTIDAD_CEROS)+SUFIJO  FROM " + DB + ".DBO.BRC_CORRELATIVOS WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y' AND ID_MAQUINA IS NULL", ref ControlError);

                         
                         if (Correlativo != "")
                         {

                             ControlError = "";

                             if (Convert.ToInt32(ExisteCorrelativoMaquina) > 0)
                                 consulta.insertar("UPDATE " + DB + ".DBO.BRC_CORRELATIVOS SET CORRELATIVO=CORRELATIVO+1 WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y'  AND ID_MAQUINA='" + IdMaquinSeleccionada + "'", ref ControlError);


                             if (Convert.ToInt32(ExisteCorrelativoMaquina) == 0)
                                 consulta.insertar("UPDATE " + DB + ".DBO.BRC_CORRELATIVOS SET CORRELATIVO=CORRELATIVO+1 WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y'  AND ID_MAQUINA IS NULL", ref ControlError);

                             if (ControlError == "Completado")
                             {
                                 txt_tag.EditValue = Correlativo;
                                 brc_tags.Text = Correlativo;
                                 EsNuevo = true;

                             }
                             else
                             {
                              //   MessageBox.Show("Ocurrio un error favor contactar a su administrador:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             //    MessageBox.Show("Ocurrio un error favor generar nuevamente el tag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                 if (Convert.ToInt32(ExisteCorrelativoMaquina) > 0)
                                     consulta.insertar("UPDATE " + DB + ".DBO.BRC_CORRELATIVOS SET CORRELATIVO=CORRELATIVO-1 WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y'  AND ID_MAQUINA='" + IdMaquinSeleccionada + "'", ref ControlError);


                                 if (Convert.ToInt32(ExisteCorrelativoMaquina) == 0)
                                     consulta.insertar("UPDATE " + DB + ".DBO.BRC_CORRELATIVOS SET CORRELATIVO=CORRELATIVO-1 WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y'  AND ID_MAQUINA IS NULL", ref ControlError);

                                 MessageBox.Show("Ocurrio un error, favor generar nuevamente el tag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 return;
                             }
                         }
                         else
                         {
                             MessageBox.Show("La plantilla " + lst_tipo_plantilla.EditValue.ToString() + " no tiene configurado un correlativo, favor contactar al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                         }
                     }

                     if (txt_tag.EditValue.ToString() == "-")
                     {
                         MessageBox.Show("Debe de ingresar bien un correlativo antes de guardar, si no puede hacerlo , presione el boton cancelar he intente ingresarlo nuevametne.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                     lst_articulo.Enabled = false;
                     lst_fecha_transaccion.Enabled = false;
                     lst_maquina.Enabled = false;
                     lst_operador.Enabled = false;
                     lst_op.Enabled = false;
                     lst_turno.Enabled = false;
                     lst_unidad1.Enabled = false;
                     lst_unidad2.Enabled = false;
                     chk_activo.Enabled = false;

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



                     this.Validate();
                     bRCTAGSBindingSource.EndEdit();

                     bRC_TAGSTableAdapter.Update(dataSetTags.BRC_TAGS);

                     barButtonItem6.Enabled = false;
                     EstaEditando = false;

                     //consulta.insertar("UPDATE " + DB + ".DBO.BRC_TAGS SET ID_INFO_MAQUINA= WHERE ID_TAGS='" + Correlativo + "'", ref ControlError);
                     

                     if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)) 
                         && !string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue)) 
                         && AccesoATodo == false)
                     {
                         int FilaEditada = 0;
                         FilaEditada = gridView1.FocusedRowHandle;
                         //this.bRC_TAGSTableAdapter.FillObtenerTagsTipoPlantilla(this.dataSetTags.BRC_TAGS, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "N");
                         this.sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter.FillObtenerTags(dataSetEncabezado.SP_BRC_OBTENER_TAGS_TIPO_PLANTILLA, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "N");
                         if (EsNuevo == true)
                         {
                             gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;

                         }
                         else
                         {
                             gridView1.FocusedRowHandle = FilaEditada;
                         }
                     }


                     if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue))
                         && !string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue)) 
                         && AccesoATodo == true)
                     {
                         //this.bRC_TAGSTableAdapter.FillObtenerTagsTipoPlantilla(this.dataSetTags.BRC_TAGS, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "Y");
                         int FilaEditada = 0;
                         FilaEditada = gridView1.FocusedRowHandle;
                         this.sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter.FillObtenerTags(dataSetEncabezado.SP_BRC_OBTENER_TAGS_TIPO_PLANTILLA, lst_tipo_plantilla.EditValue.ToString(), Convert.ToDateTime(lst_fecha.EditValue), User_id, "Y");
                         if (EsNuevo == true)
                         {
                             gridView1.FocusedRowHandle = gridView1.DataRowCount - 1;

                         }
                         else
                         {
                             gridView1.FocusedRowHandle = FilaEditada;
                         }
                     }


                     string CuentaDetalleOperador="";
                        CuentaDetalleOperador=consulta.ejecutaEscalar("SELECT COUNT(ID_OPERADOR) FROM "+DB+".DBO.BRC_DETALLE_OPERADOR WHERE ID_TAGS='"+txt_tag.EditValue.ToString()+"'",ref ControlError);

                        if(string.IsNullOrEmpty(CuentaDetalleOperador))
                            CuentaDetalleOperador="0";


                     

                     if(Convert.ToInt32(CuentaDetalleOperador)==0)
                     consulta.insertar("INSERT INTO "+DB+".DBO.BRC_DETALLE_OPERADOR(ID_TAGS,ID_OPERADOR) SELECT '"+txt_tag.EditValue.ToString()+"',ID_OPERADOR  FROM "+DB+".DBO.PRD_OPERADOR_MAQUINA WHERE ID_MAQUINA='"+lst_maquina.EditValue.ToString()+"' AND TURNO='"+lst_turno.EditValue.ToString()+"' AND ID_OPERADOR NOT IN ( SELECT ID_OPERADOR FROM "+DB+".DBO.BRC_TAGS AS BT WHERE BT.ID_TAGS='"+txt_tag.EditValue.ToString()+"'  ) ",ref ControlError);


                     string BitIdTag = "";
                     string BitCodArticulo = "";
                     string BitFechaTransaccion = "";
                     string BitTurno = "";
                     string BitIdTipoPlantilla = "";
                     string BitIdMaquina = "";
                     string BitOp = "";
                     string BitUnidad1 = "";
                     string BitUnidad2 = "";
                     string BitUser1 = "";
                     string BitUser2 = "";
                     string BitUser3 = "";
                     string BitUser4 = "";
                     string BitUser5 = "";
                     string BitUser6 = "";
                     string BitUser7 = "";
                     string BitUser8 = "";
                     string BitUser9 = "";
                     string BitUser10 = "";
                     string BitActivo = "";
                     string BitIdOperador = "";


                     BitIdTag = Convert.ToString(txt_tag.EditValue);
                     BitCodArticulo = Convert.ToString(lst_articulo.EditValue);
                     BitFechaTransaccion = Convert.ToString(lst_fecha.EditValue);
                     BitTurno = Convert.ToString(lst_turno.EditValue);
                     BitIdTipoPlantilla = Convert.ToString(lst_tipo_plantilla.EditValue);
                     BitIdMaquina = Convert.ToString(lst_maquina.EditValue);
                     BitOp = Convert.ToString(lst_op.EditValue);
                     BitUnidad1 = Convert.ToString(lst_unidad1.EditValue);
                     BitUnidad2 = Convert.ToString(lst_unidad2.EditValue);

                     BitUser1 = Convert.ToString(txt_user1.EditValue);
                     BitUser2 = Convert.ToString(txt_user2.EditValue);
                     BitUser3 = Convert.ToString(txt_user3.EditValue);
                     BitUser4 = Convert.ToString(txt_user4.EditValue);
                     BitUser5 = Convert.ToString(txt_user5.EditValue);
                     BitUser6 = Convert.ToString(txt_user6.EditValue);
                     BitUser7 = Convert.ToString(txt_user7.EditValue);
                     BitUser8 = Convert.ToString(txt_user8.EditValue);
                     BitUser9 = Convert.ToString(txt_user9.EditValue);
                     BitUser10 = Convert.ToString(txt_user10.EditValue);


                     if (string.IsNullOrEmpty(BitIdTag))
                         BitIdTag = "";

                     if (string.IsNullOrEmpty(BitCodArticulo))
                         BitCodArticulo = "";

                     if (string.IsNullOrEmpty(BitFechaTransaccion))
                         BitFechaTransaccion = "";

                     if (string.IsNullOrEmpty(BitTurno))
                         BitTurno = "";

                     if (string.IsNullOrEmpty(BitIdTipoPlantilla))
                         BitIdTipoPlantilla = "";

                     if (string.IsNullOrEmpty(BitIdMaquina))
                         BitIdMaquina = "";

                     if (string.IsNullOrEmpty(BitOp))
                         BitOp = "";

                     if (string.IsNullOrEmpty(BitUnidad1))
                         BitUnidad1 = "0";

                    if (string.IsNullOrEmpty(BitUnidad2))
                         BitUnidad2 = "0";

                    if (string.IsNullOrEmpty(BitUser1))
                        BitUser1 = "";

                    if (string.IsNullOrEmpty(BitUser2))
                        BitUser2 = "";

                    if (string.IsNullOrEmpty(BitUser3))
                        BitUser3 = "";

                    if (string.IsNullOrEmpty(BitUser4))
                        BitUser4 = "";

                    if (string.IsNullOrEmpty(BitUser5))
                        BitUser5 = "";

                    if (string.IsNullOrEmpty(BitUser6))
                        BitUser6 = "";

                    if (string.IsNullOrEmpty(BitUser7))
                        BitUser7 = "";

                    if (string.IsNullOrEmpty(BitUser8))
                        BitUser8 = "";

                    if (string.IsNullOrEmpty(BitUser9))
                        BitUser9 = "";

                    if (string.IsNullOrEmpty(BitUser10))
                        BitUser10 = "";


                    if (EstadEditandoAuditoria == true)
                    {
                    
                     
                        QueryTemp = " INSERT INTO " + DB + ".DBO.BRC_BIT_AUDIT_REIMPRESION(FECHA,USER_ID,ID_TAGS,FECHA_TRANSACCION, ";
                        QueryTemp = QueryTemp + " TURNO,ID_TIPO_PLANTILLA,ID_MAQUINA,OP,COD_ARTICULO,UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10, ";
                        QueryTemp = QueryTemp + " ACTIVO,ID_OPERADOR) ";
                        QueryTemp = QueryTemp + " VALUES(GETDATE(),'" + User_id + "','" + BitIdTag + "','" + BitFechaTransaccion + "','" + BitTurno + "','" + BitIdTipoPlantilla + "','" + BitIdMaquina + "','" + BitOp + "','" + BitCodArticulo + "'," + BitUnidad1 + "," + BitUnidad2 + ",'" + BitUser1 + "','" + BitUser2 + "','" + BitUser3 + "','" + BitUser4 + "','" + BitUser5 + "','" + BitUser6 + "','" + BitUser7 + "','" + BitUser8 + "','" + BitUser9 + "','" + BitUser10 + "','" + BitActivo + "','" + BitIdOperador + "') ";

                        consulta.insertar(QueryTemp, ref ControlError);
                    
                    }


                     EstadEditandoAuditoria = false;
             }
             catch (Exception ex)
             {

                 MessageBox.Show("Ocurrio un error favor contactar con su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
        }

        private void txt_tag_EditValueChanged(object sender, EventArgs e)
        {
            brc_tags.Text = txt_tag.EditValue.ToString();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                EstadEditandoAuditoria = true;
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                string ExisteDespacho = "";
                string ExisteReciboPT = "";

                ExisteDespacho = consulta.ejecutaEscalar("SELECT COUNT(ID_ESCANEO) FROM "+DB+".DBO.PRD_DETALLE_ESCANEO_REQ WHERE ID_TAGS='"+ txt_tag.EditValue.ToString() +"' ",ref ControlError);

                if (string.IsNullOrEmpty(ExisteDespacho))
                    ExisteDespacho = "0";


                if (Convert.ToInt32(ExisteDespacho) > 0) {
                    MessageBox.Show("!El tag que esta tratando de modificar y esta despachado, ya no se puede modificar.!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                
                }

                ExisteReciboPT = consulta.ejecutaEscalar(" SELECT COUNT(PRP.ID_RECIBO_PT) FROM " + DB + ".DBO.BRC_TAGS AS BT, " + DB + ".DBO.PRD_RECIBO_PT AS PRP  WHERE BT.ID_TAGS='" + txt_tag.EditValue.ToString() + "' AND BT.FECHA_TRANSACCION=PRP.FECHA AND BT.ID_TIPO_PLANTILLA=PRP.ID_TIPO_PLANTILLA AND BT.OP=PRP.OP AND BT.COD_ARTICULO=PRP.CODIGO_ARTICULO AND (PRP.ESTADO IS NOT NULL OR PRP.ESTADO_TB IS NOT NULL) ", ref ControlError);

                if (string.IsNullOrEmpty(ExisteReciboPT))
                    ExisteReciboPT = "0";

                if (Convert.ToInt32(ExisteReciboPT) > 0) {
                    MessageBox.Show("!El tag que esta tratando de modificar ya ha sido procesado en la mano de obra, no se puede modificar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }


                barButtonItem6.Enabled = true;
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
                lst_articulo.Enabled = true;
                lst_fecha_transaccion.Enabled = true;
                lst_maquina.Enabled = true;
                lst_operador.Enabled = true;
                lst_op.Enabled = true;
                lst_turno.Enabled = true;
                lst_unidad1.Enabled = true;
                lst_unidad2.Enabled = true;
                chk_activo.Enabled = true;
                chk_activo.ReadOnly = false;
                EstaEditando = true;
                gridView1.CancelUpdateCurrentRow();
                bRCTAGSBindingSource.CancelEdit();
                bRCTAGSBindingSource.ResetCurrentItem();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error favor contactar con su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
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
            lst_articulo.Enabled = false;
            lst_fecha_transaccion.Enabled = false;
            lst_maquina.Enabled = false;
            lst_operador.Enabled = false;
            lst_op.Enabled = false;
            lst_turno.Enabled = false;
            lst_unidad1.Enabled = false;
            lst_unidad2.Enabled = false;
            chk_activo.Enabled = false;
   
          

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                string FilaSeleccionado = gridView1.FocusedRowHandle.ToString();
                bRCTAGSBindingSource.CancelEdit();

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
                lst_articulo.Enabled = false;
                lst_fecha_transaccion.Enabled = false;
                lst_maquina.Enabled = false;
                lst_operador.Enabled = false;
                lst_op.Enabled = false;
                lst_turno.Enabled = false;
                lst_unidad1.Enabled = false;
                lst_unidad2.Enabled = false;
                chk_activo.Enabled = false;
                barButtonItem6.Enabled = false;
                EstaEditando = false;

                barButtonItem11.PerformClick();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error favor contactar con su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string Unidad1 = "";
            string Unidad2 = "";
            string YaFueImpreso = "";

            if (txt_tag.EditValue.ToString() == "-")
            {
                MessageBox.Show("Favor guardar antes el tag y despues imprimirlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                Unidad1 = lst_unidad1.EditValue.ToString();
            else
                Unidad1 = "0";


            if (!string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                Unidad2 = lst_unidad2.EditValue.ToString();
            else
                Unidad2 = "0";

            if (Convert.ToDecimal(Unidad1) <= 0)
            {
                MessageBox.Show("La unidad uno no tienen algun valor, eso quiere decir que el tag fue guardado incorrectamente, genere un nuevo tag y vuelva a imprimirlo. Not: Reportar el tag mal guardado al secretario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Convert.ToDecimal(Unidad2) <= 0)
            {
                MessageBox.Show("La unidad dos no tienen algun valor, eso quiere decir que el tag fue guardado incorrectamente, genere un nuevo tag y vuelva a imprimirlo. Nota: Reportar el tag mal guardado al secretario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            string ControlError = "";
            conexion consulta = new conexion();
            consulta.SetDB(DB);
            consulta.SetUsuario(User_id);
            consulta.SetPassword(Pass);
            consulta.SetServer(Server);

            YaFueImpreso = consulta.ejecutaEscalar("SELECT COUNT(ID_TAGS_RECIBO) FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + txt_tag.EditValue.ToString() + "'", ref ControlError);

            if (string.IsNullOrEmpty(YaFueImpreso))
                YaFueImpreso = "0";

            if (Convert.ToInt32(YaFueImpreso) > 0)
            {

                DialogResult Resultado = MessageBox.Show("   ¿ Este tag ya fue impreso, desea volver a imprimirlo ?   ", "Tag ya impreso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Cancel)
                {
                    return;
                }

            }


            string NoCopiasTemp = "";
            int NoCopias = 0;
            NoCopiasTemp = txt_no_copias.EditValue.ToString();
            if (string.IsNullOrEmpty(NoCopiasTemp))
            {
                NoCopiasTemp = "1";
            }
            if (NoCopiasTemp == "0")
                NoCopiasTemp = "1";
            try
            {
                NoCopias = Convert.ToInt32(NoCopiasTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error formato de numero no correcto:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            string connectionString = @"XpoProvider=MSSqlServer;Data Source=" + Server + ";User ID=" + User_id + ";Password=" + Pass + ";Initial Catalog=" + DB + ";Persist Security Info=true;";
            CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);

            //(
            //      lst_tipo_plantilla.EditValue.ToString() != "CT-LINER" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "CT-ULTRA" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "DCONFSAC" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "DCONFSACJ" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "DEXTLAM" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "DKIANGJ" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "DLINER" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "DXLINER" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "EXT-LINER" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "EXT-TUBLAM" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "KIANG-TJ" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "TETUB" && User_id != "CRAFAEL" &&
            //      lst_tipo_plantilla.EditValue.ToString() != "TJUMBO" && User_id != "CRAFAEL" &&
            //       lst_tipo_plantilla.EditValue.ToString() != "UNI-BTELA" && User_id != "CRAFAEL" 
            //      )


            //ds.ConnectionParameters
            //IMPRESION EN INGLES
            ////if (lst_tipo_plantilla.EditValue.ToString() != "TSULZ" &&
            ////    lst_tipo_plantilla.EditValue.ToString() != "URD-SULZ" &&
            ////    lst_tipo_plantilla.EditValue.ToString() != "CONFSAC-04" &&
            ////    lst_tipo_plantilla.EditValue.ToString() != "DENFARDA" &&
            ////    lst_tipo_plantilla.EditValue.ToString() != "MPRM-01" &&
            ////    (lst_tipo_plantilla.EditValue.ToString() != "DCONFSAC" && User_id != "DOPCONFS") &&
            ////    (lst_tipo_plantilla.EditValue.ToString() != "DLINER" && User_id != "DOPLINER") &&

            ////    (User_id != "CRAFAEL" && User_id != "FBARRERA")

            ////    )
            ////{

            ////    rpt_ImprTags NuevoReporte = new rpt_ImprTags();
            ////    NuevoReporte.ShowPrintMarginsWarning = false;

            ////    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
            ////    ds.ConnectionParameters = connectionParameters;
            ////    NuevoReporte.DataSource = ds;
            ////    NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
            ////    NuevoReporte.RequestParameters = false;


                //ZDesigner GK420t
                //PrinterBarcodeZebra

                //if (lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" || lst_tipo_plantilla.EditValue.ToString() == "TETUB")
                //{
                //  using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {
                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");

                //    }
                //}


            //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
            //    {
            //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
            //        printTool.Print("PrinterBarcodeZebra");

            //    }
            //}


            //if (
            //    (lst_tipo_plantilla.EditValue.ToString() == "DCONFSAC" && (User_id != "DOPCONFS" && User_id != "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "DLINER" && (User_id != "DOPLINER" && User_id != "FBARRERA"))
            //    )
            string Margen = "";

            if (!string.IsNullOrEmpty(Convert.ToString(txt_user8.EditValue)))
            {
                Margen = txt_user8.EditValue.ToString();
            }
            else {
                Margen = "0.00";
            }

            if (lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN" && Math.Abs(Convert.ToDecimal(Margen)) > 1)
            {

                rpt_ImprTagsAudit NuevoReporte = new rpt_ImprTagsAudit();
                //    XtraReport1 NuevoReporte = new XtraReport1();
                NuevoReporte.ShowPrintMarginsWarning = false;

                SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                ds.ConnectionParameters = connectionParameters;
                NuevoReporte.DataSource = ds;
                NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
                NuevoReporte.RequestParameters = false;

                using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                {
                    printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                    printTool.Print("PrinterBarcodeZebra");

                }
            }
            if (User_id != "AUDITOR" && lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN" && Math.Abs(Convert.ToDecimal(Margen)) <= 1)
            {
                rpt_ImprTags NuevoReporte = new rpt_ImprTags();
                //    XtraReport1 NuevoReporte = new XtraReport1();
                NuevoReporte.ShowPrintMarginsWarning = false;

                SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                ds.ConnectionParameters = connectionParameters;
                NuevoReporte.DataSource = ds;
                NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
                NuevoReporte.RequestParameters = false;

                using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                {
                    printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                    printTool.Print("PrinterBarcodeZebra");

                }
            
            }

            if (User_id == "AUDITOR" && lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN" && Math.Abs(Convert.ToDecimal(Margen)) <= 1)
            {
                rpt_ReImprTags NuevoReporte = new rpt_ReImprTags();
                //    XtraReport1 NuevoReporte = new XtraReport1();
                NuevoReporte.ShowPrintMarginsWarning = false;

                SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                ds.ConnectionParameters = connectionParameters;
                NuevoReporte.DataSource = ds;
                NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
                NuevoReporte.RequestParameters = false;

                using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                {
                    printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                    printTool.Print("PrinterBarcodeZebra");

                }

            }
            if (lst_tipo_plantilla.EditValue.ToString() == "TELMACEN" ||
                lst_tipo_plantilla.EditValue.ToString() == "COMP01-MAC" ||
                lst_tipo_plantilla.EditValue.ToString() == "COMP02-MAC" ||
                    lst_tipo_plantilla.EditValue.ToString() == "COMP03-MAC" ||
                        lst_tipo_plantilla.EditValue.ToString() == "COMP04-MAC"
                
                )
            {
                rpt_ImprTagsTelas NuevoReporte = new rpt_ImprTagsTelas();
                //    XtraReport1 NuevoReporte = new XtraReport1();
                NuevoReporte.ShowPrintMarginsWarning = false;

                SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                ds.ConnectionParameters = connectionParameters;
                NuevoReporte.DataSource = ds;
                NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
                NuevoReporte.RequestParameters = false;

                using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                {
                    printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                    printTool.Print("PrinterBarcodeZebra");

                }

            }
            //if (
            //    (lst_tipo_plantilla.EditValue.ToString() == "MPRM-01") ||
            //    (lst_tipo_plantilla.EditValue.ToString() == "DCONFSAC" && User_id == "DOPCONFS") ||
            //    (lst_tipo_plantilla.EditValue.ToString() == "DLINER" && User_id == "DOPLINER") ||

            //     (lst_tipo_plantilla.EditValue.ToString() == "CT-LINER" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "CT-ULTRA" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) |
            //     (lst_tipo_plantilla.EditValue.ToString() == "DCONFSAC" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "DCONFSACJ" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "DEXTLAM" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "DKIANGJ" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "DLINER" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "DXLINER" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) |
            //     (lst_tipo_plantilla.EditValue.ToString() == "KIANG-TJ" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "TETUB" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "TJUMBO" && (User_id == "CRAFAEL" || User_id == "FBARRERA")) ||
            //     (lst_tipo_plantilla.EditValue.ToString() == "UNI-BTELA" && (User_id == "CRAFAEL" || User_id == "FBARRERA"))

            //    )
         //   {

               //rpt_ImprTagsNor4X6 NuevoReporte = new rpt_ImprTagsNor4X6();
               // NuevoReporte.ShowPrintMarginsWarning = false;

               // SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
               // ds.ConnectionParameters = connectionParameters;
               // NuevoReporte.DataSource = ds;
               // NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
               // NuevoReporte.RequestParameters = false;


                //ZDesigner GK420t
                //PrinterBarcodeZebra

                //if (lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" || lst_tipo_plantilla.EditValue.ToString() == "TETUB")
                //{
                //  using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {
                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");

                //    }
                //}


                //using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //{
                //    printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //    printTool.Print("PrinterBarcodeZebra");

                //}
       //     }

            //if (lst_tipo_plantilla.EditValue.ToString() == "CONFSAC-04"
            //    || lst_tipo_plantilla.EditValue.ToString() == "DENFARDA")
            //{

            //    rpt_ImprTags4X6 NuevoReporte = new rpt_ImprTags4X6();
            //    NuevoReporte.ShowPrintMarginsWarning = false;

            //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
            //    ds.ConnectionParameters = connectionParameters;
            //    NuevoReporte.DataSource = ds;
            //    NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
            //    NuevoReporte.RequestParameters = false;


                //ZDesigner GK420t
                //PrinterBarcodeZebra

                //if (lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" || lst_tipo_plantilla.EditValue.ToString() == "TETUB")
                //{
                //  using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {
                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");

                //    }
                //}


            //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
            //    {
            //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
            //        printTool.Print("PrinterBarcodeZebra");

            //    }
            //}


            //if (lst_tipo_plantilla.EditValue.ToString() == "TSULZ")
            //{

            //    rpt_ImprTagsEnglSulz NuevoReporte = new rpt_ImprTagsEnglSulz();
            //    NuevoReporte.ShowPrintMarginsWarning = false;

            //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
            //    ds.ConnectionParameters = connectionParameters;
            //    NuevoReporte.DataSource = ds;
            //    NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
            //    NuevoReporte.RequestParameters = false;


                //ZDesigner GK420t
                //PrinterBarcodeZebra

                //if (lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" || lst_tipo_plantilla.EditValue.ToString() == "TETUB")
                //{
                //  using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {
                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");

                //    }
                //}


            //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
            //    {
            //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
            //        printTool.Print("PrinterBarcodeZebra");

            //    }
            //}
            //if (lst_tipo_plantilla.EditValue.ToString() == "URD-SULZ")
            //{

            //    rpt_ImprTagsUrdi NuevoReporte = new rpt_ImprTagsUrdi();
            //    NuevoReporte.ShowPrintMarginsWarning = false;

            //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
            //    ds.ConnectionParameters = connectionParameters;
            //    NuevoReporte.DataSource = ds;
            //    NuevoReporte.Parameters["IdTag"].Value = txt_tag.EditValue.ToString();
            //    NuevoReporte.RequestParameters = false;


                //ZDesigner GK420t
                //PrinterBarcodeZebra

                //if (lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" || lst_tipo_plantilla.EditValue.ToString() == "TETUB")
                //{
                //  using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {
                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");

                //    }
                //}


            //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
            //    {
            //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
            //        printTool.Print("PrinterBarcodeZebra");

            //    }
            //}




            string Revisado = "";

            Revisado = consulta.ejecutaEscalar("SELECT ISNULL(REVISADO,'N') FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + txt_tag.EditValue.ToString() + "'", ref ControlError);


            if (string.IsNullOrEmpty(Revisado) || Revisado == "N")
            {

                if (User_id != "BREYES")
                {


                    if (gridView1.DataRowCount <= 1)
                    {
                        ListaFechasPorRecibirPT(Server, DB, User_id, Pass, lst_tipo_plantilla.EditValue.ToString(), ref ControlError);
                        Globalfecha = Convert.ToDateTime(lst_fecha.EditValue.ToString());
                        GlobalIdTipoPlantilla = Convert.ToString(lst_tipo_plantilla.EditValue);

                        GlobalIdCalculo = consulta.ejecutaEscalar("SELECT ID_CALCULO FROM " + DB + ".DBO.PRD_CALCULO_ENCABEZADO WHERE ID_TIPO_PLANTILLA='" + GlobalIdTipoPlantilla + "' AND FECHA='" + Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString() + "'", ref ControlError);

                        if (ControlError != "Completado")
                        {
                            MessageBox.Show("Ocurrio un error al recibo de producto terminado:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    ObtenerProductosARecibir(Server, DB, User_id, Pass, GlobalIdTipoPlantilla, GlobalIdCalculo, Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString(), ref ControlError);
                    if (ControlError != "Completado")
                    {

                        MessageBox.Show("Ocurriou error al recibo producto terminado:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ControlError = BuscarTag(Server, DB, User_id, Pass, GlobalIdTipoPlantilla, GlobalIdCalculo, Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString(), txt_tag.EditValue.ToString());

                    if (ControlError != "Completado")
                    {
                        MessageBox.Show("Ocurriou error al recibo producto terminado:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            


            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var rpt = new rpt_ImprTags();
            var designer = new ReportDesignTool(rpt);
            designer.ShowRibbonDesignerDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (lst_tipo_plantilla.EditValue.ToString() != "MPRM-01"
                    && lst_tipo_plantilla.EditValue.ToString() != "DKIANGJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "DCONFSACJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "DPTTERM-02"
                    && lst_tipo_plantilla.EditValue.ToString() != "CT-LINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "DCONFSAC"
                    && lst_tipo_plantilla.EditValue.ToString() != "DLINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "DXLINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "DENFARDA"
                    && lst_tipo_plantilla.EditValue.ToString() != "DENFJUMBO"

                    && lst_tipo_plantilla.EditValue.ToString() != "CT-ULTRA"
                    && lst_tipo_plantilla.EditValue.ToString() != "DCONFSACJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "DEXTLAM"
                    && lst_tipo_plantilla.EditValue.ToString() != "DKIANGJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "EXT-LINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "EXT-TUBLAM"
                    && lst_tipo_plantilla.EditValue.ToString() != "KIANG-TJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "TETUB"
                    && lst_tipo_plantilla.EditValue.ToString() != "TJUMBO"
                    && lst_tipo_plantilla.EditValue.ToString() != "UNI-BTELA"
                    && lst_tipo_plantilla.EditValue.ToString() != "CONFMACEN"

                    )
                {
                    MessageBox.Show("!!SI NO ES MATERIA PRIMA NO PUEDO IMPRIMIR TAGS CONSECUTIVOS!!. Favor imprimir los tags en el otro boton.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barButtonItem14.Enabled = false;
                    return;

                }

                string NoCopiasTemp = "";
                int NoCopias = 0;
                NoCopiasTemp = txt_no_copias.EditValue.ToString();
                if (string.IsNullOrEmpty(NoCopiasTemp))
                {
                    NoCopiasTemp = "1";
                }

                if (NoCopiasTemp == "0")
                    NoCopiasTemp = "1";

                try
                {
                    NoCopias = Convert.ToInt32(NoCopiasTemp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error formato de numero no correcto:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                string connectionString = @"XpoProvider=MSSqlServer;Data Source=" + Server + ";User ID=" + User_id + ";Password=" + Pass + ";Initial Catalog=" + DB + ";Persist Security Info=true;";
                CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);

                //ds.ConnectionParameters

                //if (lst_tipo_plantilla.EditValue.ToString() == "MPRM-01" ||
                //  (lst_tipo_plantilla.EditValue.ToString() == "CT-LINER" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "CT-ULTRA" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "DCONFSAC" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "DCONFSACJ" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "DKIANGJ" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "DLINER" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "DXLINER" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "KIANG-TJ" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "TETUB" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "TJUMBO" ||
                //  lst_tipo_plantilla.EditValue.ToString() == "UNI-BTELA" &&
                //  (User_id == "CRAFAEL" || User_id == "FBARRERA")

                //  )
                //  )
                //{

                //    rpt_ImprTagsConseNor4X6 NuevoReporte = new rpt_ImprTagsConseNor4X6();
                //    NuevoReporte.ShowPrintMarginsWarning = false;
                //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                //    ds.ConnectionParameters = connectionParameters;
                //    NuevoReporte.DataSource = ds;

                //    NuevoReporte.RequestParameters = false;
                //    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                //    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "ID_TAGS").ToString();
                //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {

                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");
                //    }
                //    return;
                //}

                //if (lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN")
                //{

                //    rpt_ImprTagsConse NuevoReporte = new rpt_ImprTagsConse();
                //    NuevoReporte.ShowPrintMarginsWarning = false;
                //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                //    ds.ConnectionParameters = connectionParameters;
                //    NuevoReporte.DataSource = ds;

                //    NuevoReporte.RequestParameters = false;
                //    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                //    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "ID_TAGS").ToString();
                //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {

                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");
                //    }

                //    return;
                //}

                //if (
                //    lst_tipo_plantilla.EditValue.ToString() != "DENFARDA"
                //    &&
                //    lst_tipo_plantilla.EditValue.ToString() != "DENFJUMBO"
                //    &&
                //    lst_tipo_plantilla.EditValue.ToString() != "MPRM-01"
                //    && 
                //    lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN"
                //                                 )
                //{

                //    rpt_ImprTagsConse NuevoReporte = new rpt_ImprTagsConse();
                //    NuevoReporte.ShowPrintMarginsWarning = false;
                //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                //    ds.ConnectionParameters = connectionParameters;
                //    NuevoReporte.DataSource = ds;

                //    NuevoReporte.RequestParameters = false;
                //    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                //    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "ID_TAGS").ToString();
                //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                //    {

                //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                //        printTool.Print("PrinterBarcodeZebra");
                //    }

                //}



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error:" + ex.Message.ToArray(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CalcularFormulas() {

            string QueryFormulas = "";
            string ExisteFormulaPorUsuario = "";
            string ControlError = "";
            conexion consulta = new conexion();
            consulta.SetDB(DB);
            consulta.SetUsuario(User_id);
            consulta.SetPassword(Pass);
            consulta.SetServer(Server);
            DataSet ds = new DataSet();
            if (EstaEditando == true || EsDevolucion=="Y") {

                ExisteFormulaPorUsuario = consulta.ejecutaEscalar(" SELECT COUNT(ID_TIPO_PLANTILLA) FROM " + DB + ".DBO.BRC_FORMULAS_USR where ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ID_USUARIO='" + User_id + "' ", ref ControlError);
                
                if (string.IsNullOrEmpty(ExisteFormulaPorUsuario))
                    ExisteFormulaPorUsuario = "0";

                if (Convert.ToInt32(ExisteFormulaPorUsuario) > 0)
                {
                    QueryFormulas = "SELECT ORDEN,FORMULA,CAMPO_DEF_USR FROM " + DB + ".DBO.BRC_FORMULAS_USR WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ID_USUARIO='"+User_id+"' ORDER BY ORDEN ASC";

                }
                else {

                    QueryFormulas = "SELECT ORDEN,FORMULA,CAMPO_DEF_USR FROM " + DB + ".DBO.BRC_FORMULAS WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' ORDER BY ORDEN ASC";
                }


                ds = consulta.consultaSelect(QueryFormulas, "DATOS",ref ControlError);
                    
                //ds = consulta.consultaSelect("SELECT ORDEN,FORMULA,CAMPO_DEF_USR FROM " + DB + ".DBO.BRC_FORMULAS WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' ORDER BY ORDEN ASC", "FORMULAS", ref ControlError);
            

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
                    {
                        if (lst_tipo_plantilla.EditValue.ToString() == "TSULZ")
                        {
                                if(!string.IsNullOrEmpty(Resultado))
                                txt_user2.EditValue =Math.Round( Convert.ToDecimal(Resultado),3,MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            txt_user2.EditValue = Resultado;
                        }
                    }

                    if (Campo == "TEXTO_USER_03")
                    {
                        if (lst_tipo_plantilla.EditValue.ToString() == "TSULZ")
                        {
                            if (!string.IsNullOrEmpty(Resultado))
                                txt_user3.EditValue = Math.Round(Convert.ToDecimal(Resultado), 3, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            txt_user3.EditValue = Resultado;
                        }
                        
                        
                    }
                    if (Campo == "TEXTO_USER_04")
                        txt_user4.EditValue = Resultado;

                    if (Campo == "TEXTO_USER_05")
                        txt_user5.EditValue = Resultado;

                    if (Campo == "TEXTO_USER_06")
                        txt_user6.EditValue = Resultado;

                    if (Campo == "TEXTO_USER_07")
                        txt_user7.EditValue = Resultado;

                    if (Campo == "TEXTO_USER_08")
                    {
                        if (GlobalIdTipoPlantilla == "CONFMACEN")
                        {
                            if (!string.IsNullOrEmpty(Resultado))
                                txt_user8.EditValue = Math.Round(Convert.ToDecimal(Resultado), 2).ToString();
                        }
                        else
                        {
                            txt_user8.EditValue = Resultado;
                        }
                    }

                    //if (Campo == "TEXTO_USER_09")
                    //    txt_user9.EditValue = Resultado;


                    if (Campo == "TEXTO_USER_09")
                    {
                        if (GlobalIdTipoPlantilla == "CONFMACEN")
                        {
                            if (!string.IsNullOrEmpty(Resultado))
                                txt_user9.EditValue = Math.Round(Convert.ToDecimal(Resultado), 2).ToString();
                        }
                        else
                        {
                            txt_user9.EditValue = Resultado;
                        }
                    }


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
          
            if(EstaEditando==true)
                if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                    CalcularFormulas();
            
        }

        private void txt_user3_DragOver(object sender, DragEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (EstaEditando == true) {
                MessageBox.Show("Esta tratando de ingresar un nuevo tag y no ha termiando de guardar el anterior, favor guardar el actual y despues ingresar uno nuevo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue))) {
                MessageBox.Show("Debe seleccionar una fecha para poder buscar los registros.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
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
            ArrayList CodigosInformacionMaquina = new ArrayList();
           
            ArrayList CodigosTurnos = new ArrayList();

            ObtenerCodigos LecturaCodigos = new ObtenerCodigos();
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

            if (Respuesta == "OK") {

                CodigoUniversalInfoMaquina = CodigosInformacionMaquina;
                CodigoUniversalTurno = CodigosTurnos;
                
            }

            if (Respuesta == "OK")
            {
                string IdTipoPlantilla = "";
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


                
                DataSet ds = new DataSet();

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

                    TagsNoImpresos = consulta.consultaSelect("SELECT BT.ID_TAGS FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_TAGS_RECIBO_PT AS BTRP ON BT.ID_TAGS=BTRP.TAG WHERE BT.ID_MAQUINA='" + IdMaquinaNoImpresos + "' AND BT.FECHA_TRANSACCION='" + Convert.ToDateTime(lst_fecha.EditValue).Year.ToString() + "-" + Convert.ToDateTime(lst_fecha.EditValue).Month.ToString() + "-" + Convert.ToDateTime(lst_fecha.EditValue).Day.ToString() + "' AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.ACTIVO='Y'	AND BTRP.TAG IS NULL", "DATOS", ref ControlError);

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


                if (Convert.ToString(lst_tipo_plantilla.EditValue) != IdTipoPlantilla)
                {
                    lst_tipo_plantilla.EditValue = IdTipoPlantilla;
                    barButtonItem11.PerformClick();
                    barButtonItem5.PerformClick();
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

                    

                    lst_fecha_transaccion.EditValue = lst_fecha.EditValue;

                    string IdOperadorDefault = "";


                    if (!string.IsNullOrEmpty(IdTipoPlantilla) && !string.IsNullOrEmpty(CodigosTurnos[0].ToString()) && !string.IsNullOrEmpty(IdMaquina))
                        IdOperadorDefault = consulta.ejecutaEscalar("SELECT POM.ID_OPERADOR FROM " + DB + ".DBO.PRD_OPERADOR_MAQUINA AS POM," + DB + ".DBO.PRD_OPERADOR_PUESTO AS POP WHERE POM.ID_MAQUINA='" + IdMaquina + "' AND POM.TURNO='" + CodigosTurnos[0].ToString() + "' AND POM.ID_OPERADOR=POP.ID_OPERADOR AND POP.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND POP.ID_PUESTO IN ( 	SELECT ID_PUESTO FROM " + DB + ".DBO.PRD_PUESTO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND NOMBRE LIKE '%OPER%' ) ", ref ControlError);
                    if (!string.IsNullOrEmpty(IdOperadorDefault))
                        lst_operador.EditValue = IdOperadorDefault;

                    if (lst_tipo_plantilla.EditValue.ToString() == "EXT-PTL" 
                        || lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" 
                        || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBBAB"
                        || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBTOR" 
                        || lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER")
                        lst_unidad1.EditValue = "1";

                    lst_unidad1.Focus();
                    EstaEditando = true;
                    return;
                }
                if (Convert.ToString(lst_tipo_plantilla.EditValue) == IdTipoPlantilla)
                {
                    barButtonItem5.PerformClick();
                    lst_op.EditValue = Op;
                    lst_articulo.EditValue = CodArticulo;
                    lst_maquina.EditValue = IdMaquina;
                    lst_turno.EditValue = CodigosTurnos[0].ToString();

                    if (User1 != "")
                        txt_user1.EditValue = User1;

                    if (User2 != "")
                    {
                        if (lst_tipo_plantilla.EditValue.ToString() == "TSULZ")
                        {
                            if (!string.IsNullOrEmpty(User2))
                            {
                                txt_user2.EditValue = Math.Round(Convert.ToDecimal(User2), 3, MidpointRounding.AwayFromZero);
                            }
                            else {
                                txt_user2.EditValue = User2;
                            }
                        }
                        else
                        {
                            txt_user2.EditValue = User2;

                        }
                        
                    }
                    if (User3 != "")
                    {
                        if (lst_tipo_plantilla.EditValue.ToString() == "TSULZ")
                        {
                            if (!string.IsNullOrEmpty(User3))
                            {
                                txt_user3.EditValue = Math.Round(Convert.ToDecimal(User3), 3, MidpointRounding.AwayFromZero);
                            }
                            else {
                                txt_user3.EditValue = User3;
                            }
                        }
                        else
                        {
                            txt_user3.EditValue = User3;
                        }
                    }
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

                    lst_fecha_transaccion.EditValue = lst_fecha.EditValue;

                    //lst_operador.Focus();
                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue))) {
                        
                        lst_unidad1.EditValue = "0";

                        if (lst_tipo_plantilla.EditValue.ToString() == "EXT-PTL"
                            || lst_tipo_plantilla.EditValue.ToString() == "PTTERM-02" 
                            || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBBAB" 
                            || lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBTOR"
                            || lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER")
                            lst_unidad1.EditValue = "1";
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                    {
                        lst_unidad2.EditValue = "0";

                    
                    }

                    string IdOperadorDefault = "";


                    if (!string.IsNullOrEmpty(IdTipoPlantilla) && !string.IsNullOrEmpty(CodigosTurnos[0].ToString()) && !string.IsNullOrEmpty(IdMaquina))
                        IdOperadorDefault = consulta.ejecutaEscalar("SELECT POM.ID_OPERADOR FROM " + DB + ".DBO.PRD_OPERADOR_MAQUINA AS POM," + DB + ".DBO.PRD_OPERADOR_PUESTO AS POP WHERE POM.ID_MAQUINA='" + IdMaquina + "' AND POM.TURNO='" + CodigosTurnos[0].ToString() + "' AND POM.ID_OPERADOR=POP.ID_OPERADOR AND POP.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND POP.ID_PUESTO IN ( 	SELECT ID_PUESTO FROM " + DB + ".DBO.PRD_PUESTO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND NOMBRE LIKE '%OPER%' ) ", ref ControlError);
                    if (!string.IsNullOrEmpty(IdOperadorDefault))
                        lst_operador.EditValue = IdOperadorDefault;
                    
                    lst_unidad1.Focus();
                    EstaEditando = true;
                    return;
                }

            }


        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {


                //if (MarcaBascula == "BREKNELLSIB100")
                //{
                //    tm_lectura.Enabled = false;
                //    try
                //    {
                //        if (sp1.IsOpen == true)
                //        {
                //            sp1.Close();
                //            sp1.Open();

                //        }


                //    }
                //    catch (Exception Ex)
                //    {


                //    }
                //    Thread.Sleep(2000);


                //    tm_lectura.Enabled = true;

                //    tm_lectura.Interval = 25;
                //}

                if (lst_unidad2.Enabled == true)
                {
                    //if (string.IsNullOrEmpty(lbl_kls.Text.ToString().Replace("Kls:", "").Trim()))
                    //    txt_user1.EditValue = "0";

                    if (!string.IsNullOrEmpty(lbl_kls.Text.ToString().Replace("Kls:", "").Trim()))
                        txt_user1.EditValue = lbl_kls.Text.ToString().Replace("Kls:", "").Trim();

                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad1.EditValue)))
                        lst_unidad1.EditValue = "0";

                    if (string.IsNullOrEmpty(Convert.ToString(lst_unidad2.EditValue)))
                        lst_unidad2.EditValue = "0";

                    if (EstaEditando == true || EsDevolucion=="Y")
                        if (!string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue)))
                        {
                            CalcularFormulas();
                            //this.Validate();
                            //bRCTAGSBindingSource.EndEdit();

                            //bRC_TAGSTableAdapter.Update(dataSetTags);
                        }
                }

            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar al administrador:"+ex.Message.ToString());
            
            }
        }
        public bool IsNumeric(object Expression)
        {

            bool isNum;

            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;

        }
        public string Concatenados = "";
        private void sp1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            try
            {

                
                if (sp1.IsOpen==true)
                {
                    string DatosRecibidos;

                    // INGRESO BASCULA NIC.
                    if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "WEIGHTINDX1")
                    {
                       //DatosRecibidos = sp1.ReadLine();

                       DatosRecibidos = "";
                       try
                       {
                           DatosRecibidos = sp1.ReadLine();
                       }
                       catch (Exception ex)
                       {

                       }
                       if (DatosRecibidos.ToLower().Contains("gross") == true || DatosRecibidos.ToLower().Contains("ww") == true)
                       {

                           Concatenados = Concatenados + DatosRecibidos;
                       }
                          
                        
                    
                    }
                    //**//

                    //if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "TOLEDOIND221" || MarcaBascula == "BREKNELLSIB505" || MarcaBascula == "TOLEDOIND231" || MarcaBascula == "WEIGHTINDX1")
                    //{
                    //    Concatenados = Concatenados + sp1.ReadLine();
                    //}
                //    if (MarcaBascula == "BREKNELLSIB100")
                  
                    //{
                    //    DatosRecibidos = "";
                    //    try
                    //    {
                    //        DatosRecibidos = sp1.ReadLine();
                    //    }
                    //    catch (Exception ex) { 
                        
                    //    }
                    //        if ((DatosRecibidos.ToLower().Contains("Kilos") || DatosRecibidos.ToLower().Contains("kls")) && DatosRecibidos.Contains("Gro") == true)
                    //            Concatenados = Concatenados + DatosRecibidos;
                        
                    //}
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public string ValorLabel;
        private void timer1_Tick(object sender, EventArgs e)
        {

          

          //  if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "WEIGHTINDX1")
          //  {
          //      if (sp1.IsOpen == true)
          //          sp1.WriteLine("S\r\n");


          //      lbl_kls.Text = "Kls: " + Concatenados.Replace("No", "").Replace("Gross", "").Replace("Tare", "").Replace("Net", "").Replace(" ", "");

          //      Concatenados = "";

          //  }


          //if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "WEIGHTINDX1")

           
          ////  {

          //      if (sp1.IsOpen == true)
          //          sp1.WriteLine("R\r\n");


          //      lbl_kls.Text = "Kls: " + Concatenados.Replace("Net", "").Replace(" Gross", "").Replace("Tare", "").Replace("No", "").Replace(" ", "").Replace(Convert.ToChar(2), Convert.ToChar(32));
          //      ValorLabel = lbl_kls.Text.ToString();
          //      Concatenados = "";
          //  }


          //  if (MarcaBascula == "BREKNELLSIB100")
            if (string.IsNullOrEmpty(MarcaBascula) || MarcaBascula == "WEIGHTINDX1")
            {
                string ValorProcesado = "";

                decimal ValorTruncado = 0;
                bool BienConvertido = false;
                //if (sp1.IsOpen == true)
                //    sp1.WriteLine("W\r\n");

                if (Concatenados.ToLower().Contains("gross") == true || Concatenados.ToLower().Contains("ww") == true)
                {
                    ValorProcesado = Concatenados.Replace(" ", "").Replace(Convert.ToChar(13), Convert.ToChar(32)).Replace("Gross", "").Replace(Convert.ToChar(3), Convert.ToChar(32)).Replace("Neto", "").Replace(":", "").Replace("kg", "").Replace("ww","").Replace("kl","").TrimStart('0');

                    ValorLabel = lbl_kls.Text.ToString();
                    if (!string.IsNullOrEmpty(ValorProcesado))
                    {
                        try
                        {

                            ValorTruncado = Convert.ToDecimal(ValorProcesado);
                            BienConvertido = true;
                        }
                        catch (Exception ex)
                        {
                            BienConvertido = false;
                            Concatenados = "";
                        }
                    }
                    else
                    {

                        BienConvertido = false;


                    }
                    //if (IsNumeric(ValorProcesado) == true)
                    //{
                    //    BienConvertido = true;
                    //}
                    //else {
                    //    BienConvertido = false;
                    //    Concatenados = "";

                    //}

                    if (BienConvertido == true)
                    {
                        lbl_kls.Text = "Kls: " + ValorProcesado;
                        Concatenados = "";
                        ValorLabel = lbl_kls.Text;

                        //lbl_kls.Text = "Kls: " + Concatenados.Replace(" ","").Replace(Convert.ToChar(13),Convert.ToChar(32)).Replace("kg","").Replace(Convert.ToChar(3), Convert.ToChar(32)).Replace("Gross","").Replace(":","");

                        //Concatenados = "";
                    }
                    //char tempvalor;
                    //for (int i = 0; i < lbl_kls.Text.ToString().Length; i++) {
                    //    tempvalor = lbl_kls.Text.ToString()[i];
                    //}


                }
            }
        
        }

        private void lst_unidad1_EditValueChanged(object sender, EventArgs e)
        {
            try {

              barButtonItem16.PerformClick();

            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (

                lst_tipo_plantilla.EditValue.ToString() != "MPRM-01"
                    && lst_tipo_plantilla.EditValue.ToString() != "DKIANGJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "DCONFSACJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "DPTTERM-02"
                    && lst_tipo_plantilla.EditValue.ToString() != "CT-LINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "DCONFSAC"
                    && lst_tipo_plantilla.EditValue.ToString() != "DLINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "DXLINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "DENFARDA"
                    && lst_tipo_plantilla.EditValue.ToString() != "DENFJUMBO"

                    && lst_tipo_plantilla.EditValue.ToString() != "CT-ULTRA"
                    && lst_tipo_plantilla.EditValue.ToString() != "DCONFSACJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "DEXTLAM"
                    && lst_tipo_plantilla.EditValue.ToString() != "DKIANGJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "EXT-LINER"
                    && lst_tipo_plantilla.EditValue.ToString() != "EXT-TUBLAM"
                    && lst_tipo_plantilla.EditValue.ToString() != "KIANG-TJ"
                    && lst_tipo_plantilla.EditValue.ToString() != "TETUB"
                    && lst_tipo_plantilla.EditValue.ToString() != "TJUMBO"
                    && lst_tipo_plantilla.EditValue.ToString() != "UNI-BTELA"
                    && lst_tipo_plantilla.EditValue.ToString() != "CONFMACEN"

                )
            {
                MessageBox.Show("!!SI NO ES MATERIA PRIMA NO PUEDO GENERAR TAGS CONSECUTIVOS!!. Favor generar tags presionando la tecla F1 .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barButtonItem17.Enabled = false;
                return;

            }

            if (string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)))
            {
                MessageBox.Show("Debe de seleccionar un tipo de plantilla para poder ingresar los tags consecutivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            DataSet TagsConsecutivos = new DataSet();
            string ErrorSql = "";
            conexion consulta = new conexion();
            consulta.SetDB(DB);
            consulta.SetUsuario(User_id);
            consulta.SetPassword(Pass);
            consulta.SetServer(Server);

            string TempTurno = "";
            string TempMaquina = "";
            string TempArticulo = "";
            string TempOp = "";
            string TempOperador = "";
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
            string TempUSer10 = "";
            string TempCantidad = "";
            string PrimerTag = "";
            string UltimoTag = "";
            DatosTagConsecutivos datostag = new DatosTagConsecutivos();
            datostag.DB = DB;
            datostag.SMVISUAL = SMVISUAL;
            datostag.Server = Server;
            datostag.User_id = User_id;
            datostag.Pass = Pass;
            datostag.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
            datostag.FechaBuscada = lst_fecha.EditValue.ToString();
            datostag.ShowDialog();


            if (datostag.Respuesta == "OK")
            {

                TempTurno = datostag.Turno;
                
                TempMaquina = datostag.Maquina;
                TempArticulo = datostag.Articulo;
                TempOp = datostag.Op;
                TempOperador = datostag.Operador;
                TempUnidad1 = datostag.Unidad1;
                TempUnidad2 = datostag.Unidad2;

                TempUser1 = datostag.User1;
                TempUser2 = datostag.User2;
                TempUser3 = datostag.User3;
                TempUser4 = datostag.User4;
                TempUser5 = datostag.User5;
                TempUser6 = datostag.User6;
                TempUser7 = datostag.User7;
                TempUser8 = datostag.User8;
                TempUser9 = datostag.User9;
                TempUSer10 = datostag.USer10;
                TempCantidad = datostag.Cantidad;
                string Correlativo = "";
                string ControlError = "";

                //Proceso de cracion de tags consecutivos

                txt_tag.ReadOnly = true;
                txt_tipo_plantilla.ReadOnly = true;
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
                txt_usuario_creo.ReadOnly = true;
                lst_articulo.Enabled = true;
                lst_fecha_creacion.ReadOnly = true;
                lst_fecha_transaccion.Enabled = true;
                lst_operador.Enabled = true;
                lst_maquina.Enabled = true;
                lst_op.Enabled = true;
                lst_turno.Enabled = true;
                lst_unidad1.Enabled = true;
                lst_unidad2.Enabled = true;
                chk_activo.ReadOnly = true;

                barButtonItem6.Enabled = true;
                for (int i = 0; i < Convert.ToDecimal(TempCantidad); i++)
                {

                    bRCTAGSBindingSource.AddNew();
                    lst_fecha_transaccion.EditValue = lst_fecha.EditValue;
                    txt_usuario_creo.EditValue = User_id;
                    txt_tipo_plantilla.EditValue = lst_tipo_plantilla.EditValue.ToString();

                    FechaString = consulta.ejecutaEscalar("select CONVERT(nvarchar(30), GETDATE(), 120) ", ref ErrorSql);

                    FechaActual = Convert.ToDateTime(FechaString);

                    lst_fecha_creacion.EditValue = FechaActual;
                    chk_activo.EditValue = "Y";

                    txt_tag.EditValue = "-";
                    lst_turno.EditValue = TempTurno;
                    lst_turno.EditValue = "A";
                    lst_maquina.EditValue = TempMaquina;
                    lst_articulo.EditValue = TempArticulo;
                    lst_op.EditValue = TempOp;
                    lst_operador.EditValue = TempOperador;
                    lst_unidad1.EditValue = TempUnidad1;
                    lst_unidad2.EditValue = TempUnidad2;

                    txt_user1.EditValue = TempUser1;
                    txt_user2.EditValue = TempUser2;
                    txt_user3.EditValue = TempUser3;
                    txt_user4.EditValue = TempUser4;
                    txt_user5.EditValue = TempUser5;
                    txt_user6.EditValue = TempUser6;
                    txt_user7.EditValue = TempUser7;
                    txt_user8.EditValue = TempUser8;
                    txt_user9.EditValue = TempUser9;
                    txt_user10.EditValue = TempUSer10;



                    if (txt_tag.EditValue.ToString() == "-")
                    {
                        Correlativo = consulta.ejecutaEscalar("SELECT PREFIJO+RIGHT(CEROS + Ltrim(Rtrim(CORRELATIVO)),CANTIDAD_CEROS)+SUFIJO FROM " + DB + ".DBO.BRC_CORRELATIVOS WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y'", ref ControlError);
                        if (Correlativo != "")
                        {
                            ControlError = "";
                            consulta.insertar("UPDATE " + DB + ".DBO.BRC_CORRELATIVOS SET CORRELATIVO=CORRELATIVO+1 WHERE ID_TIPO_PLANTILLA='" + lst_tipo_plantilla.EditValue.ToString() + "' AND ACTIVO='Y'", ref ControlError);

                            if (ControlError == "Completado")
                            {
                                txt_tag.EditValue = Correlativo;
                                brc_tags.Text = Correlativo;

                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error favor contactar a su administrador:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La plantilla " + lst_tipo_plantilla.EditValue.ToString() + " no tiene configurado un correlativo, favor contactar al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (txt_tag.EditValue.ToString() == "-")
                    {
                        MessageBox.Show("Debe de ingresar bien un correlativo antes de guardar, si no puede hacerlo , presione el boton cancelar he intente ingresarlo nuevametne.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (i == 0)
                        PrimerTag = Correlativo;

                    if (i == (Convert.ToDecimal(TempCantidad) - 1))
                        UltimoTag = Correlativo;

                    CalcularFormulas();
                    this.Validate();
                    bRCTAGSBindingSource.EndEdit();

                    bRC_TAGSTableAdapter.Update(dataSetTags);




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
                lst_articulo.Enabled = false;
                lst_fecha_transaccion.Enabled = false;
                lst_maquina.Enabled = false;
                lst_operador.Enabled = false;
                lst_op.Enabled = false;
                lst_turno.Enabled = false;
                lst_unidad1.Enabled = false;
                lst_unidad2.Enabled = false;
                barButtonItem6.Enabled = false;
                EstaEditando = false;
                /*string filterString = "[UnitPrice] > 20 AND [UnitPrice] < 30";
                gridView.Columns["UnitPrice"].FilterInfo = new ColumnFilterInfo(filterString);*/

                // string filterStringTemp = "[ID_TAGS] > '" + PrimerTag + "' Y [ID_TAGS] < '" + UltimoTag + "'";
                // gridView1.Columns["ID_TAGS"].filter =filterString;

                //ColumnFilterInfo filtro = new ColumnFilterInfo(filterStringTemp);


                //GroupOperator filterGroup = new GroupOperator() { OperatorType = GroupOperatorType.And };
                //filterGroup.Operands.Add(new BinaryOperator("StringProperty", "Text 0"));
                //filterGroup.Operands.Add(new BinaryOperator("StringProperty", "Text 1"));
                //filterGroup.Operands.Add(new BinaryOperator("StringProperty", "Text 2"));



                //gridView1.ActiveFilter.Add(gridView1.Columns["StringProperty"], new ColumnFilterInfo(filterGroup));



                //gridView1.ActiveFilter.Add(gridView1.Columns["ID_TAGS"], new ColumnFilterInfo(filterStringTemp));



                if (!string.IsNullOrEmpty(PrimerTag) && !string.IsNullOrEmpty(UltimoTag))
                {
                    MessageBox.Show("Se crearon los tags de " + PrimerTag + " hasta " + UltimoTag + " exitosamente.", "Tags Consecutivos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult Resultado = MessageBox.Show("¿Desea imprimir los tags que se generaron?", "IMPRIMIR TAGS CONSECUTIVOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (Resultado == DialogResult.OK)
                    {
                        TagsConsecutivos = consulta.consultaSelect("SELECT ID_TAGS FROM " + DB + ".DBO.BRC_TAGS WHERE ID_TAGS >='" + PrimerTag + "' AND ID_TAGS<='" + UltimoTag + "' ORDER BY ID_TAGS", "DATOS", ref ControlError);

                        if (ControlError != "Completado")
                        {
                            MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string Revisado = "";
                        string TagTemp = "";
                        for (int i = 0; i < TagsConsecutivos.Tables[0].Rows.Count; i++)
                        {
                            TagTemp = TagsConsecutivos.Tables[0].Rows[i]["ID_TAGS"].ToString();


                            Revisado = consulta.ejecutaEscalar("SELECT ISNULL(REVISADO,'N') FROM " + DB + ".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='" + TagTemp + "'", ref ControlError);


                            if (string.IsNullOrEmpty(Revisado) || Revisado == "N")
                            {

                                if (User_id != "BREYES")
                                {


                                    if (gridView1.DataRowCount <= 1)
                                    {
                                        ListaFechasPorRecibirPT(Server, DB, User_id, Pass, lst_tipo_plantilla.EditValue.ToString(), ref ControlError);
                                        Globalfecha = Convert.ToDateTime(lst_fecha.EditValue.ToString());
                                        GlobalIdTipoPlantilla = Convert.ToString(lst_tipo_plantilla.EditValue);

                                        GlobalIdCalculo = consulta.ejecutaEscalar("SELECT ID_CALCULO FROM " + DB + ".DBO.PRD_CALCULO_ENCABEZADO WHERE ID_TIPO_PLANTILLA='" + GlobalIdTipoPlantilla + "' AND FECHA='" + Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString() + "'", ref ControlError);

                                        if (ControlError != "Completado")
                                        {
                                            MessageBox.Show("Ocurrio un error al recibo de producto terminado:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                    ObtenerProductosARecibir(Server, DB, User_id, Pass, GlobalIdTipoPlantilla, GlobalIdCalculo, Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString(), ref ControlError);
                                    if (ControlError != "Completado")
                                    {

                                        MessageBox.Show("Ocurrio error al recibo producto terminado:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                    ControlError = BuscarTag(Server, DB, User_id, Pass, GlobalIdTipoPlantilla, GlobalIdCalculo, Globalfecha.Year.ToString() + "-" + Globalfecha.Month.ToString() + "-" + Globalfecha.Day.ToString(), TagTemp);

                                    if (ControlError != "Completado")
                                    {
                                        MessageBox.Show("Ocurrio error al recibo producto terminado:" + ControlError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                            }

                        }


                        string NoCopiasTemp = "";
                        int NoCopias = 0;
                        NoCopiasTemp = txt_no_copias.EditValue.ToString();
                        if (string.IsNullOrEmpty(NoCopiasTemp))
                        {
                            NoCopiasTemp = "1";
                        }

                        if (NoCopiasTemp == "0")
                            NoCopiasTemp = "1";

                        try
                        {
                            NoCopias = Convert.ToInt32(NoCopiasTemp);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error formato de numero no correcto:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        string connectionString = @"XpoProvider=MSSqlServer;Data Source=" + Server + ";User ID=" + User_id + ";Password=" + Pass + ";Initial Catalog=" + DB + ";Persist Security Info=true;";
                        CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);

                        //ds.ConnectionParameters



//
                     //   if (lst_tipo_plantilla.EditValue.ToString() == "MPRM-01" ||
                     //     (lst_tipo_plantilla.EditValue.ToString() == "CT-LINER" ||
                     //     lst_tipo_plantilla.EditValue.ToString() == "CT-ULTRA" ||
                    //      lst_tipo_plantilla.EditValue.ToString() == "DCONFSAC" ||
                    //      lst_tipo_plantilla.EditValue.ToString() == "DCONFSACJ" ||
                    //      lst_tipo_plantilla.EditValue.ToString() == "DKIANGJ" ||
                    //      lst_tipo_plantilla.EditValue.ToString() == "DLINER" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "DXLINER" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "KIANG-TJ" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "TETUB" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "TJUMBO" ||
                          //lst_tipo_plantilla.EditValue.ToString() == "UNI-BTELA" &&
                          //(User_id == "CRAFAEL" || User_id == "FBARRERA")

                        //  )
                        //  )
                        //{

                        //    rpt_ImprTagsConseNor4X6 NuevoReporte = new rpt_ImprTagsConseNor4X6();
                        //    NuevoReporte.ShowPrintMarginsWarning = false;
                        //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                        //    ds.ConnectionParameters = connectionParameters;
                        //    NuevoReporte.DataSource = ds;

                        //    NuevoReporte.RequestParameters = false;
                        //    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                        //    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "ID_TAGS").ToString();
                        //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                        //    {

                        //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                        //        printTool.Print("PrinterBarcodeZebra");
                        //    }

                        //}

                        //if (lst_tipo_plantilla.EditValue.ToString() == "DENFARDA" || lst_tipo_plantilla.EditValue.ToString() == "DENFJUMBO")
                        //{

                        //    rpt_ImprTagsConse4x6 NuevoReporte = new rpt_ImprTagsConse4x6();
                        //    NuevoReporte.ShowPrintMarginsWarning = false;
                        //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                        //    ds.ConnectionParameters = connectionParameters;
                        //    NuevoReporte.DataSource = ds;

                        //    NuevoReporte.RequestParameters = false;
                        //    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                        //    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "ID_TAGS").ToString();
                        //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                        //    {

                        //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                        //        printTool.Print("PrinterBarcodeZebra");
                        //    }


                        //}

                        //if (
                        //    lst_tipo_plantilla.EditValue.ToString() != "DENFARDA"
                        //        &&
                        //        lst_tipo_plantilla.EditValue.ToString() != "DENFJUMBO"
                        //        &&
                        //        lst_tipo_plantilla.EditValue.ToString() != "MPRM-01"
                        //        &&
                      
                        //    (

                        //      lst_tipo_plantilla.EditValue.ToString() == "CT-LINER" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "CT-ULTRA" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "DCONFSAC" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "DCONFSACJ" |
                        //      lst_tipo_plantilla.EditValue.ToString() == "DKIANGJ" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "DLINER" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "DXLINER" |
                        //      lst_tipo_plantilla.EditValue.ToString() == "EXT-LINER" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "EXT-TUBLAM" |
                        //      lst_tipo_plantilla.EditValue.ToString() == "KIANG-TJ" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "TETUB" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "TJUMBO" ||
                        //      lst_tipo_plantilla.EditValue.ToString() == "UNI-BTELA"
                        //      &&
                        //      (User_id != "CRAFAEL" && User_id != "FBARRERA")



                        //    )


                        //    )
                        //{

                        //    rpt_ImprTagsConse NuevoReporte = new rpt_ImprTagsConse();
                        //    NuevoReporte.ShowPrintMarginsWarning = false;
                        //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                        //    ds.ConnectionParameters = connectionParameters;
                        //    NuevoReporte.DataSource = ds;

                        //    NuevoReporte.RequestParameters = false;
                        //    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                        //    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "ID_TAGS").ToString();
                        //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                        //    {

                        //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                        //        printTool.Print("PrinterBarcodeZebra");
                        //    }

                        //}


                        //if (lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN")
                        //{
                        //    rpt_ImprTagsConse NuevoReporte = new rpt_ImprTagsConse();
                        //    NuevoReporte.ShowPrintMarginsWarning = false;
                        //    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                        //    ds.ConnectionParameters = connectionParameters;
                        //    NuevoReporte.DataSource = ds;

                        //    NuevoReporte.RequestParameters = false;
                        //    NuevoReporte.Parameters["IdTag"].Value = PrimerTag;
                        //    NuevoReporte.Parameters["IdTag2"].Value = UltimoTag;
                        //    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                        //    {

                        //        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                        //        printTool.Print("PrinterBarcodeZebra");
                        //    }

                        //}


                    }

                }

                barButtonItem11.PerformClick();




            }



        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string NoCopiasTemp = "";
                int NoCopias = 0;
                NoCopiasTemp = txt_no_copias.EditValue.ToString();
                if (string.IsNullOrEmpty(NoCopiasTemp))
                {
                    NoCopiasTemp = "1";
                }

                if (NoCopiasTemp == "0")
                    NoCopiasTemp = "1";

                try
                {
                    NoCopias = Convert.ToInt32(NoCopiasTemp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error formato de numero no correcto:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                string connectionString = @"XpoProvider=MSSqlServer;Data Source=" + Server + ";User ID=" + User_id + ";Password=" + Pass + ";Initial Catalog=" + DB + ";Persist Security Info=true;";
                CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);

                //ds.ConnectionParameters


                    rpt_ImprTagsConse NuevoReporte = new rpt_ImprTagsConse();
                    NuevoReporte.ShowPrintMarginsWarning = false;
                    SqlDataSource ds = (SqlDataSource)NuevoReporte.DataSource;
                    ds.ConnectionParameters = connectionParameters;
                    NuevoReporte.DataSource = ds;

                    NuevoReporte.RequestParameters = false;
                    NuevoReporte.Parameters["IdTag"].Value = gridView1.GetRowCellValue(0, "ID_TAGS").ToString();
                    NuevoReporte.Parameters["IdTag2"].Value = gridView1.GetRowCellValue(gridView1.DataRowCount-1, "ID_TAGS").ToString();
                    using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                    {
                       
                        printTool.PrinterSettings.Copies = Convert.ToInt16(NoCopias);
                        printTool.Print("PrinterBarcodeZebra");
                    }
                
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error:"+ex.Message.ToArray(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            try
            {
                if (EstaEditando == true)
                {
                    MessageBox.Show("No se puede seleccionar otro tag cuando este editando uno y no ha guardado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EstaEditando = false;

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
                    lst_articulo.Enabled = false;
                    lst_fecha_transaccion.Enabled = false;
                    lst_maquina.Enabled = false;
                    lst_operador.Enabled = false;
                    lst_op.Enabled = false;
                    lst_turno.Enabled = false;
                    lst_unidad1.Enabled = false;
                    lst_unidad2.Enabled = false;
                    chk_activo.Enabled = false;
                    barButtonItem11.PerformClick();
                    
                }
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactarse con el administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
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
            lst_articulo.Enabled = false;
            lst_fecha_transaccion.Enabled = false;
            lst_maquina.Enabled = false;
            lst_operador.Enabled = false;
            lst_op.Enabled = false;
            lst_turno.Enabled = false;
            lst_unidad1.Enabled = false;
            lst_unidad2.Enabled = false;
            chk_activo.Enabled = false;
  
        }

        private void gridView1_FocusedRowObjectChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            try
            {

                if (gridView1.DataRowCount > 0)
                {
                    bRC_TAGSTableAdapter.FillObtenerTag(dataSetTags.BRC_TAGS, gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_TAGS").ToString());

                }

                if (EstaEditando == true)
                {
                    MessageBox.Show("No se puede seleccionar otro tag cuando este editando uno y no ha guardado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EstaEditando = false;

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
                    lst_articulo.Enabled = false;
                    lst_fecha_transaccion.Enabled = false;
                    lst_maquina.Enabled = false;
                    lst_operador.Enabled = false;
                    lst_op.Enabled = false;
                    lst_turno.Enabled = false;
                    lst_unidad1.Enabled = false;
                    lst_unidad2.Enabled = false;
                    chk_activo.Enabled = false;
                    barButtonItem11.PerformClick();

                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactarse con el administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try {

                if (string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)))
                {
                    MessageBox.Show("Debe seleccionar un tipo de plantilla antes de agregar peso.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue))) {
                    MessageBox.Show("Debe de guardar antes el tag para poder agregar peso.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToString(txt_tag.EditValue)=="-")
                {
                    MessageBox.Show("Debe de guardar antes el tag para poder agregar peso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //try
                //{

                    
                   

                    
                //    if (sp1.IsOpen == true)
                //    {
                //        sp1.DiscardInBuffer();
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
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet dtDatosSumatoria = new DataSet();


                string YaImpreso = consulta.ejecutaEscalar("SELECT COUNT(ID_TAGS_RECIBO) FROM "+DB+".DBO.BRC_TAGS_RECIBO_PT WHERE TAG='"+txt_tag.EditValue.ToString()+"'",ref ControlError);

                if (string.IsNullOrEmpty(YaImpreso))
                    YaImpreso = "0";

                if (Convert.ToInt32(YaImpreso) > 0) {
                    MessageBox.Show("Este tag ya fue impreso por lo tanto ya no se puede seguir sumando mas pesos, favor crear un nuevo tag.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                
                }

                AgregarPeso frmAgregarPeso = new AgregarPeso();
                frmAgregarPeso.DB = DB;
                frmAgregarPeso.SMVISUAL = SMVISUAL;
                frmAgregarPeso.Server = Server;
                frmAgregarPeso.User_id = User_id;
                frmAgregarPeso.Pass = Pass;
                frmAgregarPeso.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
                frmAgregarPeso.IdTag = txt_tag.EditValue.ToString();

                frmAgregarPeso.PublicUnidad1 = Convert.ToString(lst_unidad1.EditValue);
                frmAgregarPeso.PublicUnidad2 = Convert.ToString(lst_unidad2.EditValue);
                frmAgregarPeso.PublicUser1 = Convert.ToString(txt_user1.EditValue);
                frmAgregarPeso.PublicUser2 = Convert.ToString(txt_user2.EditValue);
                frmAgregarPeso.PublicUser3 = Convert.ToString(txt_user3.EditValue);
                frmAgregarPeso.PublicUser4 = Convert.ToString(txt_user4.EditValue);
                frmAgregarPeso.PublicUser5 = Convert.ToString(txt_user5.EditValue);
                frmAgregarPeso.PublicUser6 = Convert.ToString(txt_user6.EditValue);
                frmAgregarPeso.PublicUser7 = Convert.ToString(txt_user7.EditValue);
                frmAgregarPeso.PublicUser8 = Convert.ToString(txt_user8.EditValue);
                frmAgregarPeso.PublicUser9 = Convert.ToString(txt_user9.EditValue);
                frmAgregarPeso.PublicUser10 = Convert.ToString(txt_user10.EditValue);



                frmAgregarPeso.ShowDialog();

                //try
                //{
                //    tm_lectura.Enabled = true;
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
                string TotalUnidad1 = "";
                string TotalUnidad2 = "";
                string TotalUser1 = "";
                string TotalUser2 = "";
                string TotalUser3 = "";
                string TotalUser4 = "";
                string TotalUser5 = "";
                string TotalUser6 = "";
                string TotalUser7 = "";
                string TotalUser8 = "";
                string TotalUser9 = "";
                string TotalUser10 = "";


                DataSet dtCamposParaSumar ;
              
                string SumaUser1 = "";
                string SumaUser2 = "";
                string SumaUser3 = "";
                string SumaUser4 = "";
                string SumaUser5 = "";
                string SumaUser6 = "";
                string SumaUser7 = "";
                string SumaUser8 = "";
                string SumaUser9 = "";
                string SumaUser10 = "";
                string QueryTemp="";

                dtCamposParaSumar = consulta.consultaSelect("SELECT UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10 FROM "+DB+".DBO.BRC_SUMATORIA_CAMP_DEF_USER WHERE ID_TIPO_PLANTILLA='"+lst_tipo_plantilla.EditValue.ToString()+"' AND ID_USUARIO='"+User_id+"' ","DATOS",ref ControlError);

                if (dtCamposParaSumar.Tables[0].Rows.Count > 0)
                {
                    SumaUser1 = dtCamposParaSumar.Tables[0].Rows[0]["USER_1"].ToString();
                    SumaUser2 = dtCamposParaSumar.Tables[0].Rows[0]["USER_2"].ToString();
                    SumaUser3 = dtCamposParaSumar.Tables[0].Rows[0]["USER_3"].ToString();
                    SumaUser4 = dtCamposParaSumar.Tables[0].Rows[0]["USER_4"].ToString();
                    SumaUser5 = dtCamposParaSumar.Tables[0].Rows[0]["USER_5"].ToString();
                    SumaUser6 = dtCamposParaSumar.Tables[0].Rows[0]["USER_6"].ToString();
                    SumaUser7 = dtCamposParaSumar.Tables[0].Rows[0]["USER_7"].ToString();
                    SumaUser8 = dtCamposParaSumar.Tables[0].Rows[0]["USER_8"].ToString();
                    SumaUser9 = dtCamposParaSumar.Tables[0].Rows[0]["USER_9"].ToString();
                    SumaUser10 = dtCamposParaSumar.Tables[0].Rows[0]["USER_10"].ToString();


                }
                else {
                    SumaUser1 = "Y";
                
                }
                //SUM( ISNULL( CAST(SM_USER_1 AS DECIMAL(18,2)),0)) AS SM_USER_1
                dtDatosSumatoria = consulta.consultaSelect("SELECT SUM( ISNULL(SM_UNIDAD_1,0)) AS SM_UNIDAD_1,SUM(ISNULL(SM_UNIDAD_2,0)) AS SM_UNIDAD_2  FROM "+DB+".DBO.BRC_SUMATORIA WHERE ID_TAGS='"+txt_tag.EditValue.ToString()+"' ","DATOS_SUMATORIA",ref ControlError);

                if (dtDatosSumatoria.Tables[0].Rows.Count > 0) {

                    TotalUnidad1 = dtDatosSumatoria.Tables[0].Rows[0]["SM_UNIDAD_1"].ToString();
                    TotalUnidad2 = dtDatosSumatoria.Tables[0].Rows[0]["SM_UNIDAD_2"].ToString();
                    
                    if (SumaUser1 == "Y")
                        TotalUser1 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_1 AS DECIMAL(18,2)),0)) AS SM_USER_1 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser2 == "Y")
                        TotalUser2 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_2 AS DECIMAL(18,2)),0)) AS SM_USER_2 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser3 == "Y")
                        TotalUser3 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_3 AS DECIMAL(18,2)),0)) AS SM_USER_3 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser4 == "Y")
                        TotalUser4 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_4 AS DECIMAL(18,2)),0)) AS SM_USER_4 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser5 == "Y")
                        TotalUser5 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_5 AS DECIMAL(18,2)),0)) AS SM_USER_5 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser6 == "Y")
                        TotalUser6 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_6 AS DECIMAL(18,2)),0)) AS SM_USER_6 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser7 == "Y")
                        TotalUser7 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_7 AS DECIMAL(18,2)),0)) AS SM_USER_7 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser8 == "Y")
                        TotalUser8 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_8 AS DECIMAL(18,2)),0)) AS SM_USER_8 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser9 == "Y")
                        TotalUser9 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_9 AS DECIMAL(18,2)),0)) AS SM_USER_9 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);

                    if (SumaUser10 == "Y")
                        TotalUser10 = consulta.ejecutaEscalar("SELECT  SUM( ISNULL( CAST(SM_USER_10 AS DECIMAL(18,2)),0)) AS SM_USER_10 FROM " + DB + ".DBO.BRC_SUMATORIA WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "' ", ref ControlError);


                    QueryTemp = "UPDATE " + DB + ".DBO.BRC_TAGS SET UNIDAD_1=" + TotalUnidad1 + ",UNIDAD_2=" + TotalUnidad2;
                    
                    if (SumaUser1 == "Y")
                        QueryTemp = QueryTemp + ",USER_1='" + TotalUser1 + "'";

                    if (SumaUser2 == "Y")
                        QueryTemp = QueryTemp + ",USER_2='" + TotalUser2 + "'";

                    if (SumaUser3 == "Y")
                        QueryTemp = QueryTemp + ",USER_3='" + TotalUser3 + "'";

                    if (SumaUser4 == "Y")
                        QueryTemp = QueryTemp + ",USER_4='" + TotalUser4 + "'";

                    if (SumaUser5 == "Y")
                        QueryTemp = QueryTemp + ",USER_5='" + TotalUser5 + "'";

                    if (SumaUser6 == "Y")
                        QueryTemp = QueryTemp + ",USER_6='" + TotalUser6 + "'";

                    if (SumaUser7 == "Y")
                        QueryTemp = QueryTemp + ",USER_7='" + TotalUser7 + "'";

                    if (SumaUser8 == "Y")
                        QueryTemp = QueryTemp + ",USER_8='" + TotalUser8 + "'";

                    if (SumaUser9 == "Y")
                        QueryTemp = QueryTemp + ",USER_9='" + TotalUser9 + "'";

                    if (SumaUser10 == "Y")
                        QueryTemp = QueryTemp + ",USER_10='" + TotalUser10 + "'";    


                    QueryTemp = QueryTemp + " WHERE ID_TAGS='" + txt_tag.EditValue.ToString() + "'";



                    consulta.insertar(QueryTemp, ref ControlError);

                    if (ControlError != "Completado") {

                        MessageBox.Show("Ocurrio un error al sumar todas los pesos, favor contactar a su administrador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    if (gridView1.DataRowCount > 0)
                    {
                        bRC_TAGSTableAdapter.FillObtenerTag(dataSetTags.BRC_TAGS, gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_TAGS").ToString());

                    }
                }


            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }
        }

        private void lst_maquina_EditValueChanged(object sender, EventArgs e)
        {
            try {

                string Turno = "";
                string IdTipoPlantilla = "";
                string IdMaquina = "";

                if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)))
                    IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();

                if (!string.IsNullOrEmpty(Convert.ToString(lst_turno.EditValue)))
                    Turno = lst_turno.EditValue.ToString();

                if (!string.IsNullOrEmpty(Convert.ToString(lst_maquina.EditValue)))
                    IdMaquina = lst_maquina.EditValue.ToString();

                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);

                string IdOperadorDefault = "";


                if(!string.IsNullOrEmpty( IdTipoPlantilla) && !string.IsNullOrEmpty(Turno) && !string.IsNullOrEmpty(IdMaquina))
                IdOperadorDefault = consulta.ejecutaEscalar("SELECT POM.ID_OPERADOR FROM "+DB+".DBO.PRD_OPERADOR_MAQUINA AS POM,"+DB+".DBO.PRD_OPERADOR_PUESTO AS POP WHERE POM.ID_MAQUINA='"+IdMaquina+"' AND POM.TURNO='"+Turno+"' AND POM.ID_OPERADOR=POP.ID_OPERADOR AND POP.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND POP.ID_PUESTO IN ( 	SELECT ID_PUESTO FROM "+DB+".DBO.PRD_PUESTO WHERE ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND NOMBRE LIKE '%OPER%' ) ",ref ControlError);
                if (!string.IsNullOrEmpty(IdOperadorDefault))
                    lst_operador.EditValue = IdOperadorDefault;


            }
            catch(Exception Ex){
                MessageBox.Show("Ocurrio un error favor contactar a su administrador:"+Ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try {

                if (!string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)) && !string.IsNullOrEmpty(Convert.ToString(txt_tag.EditValue))) {

                    DetalleOperador formDetalleOperador = new DetalleOperador();
                    formDetalleOperador.Server = Server;
                    formDetalleOperador.DB = DB;
                    formDetalleOperador.User_id = User_id;
                    formDetalleOperador.Pass = Pass;
                    formDetalleOperador.IdTag = txt_tag.EditValue.ToString();
                    formDetalleOperador.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
                    formDetalleOperador.ShowDialog();
            
                }

             
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        private void lst_tipo_plantilla_HiddenEditor(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_entarimar_Click(object sender, EventArgs e)
        {
            try {

                if (string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue))) {

                    MessageBox.Show("Debe de seleccionar una fecha antes de entarimar, favor seleccionarla.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue )))
                {

                    MessageBox.Show("Debe de seleccionar un tipo de plantilla antes de entarimar, favor seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GenerarTarima formGenerarTarima = new GenerarTarima();
                formGenerarTarima.SMVISUAL = SMVISUAL;
                formGenerarTarima.DB = DB;
                formGenerarTarima.User_id = User_id;
                formGenerarTarima.Server = Server;
                formGenerarTarima.Pass = Pass;
                formGenerarTarima.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
                formGenerarTarima.Fecha =Convert.ToDateTime( lst_fecha.EditValue).Year.ToString()+"-"+Convert.ToDateTime(lst_fecha.EditValue).Month.ToString()+"-"+Convert.ToDateTime(lst_fecha.EditValue).Day.ToString();
                formGenerarTarima.EsEntarimarATerminar = EsEntarimadoACompletar;

                if (CodigoUniversalTurno.Count > 0)
                    formGenerarTarima.TurnoGlobal = CodigoUniversalTurno[0].ToString();
                else
                    formGenerarTarima.TurnoGlobal = "";
                formGenerarTarima.ShowDialog();
                
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_detalle_tarimas_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(Convert.ToString(lst_fecha.EditValue)))
                {

                    MessageBox.Show("Debe de seleccionar una fecha antes de entarimar, favor seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(Convert.ToString(lst_tipo_plantilla.EditValue)))
                {

                    MessageBox.Show("Debe de seleccionar un tipo de plantilla antes de entarimar, favor seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DetalleTarimas formGenerarTarima = new DetalleTarimas();
                formGenerarTarima.SMVISUAL = SMVISUAL;
                formGenerarTarima.DB = DB;
                formGenerarTarima.User_id = User_id;
                formGenerarTarima.Server = Server;
                formGenerarTarima.Pass = Pass;
                formGenerarTarima.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
                formGenerarTarima.Fecha = Convert.ToDateTime(lst_fecha.EditValue).Year.ToString() + "-" + Convert.ToDateTime(lst_fecha.EditValue).Month.ToString() + "-" + Convert.ToDateTime(lst_fecha.EditValue).Day.ToString();
                formGenerarTarima.PermiteModificar = ModificacionPublica;
                formGenerarTarima.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactar su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_units_Click(object sender, EventArgs e)
        {
            try {

                Unidades formunidades = new Unidades();
                formunidades.DB = DB;
                formunidades.User_id = User_id;
                formunidades.Server = Server;
                formunidades.SMVISUAL = SMVISUAL;
                formunidades.Pass = Pass;
                formunidades.ShowDialog();


            
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }
        }

        private void btn_part_Click(object sender, EventArgs e)
        {
            try {
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();

                string CodigoSeleccionado="";
                Part formpart = new Part();
                formpart.DB = DB;
                formpart.User_id = User_id;
                formpart.Server = Server;
                formpart.SMVISUAL = SMVISUAL;
                formpart.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
                formpart.Pass = Pass;
                formpart.ShowDialog();

                CodigoSeleccionado=formpart.CodigoSeleccionado;
                ds = consulta.consultaSelect("SELECT ID AS Codigo,DESCRIPTION AS Nombre FROM " + DB + ".DBO.BRC_PART WITH(NOLOCK)  ", "ARTICULO", ref ControlError);
                lst_articulo.Properties.DataSource = ds.Tables[0];
                lst_articulo.Properties.ValueMember = "Codigo";
                lst_articulo.Properties.DisplayMember = "Nombre";

               
                if (!string.IsNullOrEmpty(CodigoSeleccionado))
                    lst_articulo.EditValue = CodigoSeleccionado;
            
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lst_operador_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem19_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();
                string CodigoSeleccionado = "";
                Part formpart = new Part();
                formpart.DB = DB;
                formpart.User_id = User_id;
                formpart.Server = Server;
                formpart.SMVISUAL = SMVISUAL;
                formpart.IdTipoPlantilla = lst_tipo_plantilla.EditValue.ToString();
                formpart.Pass = Pass;
                formpart.ShowDialog();

                CodigoSeleccionado = formpart.CodigoSeleccionado;

                ds = consulta.consultaSelect("SELECT ID AS Codigo,DESCRIPTION AS Nombre FROM " + DB + ".DBO.BRC_PART WITH(NOLOCK)  ", "ARTICULO", ref ControlError);
                lst_articulo.Properties.DataSource = ds.Tables[0];
                lst_articulo.Properties.ValueMember = "Codigo";
                lst_articulo.Properties.DisplayMember = "Nombre";
                if (!string.IsNullOrEmpty(CodigoSeleccionado))
                    lst_articulo.EditValue = CodigoSeleccionado;




            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor contactar con su administrador:" + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_fecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void lst_articulo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (EstaEditando == true) {
                    EstaEditando = false;
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
                string StockUm = "";

                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();

                if (!string.IsNullOrEmpty(Convert.ToString(lst_articulo.EditValue)))
                {
                    ds = consulta.consultaSelect("SELECT USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10,STOCK_UM FROM " + DB + ".DBO.BRC_PART WHERE ID='" + lst_articulo.EditValue.ToString() + "'", "DATOS", ref ControlError);

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

                        if (!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[0]["STOCK_UM"])))
                            StockUm = Convert.ToString(ds.Tables[0].Rows[0]["STOCK_UM"]);
                        else
                            StockUm = "";

                        if(string.IsNullOrEmpty(Convert.ToString( txt_user1.EditValue)))
                            txt_user1.EditValue = User1;
                        
                        txt_user2.EditValue = User2;
                        txt_user3.EditValue = User3;
                        txt_user4.EditValue = User4;
                        txt_user5.EditValue = User5;
                        txt_user6.EditValue = User6;
                        txt_user7.EditValue = User7;
                        txt_user8.EditValue = User8;
                        txt_user9.EditValue = User9;
                        txt_user10.EditValue = User10;
                        if (lst_tipo_plantilla.EditValue.ToString() == "CONFMACEN") { 
                        if (!string.IsNullOrEmpty(User10))
                            lst_unidad2.EditValue = User10;
                            }

                        if (lst_tipo_plantilla.EditValue.ToString() == "COMP-MAC")
                        {
                            if (!string.IsNullOrEmpty(User10))
                                lbl_unidad_2.Text = StockUm;
                        }
                        EstaEditando = true;

                    }
                }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:" + ex.Message.ToString());
                return;
            }
        }

        private void txt_no_copias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
