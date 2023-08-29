using brc_tags.Librerias;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
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
    public partial class GenerarTarima : Form
    {
        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string IdTipoPlantilla;
        public string Fecha;
        public string EsEntarimarATerminar;
        public string TurnoGlobal;
        public GenerarTarima()
        {
            InitializeComponent();
        }

        private void GenerarTarima_Load(object sender, EventArgs e)
        {
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
                sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter.Connection.ConnectionString = Conexionfinal;

                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                string ControlError = "";
                DataSet ds = new DataSet();

                ds = consulta.consultaSelect("SELECT 'A' AS Codigo ,'Turno A' as Nombre UNION SELECT 'B' AS Codigo ,'Turno B' as Nombre ", "TURNO", ref ControlError);
                lst_turno.Properties.DataSource = ds.Tables[0];
                lst_turno.Properties.ValueMember = "Codigo";
                lst_turno.Properties.DisplayMember = "Nombre";

                if (!string.IsNullOrEmpty(TurnoGlobal))
                    lst_turno.EditValue = TurnoGlobal;

                if (EsEntarimarATerminar == "Y")
                {

                    sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter.FillObtenerResumenEntarimado(dataSetResumenEntarimado.SP_BRC_OBTENER_LISTADO_ENTARIMADO, IdTipoPlantilla, Fecha, "Y");

                }
                else {

                    sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter.FillObtenerResumenEntarimado(dataSetResumenEntarimado.SP_BRC_OBTENER_LISTADO_ENTARIMADO, IdTipoPlantilla, Fecha,"N");

                }
                
                
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un erro favor contactar su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try {
                string SumarUnidad1 = "";
                string SumarUnidad2 = "";
                string SumarUser1 = "";
                string SumarUser2 = "";
                string SumarUser3 = "";
                string SumarUser4 = "";
                string SumarUser5 = "";
                string SumarUser6 = "";
                string SumarUser7 = "";
                string SumarUser8 = "";
                string SumarUser9 = "";
                string SumarUser10 = "";
                string TempTotalUnidad1 = "";
                string TempTotalUnidad2 = "";
                string TempTotalUser1 = "";
                string TempTotalUser2 = "";
                string TempTotalUser3 = "";
                string TempTotalUser4 = "";
                string TempTotalUser5 = "";
                string TempTotalUser6 = "";
                string TempTotalUser7 = "";
                string TempTotalUser8 = "";
                string TempTotalUser9 = "";
                string TempTotalUser10 = "";
                string Correlativo = "";

                string InfoUser1 = "";
                string InfoUser2 = "";
                string InfoUser3 = "";
                string InfoUser4 = "";
                string InfoUser5 = "";
                string InfoUser6 = "";
                string InfoUser7 = "";
                string InfoUser8 = "";
                string InfoUser9 = "";
                string InfoUser10 = "";

                ArrayList SqlQuerys = new ArrayList();
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();

                DataSet dtCamposASumar = new DataSet();
                DataSet dtCamposInfo = new DataSet();
                string ExisteCorrelativoMaquina = "";
                string OP = "";
                string Turno="";
                string IdMaquina = "";
                string CodigoArituclo = "";
                string TotalKilos = "";
                string TotalUnidades = "";
                string FechasSeleccionadas = "";
                int[] FilasSelecionadas;
                FilasSelecionadas = gridView1.GetSelectedRows();

                string VerificacionMaquina = "";
                string VerificacionOp = "";

                if (string.IsNullOrEmpty(Convert.ToString( lst_turno.EditValue))) {
                    MessageBox.Show("Debe seleccionar un turno para poder entarimar.!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }


                if (gridView1.DataRowCount > 0)
                {

                    if (FilasSelecionadas.Length > 1)
                    {
                        for (int i = 0; i < FilasSelecionadas.Length - 1; i++)
                        {
                            VerificacionMaquina = gridView1.GetRowCellValue(FilasSelecionadas[i], "ID_MAQUINA").ToString();
                            VerificacionOp = gridView1.GetRowCellValue(FilasSelecionadas[i], "OP").ToString();
                            if (IdTipoPlantilla != "KIANG-TZ")
                            {
                                if (VerificacionMaquina != gridView1.GetRowCellValue(FilasSelecionadas[i + 1], "ID_MAQUINA").ToString())
                                {
                                    MessageBox.Show("No puede seleccionar tags de diferentes maquinas favor solo seleccionar tags de la misma maquina.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            if (VerificacionOp != gridView1.GetRowCellValue(FilasSelecionadas[i + 1], "OP").ToString())
                            {
                                MessageBox.Show("No puede seleccionar tags de diferentes OP's favor solo seleccionar tags de la misma op.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }

                    for (int i = 0; i < FilasSelecionadas.Length; i++)
                        FechasSeleccionadas = FechasSeleccionadas + "'" + Convert.ToDateTime(gridView1.GetRowCellValue(FilasSelecionadas[i], "FECHA_TRANSACCION")).Year.ToString() + "-" + Convert.ToDateTime(gridView1.GetRowCellValue(FilasSelecionadas[i], "FECHA_TRANSACCION")).Month.ToString() + "-" + Convert.ToDateTime(gridView1.GetRowCellValue(FilasSelecionadas[i], "FECHA_TRANSACCION")).Day.ToString() + "',";

                    FechasSeleccionadas = "("+FechasSeleccionadas.Substring(0, FechasSeleccionadas.Length - 1)+")";


                    OP = gridView1.GetRowCellValue(FilasSelecionadas[0], "OP").ToString();
                    Turno = lst_turno.EditValue.ToString();
                    IdMaquina = gridView1.GetRowCellValue(FilasSelecionadas[0], "ID_MAQUINA").ToString();

                    CodigoArituclo = gridView1.GetRowCellValue(FilasSelecionadas[0], "COD_ARTICULO").ToString();

                    TotalUnidades = gridView1.GetRowCellValue(FilasSelecionadas[0], "UNIDAD_1").ToString();
                    TotalKilos = gridView1.GetRowCellValue(FilasSelecionadas[0], "UNIDAD_2").ToString();


                    DialogResult Resultado = MessageBox.Show("¿Esta seguro que desea generar la tarima de lo que se a generado en la maquina: " + IdMaquina + " la orden: " + OP + " y el articulo: " + CodigoArituclo + " ?", "Procesar transacciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (Resultado == DialogResult.OK)
                    {
                        dtCamposASumar = consulta.consultaSelect("SELECT ID_USUARIO,UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10  FROM " + DB + ".DBO.BRC_SUMATORIA_CAMP_DEF_USER WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ID_USUARIO='"+User_id+"'", "DATOS_SUMATORIA", ref ControlError);
                        
                        dtCamposInfo = consulta.consultaSelect("SELECT USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10  FROM "+DB+".DBO.PRD_INFO_MAQUINAS WHERE ID_MAQUINA='"+IdMaquina+"' AND OP='"+OP+"' AND COD_ARTICULO='"+CodigoArituclo+"' AND ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' ","DATOS",ref ControlError);
         

                        if (ControlError == "Completado")
                        {
                            if (dtCamposInfo.Tables[0].Rows.Count > 0) {
                            
                                InfoUser1 = dtCamposInfo.Tables[0].Rows[0]["USER_1"].ToString();
                                InfoUser2 = dtCamposInfo.Tables[0].Rows[0]["USER_2"].ToString();
                                InfoUser3 = dtCamposInfo.Tables[0].Rows[0]["USER_3"].ToString();
                                InfoUser4 = dtCamposInfo.Tables[0].Rows[0]["USER_4"].ToString();
                                InfoUser5 = dtCamposInfo.Tables[0].Rows[0]["USER_5"].ToString();
                                InfoUser6 = dtCamposInfo.Tables[0].Rows[0]["USER_6"].ToString();
                                InfoUser7 = dtCamposInfo.Tables[0].Rows[0]["USER_7"].ToString();
                                InfoUser8 = dtCamposInfo.Tables[0].Rows[0]["USER_8"].ToString();
                                InfoUser9 = dtCamposInfo.Tables[0].Rows[0]["USER_9"].ToString();
                                InfoUser10 = dtCamposInfo.Tables[0].Rows[0]["USER_10"].ToString();
                            
                            }


                            if (dtCamposASumar.Tables[0].Rows.Count > 0)
                            {
                            
                                SumarUnidad1 = dtCamposASumar.Tables[0].Rows[0]["UNIDAD_1"].ToString();
                                SumarUnidad2 = dtCamposASumar.Tables[0].Rows[0]["UNIDAD_2"].ToString();
                                SumarUser1 = dtCamposASumar.Tables[0].Rows[0]["USER_1"].ToString();
                                SumarUser2 = dtCamposASumar.Tables[0].Rows[0]["USER_2"].ToString();
                                SumarUser3 = dtCamposASumar.Tables[0].Rows[0]["USER_3"].ToString();
                                SumarUser4 = dtCamposASumar.Tables[0].Rows[0]["USER_4"].ToString();
                                SumarUser5 = dtCamposASumar.Tables[0].Rows[0]["USER_5"].ToString();
                                SumarUser6 = dtCamposASumar.Tables[0].Rows[0]["USER_6"].ToString();
                                SumarUser7 = dtCamposASumar.Tables[0].Rows[0]["USER_7"].ToString();
                                SumarUser8 = dtCamposASumar.Tables[0].Rows[0]["USER_8"].ToString();
                                SumarUser9 = dtCamposASumar.Tables[0].Rows[0]["USER_9"].ToString();
                                SumarUser10 = dtCamposASumar.Tables[0].Rows[0]["USER_10"].ToString();

                                if (string.IsNullOrEmpty(SumarUnidad1))
                                    SumarUnidad1 = "N";

                                if (string.IsNullOrEmpty(SumarUnidad2))
                                    SumarUnidad2 = "N";

                                if (string.IsNullOrEmpty(SumarUser1))
                                    SumarUser1 = "N";

                                if (string.IsNullOrEmpty(SumarUser2))
                                    SumarUser2 = "N";

                                if (string.IsNullOrEmpty(SumarUser3))
                                    SumarUser3 = "N";

                                if (string.IsNullOrEmpty(SumarUser4))
                                    SumarUser4 = "N";

                                if (string.IsNullOrEmpty(SumarUser5))
                                    SumarUser5 = "N";

                                if (string.IsNullOrEmpty(SumarUser6))
                                    SumarUser6 = "N";

                                if (string.IsNullOrEmpty(SumarUser7))
                                    SumarUser7 = "N";

                                if (string.IsNullOrEmpty(SumarUser8))
                                    SumarUser8 = "N";

                                if (string.IsNullOrEmpty(SumarUser9))
                                    SumarUser9 = "N";

                                if (string.IsNullOrEmpty(SumarUser10))
                                    SumarUser10 = "N";


                                if (SumarUnidad1 == "Y")
                                    TempTotalUnidad1 = consulta.ejecutaEscalar("SELECT SUM(BT.UNIDAD_1) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                               
                                if (SumarUnidad2 == "Y")
                                    TempTotalUnidad2 = consulta.ejecutaEscalar("SELECT SUM(BT.UNIDAD_2) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL	 AND BT.ACTIVO='Y' AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);

                                if (SumarUser1 == "Y")
                                    TempTotalUser1 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_1,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser1 = InfoUser1;

                                if (SumarUser2 == "Y")
                                    TempTotalUser2 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_2,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser2 = InfoUser2;


                                if (SumarUser3 == "Y")
                                    TempTotalUser3 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_3,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser3 = InfoUser3;


                                if (SumarUser4 == "Y")
                                    TempTotalUser4 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_4,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser4 = InfoUser4;


                                if (SumarUser5 == "Y")
                                    TempTotalUser5 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_5,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser5 = InfoUser5;


                                if (SumarUser6 == "Y")
                                    TempTotalUser6 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_6,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser6 = InfoUser6;


                                if (SumarUser7 == "Y")
                                    TempTotalUser7 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_7,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser7 = InfoUser7;


                                if (SumarUser8 == "Y")
                                    TempTotalUser8 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_8,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser8 = InfoUser8;


                                if (SumarUser9 == "Y")
                                    TempTotalUser9 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_9,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL  AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser9 = InfoUser9;


                                if (SumarUser10 == "Y")
                                    TempTotalUser10 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_10,0) AS DECIMAL(18,2)) ) FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL AND BT.ACTIVO='Y'	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.OP='" + OP + "' AND BT.FECHA_TRANSACCION IN " + FechasSeleccionadas + "", ref ControlError);
                                else
                                    TempTotalUser10 = InfoUser10;

                                ExisteCorrelativoMaquina = consulta.ejecutaEscalar("SELECT COUNT(ID) FROM " + DB + ".DBO.BRC_CORR_ENTARIMADO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y' AND ID_MAQUINA ='" + IdMaquina + "'", ref ControlError);

                                if (Convert.ToInt32(ExisteCorrelativoMaquina) > 0)
                                    Correlativo = consulta.ejecutaEscalar("SELECT PREFIJO+RIGHT(CEROS + Ltrim(Rtrim(CORRELATIVO)),CANTIDAD_CEROS)+SUFIJO FROM " + DB + ".DBO.BRC_CORR_ENTARIMADO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y' AND ID_MAQUINA='" + IdMaquina + "'", ref ControlError);
                                if (Convert.ToInt32(ExisteCorrelativoMaquina) == 0)
                                    Correlativo = consulta.ejecutaEscalar("SELECT PREFIJO+RIGHT(CEROS + Ltrim(Rtrim(CORRELATIVO)),CANTIDAD_CEROS)+SUFIJO  FROM " + DB + ".DBO.BRC_CORR_ENTARIMADO WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y' AND ID_MAQUINA IS NULL", ref ControlError);


                                if (Correlativo != "")
                                {

                                    ControlError = "";

                                    if (Convert.ToInt32(ExisteCorrelativoMaquina) > 0)
                                        SqlQuerys.Add("UPDATE " + DB + ".DBO.BRC_CORR_ENTARIMADO SET CORRELATIVO=CORRELATIVO+1 WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y'  AND ID_MAQUINA='" + IdMaquina + "'");
                                    

                                    if (Convert.ToInt32(ExisteCorrelativoMaquina) == 0)
                                        SqlQuerys.Add("UPDATE " + DB + ".DBO.BRC_CORR_ENTARIMADO SET CORRELATIVO=CORRELATIVO+1 WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ACTIVO='Y'  AND ID_MAQUINA IS NULL");
                                       

                                        SqlQuerys.Add("INSERT INTO " + DB + ".DBO.BRC_ENCABEZADO_TAGS(ID_ENC_TAGS,FECHA_TRANSACCION,TURNO,USUARIO_CREO,FECHA_CREACION,ID_TIPO_PLANTILLA,ID_MAQUINA,OP,COD_ARTICULO,UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10,ENCONTRADO,ACTIVO) VALUES('" + Correlativo + "','" + Fecha + "','" + Turno + "','"+User_id+"',GETDATE(),'" + IdTipoPlantilla + "','" + IdMaquina + "','" + OP + "','" + CodigoArituclo + "'," + TempTotalUnidad1 + "," + TempTotalUnidad2 + ",'" + TempTotalUser1 + "','" + TempTotalUser2 + "','" + TempTotalUser3 + "','" + TempTotalUser4 + "','" + TempTotalUser5 + "','" + TempTotalUser6 + "','" + TempTotalUser7 + "','" + TempTotalUser8 + "','" + TempTotalUser9 + "','" + TempTotalUser10 + "','N','Y')");

                                        if (IdTipoPlantilla == "KIANG-TZ")
                                        {
                                            SqlQuerys.Add("INSERT INTO " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO(ID_TAGS,ID_ENC_TAGS) SELECT BT.ID_TAGS,'" + Correlativo + "' FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL AND BT.ACTIVO='Y' AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.FECHA_TRANSACCION  IN " + FechasSeleccionadas +  "' AND BT.OP='" + OP + "' ");

                                        }
                                        else {
                                            SqlQuerys.Add("INSERT INTO " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO(ID_TAGS,ID_ENC_TAGS) SELECT BT.ID_TAGS,'" + Correlativo + "' FROM " + DB + ".DBO.BRC_TAGS AS BT LEFT JOIN " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT ON BT.ID_TAGS=ENT.ID_TAGS WHERE  ENT.ID_TAGS IS NULL AND BT.ACTIVO='Y' AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.FECHA_TRANSACCION  IN " + FechasSeleccionadas + " AND BT.ID_MAQUINA='" + IdMaquina + "' AND BT.OP='" + OP + "' ");
  
                                        }
                                      

                                        consulta.runSqlMatriz(SqlQuerys, ref ControlError);

                                        if (ControlError == "Completado")
                                        {

                                            string connectionString = @"XpoProvider=MSSqlServer;Data Source=" + Server + ";User ID=" + User_id + ";Password=" + Pass + ";Initial Catalog=" + DB + ";Persist Security Info=true;";
                                            CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);

                                            //ds.ConnectionParameters

                                            rpt_ImprTarima NuevoReporte = new rpt_ImprTarima();
                                            NuevoReporte.ShowPrintMarginsWarning = false;

                                            SqlDataSource dss = (SqlDataSource)NuevoReporte.DataSource;
                                            dss.ConnectionParameters = connectionParameters;
                                            NuevoReporte.DataSource = dss;
                                            NuevoReporte.Parameters["IdTag"].Value = Correlativo;
                                            NuevoReporte.RequestParameters = false;


                                            //ZDesigner GK420t
                                            //PrinterBarcodeZebra
                                            using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                                            {
                                                printTool.PrinterSettings.Copies = Convert.ToInt16(1);
                                                printTool.Print("PrinterBarcodeZebra");

                                            }

                                              MessageBox.Show("Se entarimo correctamente los tags.!!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                              if (EsEntarimarATerminar == "Y")
                                              {
                                                  sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter.FillObtenerResumenEntarimado(dataSetResumenEntarimado.SP_BRC_OBTENER_LISTADO_ENTARIMADO, IdTipoPlantilla, Fecha,"Y");
                                              }
                                              else {
                                                  sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter.FillObtenerResumenEntarimado(dataSetResumenEntarimado.SP_BRC_OBTENER_LISTADO_ENTARIMADO, IdTipoPlantilla, Fecha,"N");
                                              
                                              }

                                        
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                        }
                                   
                                }
                                else
                                {
                                    MessageBox.Show("La plantilla " + IdTipoPlantilla + " no tiene configurado un correlativo, favor contactar al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                            }
                        }
                    }


                }

            }catch(Exception Ex){

                MessageBox.Show("Ocurrio un error favor contactarse con su administrador:"+Ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
    }
}
