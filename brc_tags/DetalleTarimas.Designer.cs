namespace brc_tags
{
    partial class DetalleTarimas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleTarimas));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_imp_enc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guardar_enc = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bRCENCABEZADOTAGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEncabezadoTarima = new brc_tags.DA.DataSetEncabezadoTarima();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_ENC_TAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA_TRANSACCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTURNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSUARIO_CREO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFECHA_CREACION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_TIPO_PLANTILLA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_MAQUINA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIDAD_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIDAD_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colENCONTRADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_borrar_det = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guardar_det = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bRCDETALLETAGSENTARIMADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDetalleEntarimado = new brc_tags.DA.DataSetDetalleEntarimado();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_TAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ENC_TAGS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bRC_ENCABEZADO_TAGSTableAdapter = new brc_tags.DA.DataSetEncabezadoTarimaTableAdapters.BRC_ENCABEZADO_TAGSTableAdapter();
            this.bRC_DETALLE_TAGS_ENTARIMADOTableAdapter = new brc_tags.DA.DataSetDetalleEntarimadoTableAdapters.BRC_DETALLE_TAGS_ENTARIMADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCENCABEZADOTAGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEncabezadoTarima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCDETALLETAGSENTARIMADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleEntarimado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btn_imp_enc);
            this.groupControl1.Controls.Add(this.btn_guardar_enc);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(871, 394);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tarimas";
            // 
            // btn_imp_enc
            // 
            this.btn_imp_enc.Image = ((System.Drawing.Image)(resources.GetObject("btn_imp_enc.Image")));
            this.btn_imp_enc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_imp_enc.Location = new System.Drawing.Point(789, 26);
            this.btn_imp_enc.Name = "btn_imp_enc";
            this.btn_imp_enc.Size = new System.Drawing.Size(38, 30);
            this.btn_imp_enc.TabIndex = 2;
            this.btn_imp_enc.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btn_guardar_enc
            // 
            this.btn_guardar_enc.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar_enc.Image")));
            this.btn_guardar_enc.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_guardar_enc.Location = new System.Drawing.Point(833, 26);
            this.btn_guardar_enc.Name = "btn_guardar_enc";
            this.btn_guardar_enc.Size = new System.Drawing.Size(33, 30);
            this.btn_guardar_enc.TabIndex = 1;
            this.btn_guardar_enc.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = this.bRCENCABEZADOTAGSBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(861, 363);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bRCENCABEZADOTAGSBindingSource
            // 
            this.bRCENCABEZADOTAGSBindingSource.DataMember = "BRC_ENCABEZADO_TAGS";
            this.bRCENCABEZADOTAGSBindingSource.DataSource = this.dataSetEncabezadoTarima;
            // 
            // dataSetEncabezadoTarima
            // 
            this.dataSetEncabezadoTarima.DataSetName = "DataSetEncabezadoTarima";
            this.dataSetEncabezadoTarima.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_ENC_TAGS,
            this.colFECHA_TRANSACCION,
            this.colTURNO,
            this.colUSUARIO_CREO,
            this.colFECHA_CREACION,
            this.colID_TIPO_PLANTILLA,
            this.colID_MAQUINA,
            this.colOP,
            this.colCOD_ARTICULO,
            this.colUNIDAD_1,
            this.colUNIDAD_2,
            this.colUSER_1,
            this.colUSER_2,
            this.colUSER_3,
            this.colUSER_4,
            this.colUSER_5,
            this.colUSER_6,
            this.colUSER_7,
            this.colUSER_8,
            this.colUSER_9,
            this.colUSER_10,
            this.colENCONTRADO,
            this.colACTIVO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colID_ENC_TAGS
            // 
            this.colID_ENC_TAGS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_ENC_TAGS.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_ENC_TAGS.AppearanceHeader.Options.UseFont = true;
            this.colID_ENC_TAGS.AppearanceHeader.Options.UseForeColor = true;
            this.colID_ENC_TAGS.Caption = "Tag";
            this.colID_ENC_TAGS.FieldName = "ID_ENC_TAGS";
            this.colID_ENC_TAGS.Name = "colID_ENC_TAGS";
            this.colID_ENC_TAGS.OptionsColumn.ReadOnly = true;
            this.colID_ENC_TAGS.Visible = true;
            this.colID_ENC_TAGS.VisibleIndex = 0;
            // 
            // colFECHA_TRANSACCION
            // 
            this.colFECHA_TRANSACCION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colFECHA_TRANSACCION.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colFECHA_TRANSACCION.AppearanceHeader.Options.UseFont = true;
            this.colFECHA_TRANSACCION.AppearanceHeader.Options.UseForeColor = true;
            this.colFECHA_TRANSACCION.Caption = "Fecha";
            this.colFECHA_TRANSACCION.FieldName = "FECHA_TRANSACCION";
            this.colFECHA_TRANSACCION.Name = "colFECHA_TRANSACCION";
            this.colFECHA_TRANSACCION.OptionsColumn.ReadOnly = true;
            this.colFECHA_TRANSACCION.Visible = true;
            this.colFECHA_TRANSACCION.VisibleIndex = 1;
            // 
            // colTURNO
            // 
            this.colTURNO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colTURNO.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colTURNO.AppearanceHeader.Options.UseFont = true;
            this.colTURNO.AppearanceHeader.Options.UseForeColor = true;
            this.colTURNO.Caption = "Turno";
            this.colTURNO.FieldName = "TURNO";
            this.colTURNO.Name = "colTURNO";
            this.colTURNO.OptionsColumn.ReadOnly = true;
            this.colTURNO.Visible = true;
            this.colTURNO.VisibleIndex = 2;
            // 
            // colUSUARIO_CREO
            // 
            this.colUSUARIO_CREO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSUARIO_CREO.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSUARIO_CREO.AppearanceHeader.Options.UseFont = true;
            this.colUSUARIO_CREO.AppearanceHeader.Options.UseForeColor = true;
            this.colUSUARIO_CREO.Caption = "Usuario";
            this.colUSUARIO_CREO.FieldName = "USUARIO_CREO";
            this.colUSUARIO_CREO.Name = "colUSUARIO_CREO";
            this.colUSUARIO_CREO.OptionsColumn.ReadOnly = true;
            this.colUSUARIO_CREO.Visible = true;
            this.colUSUARIO_CREO.VisibleIndex = 3;
            // 
            // colFECHA_CREACION
            // 
            this.colFECHA_CREACION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colFECHA_CREACION.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colFECHA_CREACION.AppearanceHeader.Options.UseFont = true;
            this.colFECHA_CREACION.AppearanceHeader.Options.UseForeColor = true;
            this.colFECHA_CREACION.Caption = "Creacion";
            this.colFECHA_CREACION.FieldName = "FECHA_CREACION";
            this.colFECHA_CREACION.Name = "colFECHA_CREACION";
            this.colFECHA_CREACION.OptionsColumn.ReadOnly = true;
            this.colFECHA_CREACION.Visible = true;
            this.colFECHA_CREACION.VisibleIndex = 4;
            // 
            // colID_TIPO_PLANTILLA
            // 
            this.colID_TIPO_PLANTILLA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_TIPO_PLANTILLA.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_TIPO_PLANTILLA.AppearanceHeader.Options.UseFont = true;
            this.colID_TIPO_PLANTILLA.AppearanceHeader.Options.UseForeColor = true;
            this.colID_TIPO_PLANTILLA.Caption = "Plantilla";
            this.colID_TIPO_PLANTILLA.FieldName = "ID_TIPO_PLANTILLA";
            this.colID_TIPO_PLANTILLA.Name = "colID_TIPO_PLANTILLA";
            this.colID_TIPO_PLANTILLA.OptionsColumn.ReadOnly = true;
            this.colID_TIPO_PLANTILLA.Visible = true;
            this.colID_TIPO_PLANTILLA.VisibleIndex = 5;
            // 
            // colID_MAQUINA
            // 
            this.colID_MAQUINA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_MAQUINA.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_MAQUINA.AppearanceHeader.Options.UseFont = true;
            this.colID_MAQUINA.AppearanceHeader.Options.UseForeColor = true;
            this.colID_MAQUINA.Caption = "Maquina";
            this.colID_MAQUINA.FieldName = "ID_MAQUINA";
            this.colID_MAQUINA.Name = "colID_MAQUINA";
            this.colID_MAQUINA.OptionsColumn.ReadOnly = true;
            this.colID_MAQUINA.Visible = true;
            this.colID_MAQUINA.VisibleIndex = 6;
            // 
            // colOP
            // 
            this.colOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colOP.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colOP.AppearanceHeader.Options.UseFont = true;
            this.colOP.AppearanceHeader.Options.UseForeColor = true;
            this.colOP.Caption = "Op";
            this.colOP.FieldName = "OP";
            this.colOP.Name = "colOP";
            this.colOP.OptionsColumn.ReadOnly = true;
            this.colOP.Visible = true;
            this.colOP.VisibleIndex = 7;
            // 
            // colCOD_ARTICULO
            // 
            this.colCOD_ARTICULO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCOD_ARTICULO.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colCOD_ARTICULO.AppearanceHeader.Options.UseFont = true;
            this.colCOD_ARTICULO.AppearanceHeader.Options.UseForeColor = true;
            this.colCOD_ARTICULO.Caption = "Articulo";
            this.colCOD_ARTICULO.FieldName = "COD_ARTICULO";
            this.colCOD_ARTICULO.Name = "colCOD_ARTICULO";
            this.colCOD_ARTICULO.OptionsColumn.ReadOnly = true;
            this.colCOD_ARTICULO.Visible = true;
            this.colCOD_ARTICULO.VisibleIndex = 8;
            // 
            // colUNIDAD_1
            // 
            this.colUNIDAD_1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUNIDAD_1.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUNIDAD_1.AppearanceHeader.Options.UseFont = true;
            this.colUNIDAD_1.AppearanceHeader.Options.UseForeColor = true;
            this.colUNIDAD_1.Caption = "Unidad1";
            this.colUNIDAD_1.FieldName = "UNIDAD_1";
            this.colUNIDAD_1.Name = "colUNIDAD_1";
            this.colUNIDAD_1.OptionsColumn.ReadOnly = true;
            this.colUNIDAD_1.Visible = true;
            this.colUNIDAD_1.VisibleIndex = 9;
            // 
            // colUNIDAD_2
            // 
            this.colUNIDAD_2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUNIDAD_2.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUNIDAD_2.AppearanceHeader.Options.UseFont = true;
            this.colUNIDAD_2.AppearanceHeader.Options.UseForeColor = true;
            this.colUNIDAD_2.Caption = "Unidad2";
            this.colUNIDAD_2.FieldName = "UNIDAD_2";
            this.colUNIDAD_2.Name = "colUNIDAD_2";
            this.colUNIDAD_2.OptionsColumn.ReadOnly = true;
            this.colUNIDAD_2.Visible = true;
            this.colUNIDAD_2.VisibleIndex = 10;
            // 
            // colUSER_1
            // 
            this.colUSER_1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_1.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_1.AppearanceHeader.Options.UseFont = true;
            this.colUSER_1.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_1.Caption = "User 1";
            this.colUSER_1.FieldName = "USER_1";
            this.colUSER_1.Name = "colUSER_1";
            this.colUSER_1.OptionsColumn.ReadOnly = true;
            this.colUSER_1.Visible = true;
            this.colUSER_1.VisibleIndex = 11;
            // 
            // colUSER_2
            // 
            this.colUSER_2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_2.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_2.AppearanceHeader.Options.UseFont = true;
            this.colUSER_2.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_2.Caption = "User 2";
            this.colUSER_2.FieldName = "USER_2";
            this.colUSER_2.Name = "colUSER_2";
            this.colUSER_2.OptionsColumn.ReadOnly = true;
            this.colUSER_2.Visible = true;
            this.colUSER_2.VisibleIndex = 12;
            // 
            // colUSER_3
            // 
            this.colUSER_3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_3.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_3.AppearanceHeader.Options.UseFont = true;
            this.colUSER_3.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_3.Caption = "User 3";
            this.colUSER_3.FieldName = "USER_3";
            this.colUSER_3.Name = "colUSER_3";
            this.colUSER_3.OptionsColumn.ReadOnly = true;
            this.colUSER_3.Visible = true;
            this.colUSER_3.VisibleIndex = 13;
            // 
            // colUSER_4
            // 
            this.colUSER_4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_4.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_4.AppearanceHeader.Options.UseFont = true;
            this.colUSER_4.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_4.Caption = "User 4";
            this.colUSER_4.FieldName = "USER_4";
            this.colUSER_4.Name = "colUSER_4";
            this.colUSER_4.OptionsColumn.ReadOnly = true;
            this.colUSER_4.Visible = true;
            this.colUSER_4.VisibleIndex = 14;
            // 
            // colUSER_5
            // 
            this.colUSER_5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_5.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_5.AppearanceHeader.Options.UseFont = true;
            this.colUSER_5.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_5.Caption = "User 5";
            this.colUSER_5.FieldName = "USER_5";
            this.colUSER_5.Name = "colUSER_5";
            this.colUSER_5.OptionsColumn.ReadOnly = true;
            this.colUSER_5.Visible = true;
            this.colUSER_5.VisibleIndex = 15;
            // 
            // colUSER_6
            // 
            this.colUSER_6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_6.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_6.AppearanceHeader.Options.UseFont = true;
            this.colUSER_6.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_6.Caption = "User 6";
            this.colUSER_6.FieldName = "USER_6";
            this.colUSER_6.Name = "colUSER_6";
            this.colUSER_6.OptionsColumn.ReadOnly = true;
            this.colUSER_6.Visible = true;
            this.colUSER_6.VisibleIndex = 16;
            // 
            // colUSER_7
            // 
            this.colUSER_7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_7.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_7.AppearanceHeader.Options.UseFont = true;
            this.colUSER_7.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_7.Caption = "User 7";
            this.colUSER_7.FieldName = "USER_7";
            this.colUSER_7.Name = "colUSER_7";
            this.colUSER_7.OptionsColumn.ReadOnly = true;
            this.colUSER_7.Visible = true;
            this.colUSER_7.VisibleIndex = 17;
            // 
            // colUSER_8
            // 
            this.colUSER_8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_8.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_8.AppearanceHeader.Options.UseFont = true;
            this.colUSER_8.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_8.Caption = "User 8";
            this.colUSER_8.FieldName = "USER_8";
            this.colUSER_8.Name = "colUSER_8";
            this.colUSER_8.OptionsColumn.ReadOnly = true;
            this.colUSER_8.Visible = true;
            this.colUSER_8.VisibleIndex = 18;
            // 
            // colUSER_9
            // 
            this.colUSER_9.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_9.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_9.AppearanceHeader.Options.UseFont = true;
            this.colUSER_9.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_9.Caption = "User 9";
            this.colUSER_9.FieldName = "USER_9";
            this.colUSER_9.Name = "colUSER_9";
            this.colUSER_9.OptionsColumn.ReadOnly = true;
            this.colUSER_9.Visible = true;
            this.colUSER_9.VisibleIndex = 19;
            // 
            // colUSER_10
            // 
            this.colUSER_10.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUSER_10.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUSER_10.AppearanceHeader.Options.UseFont = true;
            this.colUSER_10.AppearanceHeader.Options.UseForeColor = true;
            this.colUSER_10.Caption = "User 10";
            this.colUSER_10.FieldName = "USER_10";
            this.colUSER_10.Name = "colUSER_10";
            this.colUSER_10.OptionsColumn.ReadOnly = true;
            this.colUSER_10.Visible = true;
            this.colUSER_10.VisibleIndex = 20;
            // 
            // colENCONTRADO
            // 
            this.colENCONTRADO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colENCONTRADO.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colENCONTRADO.AppearanceHeader.Options.UseFont = true;
            this.colENCONTRADO.AppearanceHeader.Options.UseForeColor = true;
            this.colENCONTRADO.Caption = "Encontrado";
            this.colENCONTRADO.FieldName = "ENCONTRADO";
            this.colENCONTRADO.Name = "colENCONTRADO";
            this.colENCONTRADO.OptionsColumn.ReadOnly = true;
            // 
            // colACTIVO
            // 
            this.colACTIVO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colACTIVO.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colACTIVO.AppearanceHeader.Options.UseFont = true;
            this.colACTIVO.AppearanceHeader.Options.UseForeColor = true;
            this.colACTIVO.Caption = "Activo";
            this.colACTIVO.FieldName = "ACTIVO";
            this.colACTIVO.Name = "colACTIVO";
            this.colACTIVO.Visible = true;
            this.colACTIVO.VisibleIndex = 21;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.btn_borrar_det);
            this.groupControl2.Controls.Add(this.btn_guardar_det);
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Location = new System.Drawing.Point(889, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(261, 394);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Detalle";
            // 
            // btn_borrar_det
            // 
            this.btn_borrar_det.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar_det.Image")));
            this.btn_borrar_det.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_borrar_det.Location = new System.Drawing.Point(185, 26);
            this.btn_borrar_det.Name = "btn_borrar_det";
            this.btn_borrar_det.Size = new System.Drawing.Size(32, 30);
            this.btn_borrar_det.TabIndex = 3;
            this.btn_borrar_det.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_guardar_det
            // 
            this.btn_guardar_det.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar_det.Image")));
            this.btn_guardar_det.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_guardar_det.Location = new System.Drawing.Point(223, 26);
            this.btn_guardar_det.Name = "btn_guardar_det";
            this.btn_guardar_det.Size = new System.Drawing.Size(33, 30);
            this.btn_guardar_det.TabIndex = 2;
            this.btn_guardar_det.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.bRCDETALLETAGSENTARIMADOBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(5, 26);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(251, 363);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bRCDETALLETAGSENTARIMADOBindingSource
            // 
            this.bRCDETALLETAGSENTARIMADOBindingSource.DataMember = "BRC_DETALLE_TAGS_ENTARIMADO";
            this.bRCDETALLETAGSENTARIMADOBindingSource.DataSource = this.dataSetDetalleEntarimado;
            // 
            // dataSetDetalleEntarimado
            // 
            this.dataSetDetalleEntarimado.DataSetName = "DataSetDetalleEntarimado";
            this.dataSetDetalleEntarimado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_TAGS,
            this.colID_ENC_TAGS1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            // 
            // colID_TAGS
            // 
            this.colID_TAGS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_TAGS.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_TAGS.AppearanceHeader.Options.UseFont = true;
            this.colID_TAGS.AppearanceHeader.Options.UseForeColor = true;
            this.colID_TAGS.Caption = "Tag";
            this.colID_TAGS.FieldName = "ID_TAGS";
            this.colID_TAGS.Name = "colID_TAGS";
            this.colID_TAGS.Visible = true;
            this.colID_TAGS.VisibleIndex = 1;
            // 
            // colID_ENC_TAGS1
            // 
            this.colID_ENC_TAGS1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_ENC_TAGS1.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_ENC_TAGS1.AppearanceHeader.Options.UseFont = true;
            this.colID_ENC_TAGS1.AppearanceHeader.Options.UseForeColor = true;
            this.colID_ENC_TAGS1.Caption = "Tarima";
            this.colID_ENC_TAGS1.FieldName = "ID_ENC_TAGS";
            this.colID_ENC_TAGS1.Name = "colID_ENC_TAGS1";
            this.colID_ENC_TAGS1.Visible = true;
            this.colID_ENC_TAGS1.VisibleIndex = 0;
            // 
            // bRC_ENCABEZADO_TAGSTableAdapter
            // 
            this.bRC_ENCABEZADO_TAGSTableAdapter.ClearBeforeFill = true;
            // 
            // bRC_DETALLE_TAGS_ENTARIMADOTableAdapter
            // 
            this.bRC_DETALLE_TAGS_ENTARIMADOTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleTarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 418);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleTarimas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Tarimas";
            this.Load += new System.EventHandler(this.DetalleTarimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCENCABEZADOTAGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEncabezadoTarima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCDETALLETAGSENTARIMADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleEntarimado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DA.DataSetEncabezadoTarima dataSetEncabezadoTarima;
        private System.Windows.Forms.BindingSource bRCENCABEZADOTAGSBindingSource;
        private DA.DataSetEncabezadoTarimaTableAdapters.BRC_ENCABEZADO_TAGSTableAdapter bRC_ENCABEZADO_TAGSTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ENC_TAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA_TRANSACCION;
        private DevExpress.XtraGrid.Columns.GridColumn colTURNO;
        private DevExpress.XtraGrid.Columns.GridColumn colUSUARIO_CREO;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA_CREACION;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TIPO_PLANTILLA;
        private DevExpress.XtraGrid.Columns.GridColumn colID_MAQUINA;
        private DevExpress.XtraGrid.Columns.GridColumn colOP;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIDAD_1;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIDAD_2;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_1;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_2;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_3;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_4;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_5;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_6;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_7;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_8;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_9;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_10;
        private DevExpress.XtraGrid.Columns.GridColumn colENCONTRADO;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVO;
        private DA.DataSetDetalleEntarimado dataSetDetalleEntarimado;
        private System.Windows.Forms.BindingSource bRCDETALLETAGSENTARIMADOBindingSource;
        private DA.DataSetDetalleEntarimadoTableAdapters.BRC_DETALLE_TAGS_ENTARIMADOTableAdapter bRC_DETALLE_TAGS_ENTARIMADOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ENC_TAGS1;
        private DevExpress.XtraEditors.SimpleButton btn_guardar_enc;
        private DevExpress.XtraEditors.SimpleButton btn_borrar_det;
        private DevExpress.XtraEditors.SimpleButton btn_guardar_det;
        private DevExpress.XtraEditors.SimpleButton btn_imp_enc;
    }
}