using brc_tags.Librerias;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraEditors.Repository;
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
    public partial class DetalleTarimas : Form
    {

        public string User_id;
        public string DB;
        public string SMVISUAL;
        public string Server;
        public string Pass;
        public string IdTipoPlantilla;
        public string Fecha;
        public string PermiteModificar;
        public DetalleTarimas()
        {
            InitializeComponent();
        }

        private void DetalleTarimas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetDetalleEntarimado.BRC_DETALLE_TAGS_ENTARIMADO' Puede moverla o quitarla según sea necesario.
                //this.bRC_DETALLE_TAGS_ENTARIMADOTableAdapter.Fill(this.dataSetDetalleEntarimado.BRC_DETALLE_TAGS_ENTARIMADO);
                // TODO: esta línea de código carga datos en la tabla 'dataSetEncabezadoTarima.BRC_ENCABEZADO_TAGS' Puede moverla o quitarla según sea necesario.
                //this.bRC_ENCABEZADO_TAGSTableAdapter.Fill(this.dataSetEncabezadoTarima.BRC_ENCABEZADO_TAGS);

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
                bRC_ENCABEZADO_TAGSTableAdapter.Connection.ConnectionString = Conexionfinal;
                bRC_DETALLE_TAGS_ENTARIMADOTableAdapter.Connection.ConnectionString = Conexionfinal;
                
                
                RepositoryItemCheckEdit active = new RepositoryItemCheckEdit();
                gridView1.Columns["ACTIVO"].ColumnEdit = active;
                //Inica que valores tomara de la columna cuando sea verdader, falto o nulo
                active.NullText = "";
                active.ValueChecked = "Y";
                active.ValueUnchecked = "N";
                active.ValueGrayed = "-";


                bRC_ENCABEZADO_TAGSTableAdapter.FillObtenerTarimas(dataSetEncabezadoTarima.BRC_ENCABEZADO_TAGS, IdTipoPlantilla, Fecha);
               
                if(PermiteModificar=="Y"){
                    btn_borrar_det.Enabled=true;
                    btn_guardar_det.Enabled=true;
                    btn_guardar_enc.Enabled=true;
                }

                if(PermiteModificar=="N"){
                    btn_borrar_det.Enabled=false;
                    btn_guardar_det.Enabled=false;
                    btn_guardar_enc.Enabled=false;
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try {

                ArrayList ListaQuerys = new ArrayList();
                string ControlError = "";
                conexion consulta = new conexion();
                consulta.SetDB(DB);
                consulta.SetUsuario(User_id);
                consulta.SetPassword(Pass);
                consulta.SetServer(Server);
                DataSet ds = new DataSet();
                string IdTarima="";
                DialogResult Resultado = MessageBox.Show("¿Esta seguro que desea guardar los cambios de la tarima.?", "Guardar Transacciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.OK)
                {
                    string Activo = "";
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        Activo = gridView1.GetRowCellValue(i, "ACTIVO").ToString();
                        IdTarima=gridView1.GetRowCellValue(i,"ID_ENC_TAGS").ToString();
                        if (Activo == "N")
                        {
                            ListaQuerys.Add("DELETE " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO WHERE ID_ENC_TAGS='" + IdTarima + "' ");
                            
                        }
                        
                    }


                    this.Validate();
                    bRCENCABEZADOTAGSBindingSource.EndEdit();

                    bRC_ENCABEZADO_TAGSTableAdapter.Update(dataSetEncabezadoTarima.BRC_ENCABEZADO_TAGS);

                    consulta.runSqlMatriz(ListaQuerys, ref ControlError);
                    if (ControlError == "Completado")
                    {

                        MessageBox.Show("Se guardo correctamente!!!!!.","Guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        bRC_ENCABEZADO_TAGSTableAdapter.FillObtenerTarimas(dataSetEncabezadoTarima.BRC_ENCABEZADO_TAGS, IdTipoPlantilla, Fecha);
                    }
                    else {
                        MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }


               
            
            }catch(Exception Ex){
                MessageBox.Show("Ocurrio un error favor contactar su administrador:"+Ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try {

                string IdEncTag = "";

                IdEncTag = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_ENC_TAGS").ToString();

                bRC_DETALLE_TAGS_ENTARIMADOTableAdapter.FillObtenerDetalleTarima(dataSetDetalleEntarimado.BRC_DETALLE_TAGS_ENTARIMADO, IdEncTag);

            
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor contactar su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult Resultado = MessageBox.Show("¿Esta seguro que desea borrar el tag de la tarima.?", "Guardar Transacciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.OK)
                {

                    bRCDETALLETAGSENTARIMADOBindingSource.RemoveCurrent();
                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocurrio un error favor contactar su administrador:" + Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

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

                string IdEncTags="";
                string IdMaquina = "";
                string OP = "";
                string CodigoArituclo = "";


                IdEncTags=gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"ID_ENC_TAGS").ToString();
                IdMaquina = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_MAQUINA").ToString();
                OP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OP").ToString();
                CodigoArituclo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "COD_ARTICULO").ToString();


                 string ControlError = "";
                    conexion consulta = new conexion();
                    consulta.SetDB(DB);
                    consulta.SetUsuario(User_id);
                    consulta.SetPassword(Pass);
                    consulta.SetServer(Server);
                    DataSet ds = new DataSet();
                    DataSet dtCamposASumar = new DataSet();
                    DataSet dtCamposInfo = new DataSet();
                    

                DialogResult Resultado = MessageBox.Show("¿Esta seguro que desea guardar los cambios de la tarima.?", "Guardar Transacciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.OK)
                {

                    this.Validate();
                    bRCDETALLETAGSENTARIMADOBindingSource.EndEdit();

                    bRC_DETALLE_TAGS_ENTARIMADOTableAdapter.Update(dataSetDetalleEntarimado.BRC_DETALLE_TAGS_ENTARIMADO);


                    dtCamposASumar = consulta.consultaSelect("SELECT ID_USUARIO,UNIDAD_1,UNIDAD_2,USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10  FROM " + DB + ".DBO.BRC_SUMATORIA_CAMP_DEF_USER WHERE ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND ID_USUARIO='" + User_id + "'", "DATOS_SUMATORIA", ref ControlError);

                    dtCamposInfo = consulta.consultaSelect("SELECT USER_1,USER_2,USER_3,USER_4,USER_5,USER_6,USER_7,USER_8,USER_9,USER_10  FROM " + DB + ".DBO.PRD_INFO_MAQUINAS WHERE ID_MAQUINA='" + IdMaquina + "' AND OP='" + OP + "' AND COD_ARTICULO='" + CodigoArituclo + "' AND ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' ", "DATOS", ref ControlError);


                    if (ControlError == "Completado")
                    {
                        if (dtCamposInfo.Tables[0].Rows.Count > 0)
                        {

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
                                TempTotalUnidad1 = consulta.ejecutaEscalar("SELECT SUM(BT.UNIDAD_1) FROM " + DB + ".DBO.BRC_TAGS AS BT, " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT WHERE   BT.ID_TAGS=ENT.ID_TAGS 	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.FECHA_TRANSACCION='" + Fecha + "' AND ENT.ID_ENC_TAGS='" + IdEncTags + "'", ref ControlError);

                            if (SumarUnidad2 == "Y")
                                TempTotalUnidad2 = consulta.ejecutaEscalar("SELECT SUM(BT.UNIDAD_2) FROM " + DB + ".DBO.BRC_TAGS AS BT, " + DB + ".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS ENT WHERE   BT.ID_TAGS=ENT.ID_TAGS 	AND BT.ID_TIPO_PLANTILLA='" + IdTipoPlantilla + "' AND BT.FECHA_TRANSACCION='" + Fecha + "' AND ENT.ID_ENC_TAGS='" + IdEncTags + "'", ref ControlError);

                            if (SumarUser1 == "Y")
                                TempTotalUser1 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_1,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser1 = InfoUser1;

                            if (SumarUser2 == "Y")
                                TempTotalUser2 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_2,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser2 = InfoUser2;


                            if (SumarUser3 == "Y")
                                TempTotalUser3 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_3,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser3 = InfoUser3;


                            if (SumarUser4 == "Y")
                                TempTotalUser4 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_4,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser4 = InfoUser4;


                            if (SumarUser5 == "Y")
                                TempTotalUser5 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_5,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser5 = InfoUser5;


                            if (SumarUser6 == "Y")
                                TempTotalUser6 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_6,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser6 = InfoUser6;


                            if (SumarUser7 == "Y")
                                TempTotalUser7 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_7,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser7 = InfoUser7;


                            if (SumarUser8 == "Y")
                                TempTotalUser8 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_8,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser8 = InfoUser8;


                            if (SumarUser9 == "Y")
                                TempTotalUser9 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_9,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser9 = InfoUser9;


                            if (SumarUser10 == "Y")
                                TempTotalUser10 = consulta.ejecutaEscalar("SELECT SUM( CAST( ISNULL(BT.USER_10,0) AS DECIMAL(18,2)) )  FROM "+DB+".DBO.BRC_TAGS AS BT 	, "+DB+".DBO.BRC_DETALLE_TAGS_ENTARIMADO AS DET WHERE  BT.ID_TAGS=DET.ID_TAGS	AND BT.ID_TIPO_PLANTILLA='"+IdTipoPlantilla+"' AND BT.FECHA_TRANSACCION='"+Fecha+"' AND DET.ID_ENC_TAGS='"+IdEncTags+"' ", ref ControlError);
                            else
                                TempTotalUser10 = InfoUser10;

                            consulta.insertar("UPDATE " + DB + ".DBO.BRC_ENCABEZADO_TAGS SET UNIDAD_1=" + TempTotalUnidad1 + ",UNIDAD_2=" + TempTotalUnidad2 + ",USER_1='" + TempTotalUser1 + "',USER_2='" + TempTotalUser2 + "',USER_3='" + TempTotalUser3 + "',USER_4='" + TempTotalUser4 + "',USER_5='" + TempTotalUser5 + "', USER_6='" + TempTotalUser6 + "',USER_7='" + TempTotalUser7 + "',USER_8='" + TempTotalUser8 + "',USER_9='" + TempTotalUser9 + "',USER_10='" + TempTotalUser10 + "' WHERE ID_ENC_TAGS='" + IdEncTags + "' ", ref ControlError);
                    
                            if(ControlError=="Completado"){
                                MessageBox.Show("Se actualizo la tarima correctamente!","Guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                bRC_ENCABEZADO_TAGSTableAdapter.FillObtenerTarimas(dataSetEncabezadoTarima.BRC_ENCABEZADO_TAGS, IdTipoPlantilla, Fecha);
                            }
                            else{
                            MessageBox.Show("Ocurrio un error favor contactar su administador:"+ControlError,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }

                        }
                    }

                    
                        



                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocurrio un error favor contactar su administrador:" + Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"XpoProvider=MSSqlServer;Data Source=" + Server + ";User ID=" + User_id + ";Password=" + Pass + ";Initial Catalog=" + DB + ";Persist Security Info=true;";
                CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);

                //ds.ConnectionParameters
                string IdEncTag = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID_ENC_TAGS").ToString();
                rpt_ImprTarima NuevoReporte = new rpt_ImprTarima();
                NuevoReporte.ShowPrintMarginsWarning = false;

                SqlDataSource dss = (SqlDataSource)NuevoReporte.DataSource;
                dss.ConnectionParameters = connectionParameters;
                NuevoReporte.DataSource = dss;
                NuevoReporte.Parameters["IdTag"].Value = IdEncTag;
                NuevoReporte.RequestParameters = false;


                //ZDesigner GK420t
                //PrinterBarcodeZebra
                using (ReportPrintTool printTool = new ReportPrintTool(NuevoReporte))
                {
                    printTool.PrinterSettings.Copies = Convert.ToInt16(1);
                    printTool.Print("PrinterBarcodeZebra");

                }
                    
            }
            catch(Exception ex){
                MessageBox.Show("Ocurrio un error favor comunicarse con su administrador:"+ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }
    }
}
