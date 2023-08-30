namespace brc_tags
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_TAGSLabel;
            System.Windows.Forms.Label fECHA_TRANSACCIONLabel;
            System.Windows.Forms.Label tURNOLabel;
            System.Windows.Forms.Label uSUARIO_CREOLabel;
            System.Windows.Forms.Label fECHA_CREACIONLabel;
            System.Windows.Forms.Label iD_TIPO_PLANTILLALabel;
            System.Windows.Forms.Label iD_MAQUINALabel;
            System.Windows.Forms.Label oPLabel;
            System.Windows.Forms.Label cOD_ARTICULOLabel;
            System.Windows.Forms.Label aCTIVOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraPrinting.BarCode.EAN128Generator eaN128Generator1 = new DevExpress.XtraPrinting.BarCode.EAN128Generator();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.lst_tipo_plantilla = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.txt_no_copias = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.lst_fecha = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ctrlTitulo1 = new BltCtr.CtrlTituloFrm();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sPBRCOBTENERTAGSTIPOPLANTILLABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEncabezado = new brc_tags.DA.DataSetEncabezado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_TAGS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colACTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bRCTAGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTags = new brc_tags.DA.DataSetTags();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_units = new DevExpress.XtraEditors.SimpleButton();
            this.btn_part = new DevExpress.XtraEditors.SimpleButton();
            this.btn_detalle_tarimas = new DevExpress.XtraEditors.SimpleButton();
            this.btn_entarimar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_kls = new DevExpress.XtraEditors.LabelControl();
            this.lbl_unidad_2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_unidad_1 = new DevExpress.XtraEditors.LabelControl();
            this.lst_operador = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.iD_OPERADORSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user10 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user9 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user8 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user7 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user6 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user4 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_user1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.brc_tags = new DevExpress.XtraEditors.BarCodeControl();
            this.chk_activo = new DevExpress.XtraEditors.CheckEdit();
            this.txt_user10 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user9 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user8 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user7 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user6 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user5 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user4 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_user1 = new DevExpress.XtraEditors.TextEdit();
            this.lst_unidad2 = new DevExpress.XtraEditors.TextEdit();
            this.lst_unidad1 = new DevExpress.XtraEditors.TextEdit();
            this.lst_articulo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cOD_ARTICULOSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lst_op = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.oPSearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lst_maquina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.iD_MAQUINASearchLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_tipo_plantilla = new DevExpress.XtraEditors.TextEdit();
            this.lst_fecha_creacion = new DevExpress.XtraEditors.DateEdit();
            this.txt_usuario_creo = new DevExpress.XtraEditors.TextEdit();
            this.lst_turno = new DevExpress.XtraEditors.LookUpEdit();
            this.lst_fecha_transaccion = new DevExpress.XtraEditors.DateEdit();
            this.txt_tag = new DevExpress.XtraEditors.TextEdit();
            this.txt_user3 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bRC_TAGSTableAdapter = new brc_tags.DA.DataSetTagsTableAdapters.BRC_TAGSTableAdapter();
            this.tableAdapterManager = new brc_tags.DA.DataSetTagsTableAdapters.TableAdapterManager();
            this.sp1 = new System.IO.Ports.SerialPort(this.components);
            this.tm_lectura = new System.Windows.Forms.Timer(this.components);
            this.sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter = new brc_tags.DA.DataSetEncabezadoTableAdapters.SP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter();
            iD_TAGSLabel = new System.Windows.Forms.Label();
            fECHA_TRANSACCIONLabel = new System.Windows.Forms.Label();
            tURNOLabel = new System.Windows.Forms.Label();
            uSUARIO_CREOLabel = new System.Windows.Forms.Label();
            fECHA_CREACIONLabel = new System.Windows.Forms.Label();
            iD_TIPO_PLANTILLALabel = new System.Windows.Forms.Label();
            iD_MAQUINALabel = new System.Windows.Forms.Label();
            oPLabel = new System.Windows.Forms.Label();
            cOD_ARTICULOLabel = new System.Windows.Forms.Label();
            aCTIVOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBRCOBTENERTAGSTIPOPLANTILLABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCTAGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_operador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_OPERADORSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_activo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_unidad2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_unidad1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_articulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOD_ARTICULOSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_op.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_maquina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_MAQUINASearchLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tipo_plantilla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_creacion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_creacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario_creo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_turno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_transaccion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_transaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TAGSLabel
            // 
            iD_TAGSLabel.AutoSize = true;
            iD_TAGSLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            iD_TAGSLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            iD_TAGSLabel.Location = new System.Drawing.Point(100, 32);
            iD_TAGSLabel.Name = "iD_TAGSLabel";
            iD_TAGSLabel.Size = new System.Drawing.Size(36, 16);
            iD_TAGSLabel.TabIndex = 0;
            iD_TAGSLabel.Text = "Tag:";
            // 
            // fECHA_TRANSACCIONLabel
            // 
            fECHA_TRANSACCIONLabel.AutoSize = true;
            fECHA_TRANSACCIONLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            fECHA_TRANSACCIONLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            fECHA_TRANSACCIONLabel.Location = new System.Drawing.Point(5, 70);
            fECHA_TRANSACCIONLabel.Name = "fECHA_TRANSACCIONLabel";
            fECHA_TRANSACCIONLabel.Size = new System.Drawing.Size(131, 16);
            fECHA_TRANSACCIONLabel.TabIndex = 2;
            fECHA_TRANSACCIONLabel.Text = "Fecha Transaccion:";
            // 
            // tURNOLabel
            // 
            tURNOLabel.AutoSize = true;
            tURNOLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            tURNOLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            tURNOLabel.Location = new System.Drawing.Point(86, 108);
            tURNOLabel.Name = "tURNOLabel";
            tURNOLabel.Size = new System.Drawing.Size(50, 16);
            tURNOLabel.TabIndex = 4;
            tURNOLabel.Text = "Turno:";
            // 
            // uSUARIO_CREOLabel
            // 
            uSUARIO_CREOLabel.AutoSize = true;
            uSUARIO_CREOLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            uSUARIO_CREOLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            uSUARIO_CREOLabel.Location = new System.Drawing.Point(41, 146);
            uSUARIO_CREOLabel.Name = "uSUARIO_CREOLabel";
            uSUARIO_CREOLabel.Size = new System.Drawing.Size(95, 16);
            uSUARIO_CREOLabel.TabIndex = 6;
            uSUARIO_CREOLabel.Text = "Usuario Creo:";
            // 
            // fECHA_CREACIONLabel
            // 
            fECHA_CREACIONLabel.AutoSize = true;
            fECHA_CREACIONLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            fECHA_CREACIONLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            fECHA_CREACIONLabel.Location = new System.Drawing.Point(26, 184);
            fECHA_CREACIONLabel.Name = "fECHA_CREACIONLabel";
            fECHA_CREACIONLabel.Size = new System.Drawing.Size(110, 16);
            fECHA_CREACIONLabel.TabIndex = 8;
            fECHA_CREACIONLabel.Text = "Fecha Creacion:";
            // 
            // iD_TIPO_PLANTILLALabel
            // 
            iD_TIPO_PLANTILLALabel.AutoSize = true;
            iD_TIPO_PLANTILLALabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            iD_TIPO_PLANTILLALabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            iD_TIPO_PLANTILLALabel.Location = new System.Drawing.Point(43, 222);
            iD_TIPO_PLANTILLALabel.Name = "iD_TIPO_PLANTILLALabel";
            iD_TIPO_PLANTILLALabel.Size = new System.Drawing.Size(93, 16);
            iD_TIPO_PLANTILLALabel.TabIndex = 10;
            iD_TIPO_PLANTILLALabel.Text = "Tipo Plantilla:";
            // 
            // iD_MAQUINALabel
            // 
            iD_MAQUINALabel.AutoSize = true;
            iD_MAQUINALabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            iD_MAQUINALabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            iD_MAQUINALabel.Location = new System.Drawing.Point(607, 338);
            iD_MAQUINALabel.Name = "iD_MAQUINALabel";
            iD_MAQUINALabel.Size = new System.Drawing.Size(67, 16);
            iD_MAQUINALabel.TabIndex = 12;
            iD_MAQUINALabel.Text = "Maquina:";
            iD_MAQUINALabel.Visible = false;
            // 
            // oPLabel
            // 
            oPLabel.AutoSize = true;
            oPLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            oPLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            oPLabel.Location = new System.Drawing.Point(610, 377);
            oPLabel.Name = "oPLabel";
            oPLabel.Size = new System.Drawing.Size(30, 16);
            oPLabel.TabIndex = 14;
            oPLabel.Text = "OP:";
            oPLabel.Visible = false;
            // 
            // cOD_ARTICULOLabel
            // 
            cOD_ARTICULOLabel.AutoSize = true;
            cOD_ARTICULOLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            cOD_ARTICULOLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            cOD_ARTICULOLabel.Location = new System.Drawing.Point(72, 260);
            cOD_ARTICULOLabel.Name = "cOD_ARTICULOLabel";
            cOD_ARTICULOLabel.Size = new System.Drawing.Size(64, 16);
            cOD_ARTICULOLabel.TabIndex = 16;
            cOD_ARTICULOLabel.Text = "Articulo:";
            // 
            // aCTIVOLabel
            // 
            aCTIVOLabel.AutoSize = true;
            aCTIVOLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            aCTIVOLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            aCTIVOLabel.Location = new System.Drawing.Point(81, 411);
            aCTIVOLabel.Name = "aCTIVOLabel";
            aCTIVOLabel.Size = new System.Drawing.Size(55, 16);
            aCTIVOLabel.TabIndex = 43;
            aCTIVOLabel.Text = "Activo:";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.lst_tipo_plantilla,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.txt_no_copias,
            this.barButtonItem15,
            this.lst_fecha,
            this.barButtonItem16,
            this.barButtonItem17,
            this.barButtonItem18,
            this.barButtonItem19});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(1199, 141);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Primero";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Anterior";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Siguiente";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Ultimo";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Nuevo Tag Manual";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Cancelar";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Borrar";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Guardar";
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.barButtonItem8.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Salir";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Operador Temporal";
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // lst_tipo_plantilla
            // 
            this.lst_tipo_plantilla.Caption = "Plantilla:";
            this.lst_tipo_plantilla.Edit = this.repositoryItemLookUpEdit1;
            this.lst_tipo_plantilla.EditWidth = 130;
            this.lst_tipo_plantilla.Id = 11;
            this.lst_tipo_plantilla.Name = "lst_tipo_plantilla";
            this.lst_tipo_plantilla.EditValueChanged += new System.EventHandler(this.lst_tipo_plantilla_EditValueChanged);
            this.lst_tipo_plantilla.HiddenEditor += new DevExpress.XtraBars.ItemClickEventHandler(this.lst_tipo_plantilla_HiddenEditor);
            this.lst_tipo_plantilla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lst_tipo_plantilla_ItemClick);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Buscar";
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.LargeGlyph")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Editar";
            this.barButtonItem12.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.Glyph")));
            this.barButtonItem12.Id = 13;
            this.barButtonItem12.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.barButtonItem12.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.LargeGlyph")));
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Imprimir Tag";
            this.barButtonItem13.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.Glyph")));
            this.barButtonItem13.Id = 14;
            this.barButtonItem13.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.barButtonItem13.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.LargeGlyph")));
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Imprimir \r\nTags \r\nSelec";
            this.barButtonItem14.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.Glyph")));
            this.barButtonItem14.Id = 15;
            this.barButtonItem14.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.LargeGlyph")));
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // txt_no_copias
            // 
            this.txt_no_copias.Caption = "No Copias:";
            this.txt_no_copias.Edit = this.repositoryItemTextEdit1;
            this.txt_no_copias.EditWidth = 30;
            this.txt_no_copias.Id = 16;
            this.txt_no_copias.Name = "txt_no_copias";
            this.txt_no_copias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.txt_no_copias_ItemClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Nuevo Tag Automatico";
            this.barButtonItem15.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.Glyph")));
            this.barButtonItem15.Id = 17;
            this.barButtonItem15.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.barButtonItem15.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.LargeGlyph")));
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
            // 
            // lst_fecha
            // 
            this.lst_fecha.Caption = "Fecha:  ";
            this.lst_fecha.Edit = this.repositoryItemDateEdit1;
            this.lst_fecha.EditWidth = 130;
            this.lst_fecha.Id = 18;
            this.lst_fecha.Name = "lst_fecha";
            this.lst_fecha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lst_fecha_ItemClick);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Obtener Dato Pesa";
            this.barButtonItem16.Id = 19;
            this.barButtonItem16.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barButtonItem16.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem16.LargeGlyph")));
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Tgs \r\nConsecutivos";
            this.barButtonItem17.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.Glyph")));
            this.barButtonItem17.Id = 20;
            this.barButtonItem17.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem17.LargeGlyph")));
            this.barButtonItem17.Name = "barButtonItem17";
            this.barButtonItem17.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem17_ItemClick);
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Imp Tags Consecutivos";
            this.barButtonItem18.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.Glyph")));
            this.barButtonItem18.Id = 21;
            this.barButtonItem18.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem18.LargeGlyph")));
            this.barButtonItem18.Name = "barButtonItem18";
            this.barButtonItem18.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem18_ItemClick);
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Caption = "Crear Articulo";
            this.barButtonItem19.Id = 23;
            this.barButtonItem19.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.barButtonItem19.LargeGlyph = global::brc_tags.Properties.Resources.PART;
            this.barButtonItem19.Name = "barButtonItem19";
            this.barButtonItem19.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem19_ItemClick_1);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Editar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Navegacion";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem16);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem17);
            this.ribbonPageGroup2.ItemLinks.Add(this.lst_fecha);
            this.ribbonPageGroup2.ItemLinks.Add(this.lst_tipo_plantilla);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup2.ItemLinks.Add(this.txt_no_copias, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem19);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Acciones";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ctrlTitulo1
            // 
            this.ctrlTitulo1.AppTitulo1 = "Usuario:";
            this.ctrlTitulo1.AppTitulo2 = "Conexion:";
            this.ctrlTitulo1.AppTitulo3 = "Fecha:";
            this.ctrlTitulo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTitulo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlTitulo1.Location = new System.Drawing.Point(0, 631);
            this.ctrlTitulo1.Name = "ctrlTitulo1";
            this.ctrlTitulo1.Size = new System.Drawing.Size(1199, 70);
            this.ctrlTitulo1.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 147);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(464, 478);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Lista Tags";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = this.sPBRCOBTENERTAGSTIPOPLANTILLABindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(454, 447);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPBRCOBTENERTAGSTIPOPLANTILLABindingSource
            // 
            this.sPBRCOBTENERTAGSTIPOPLANTILLABindingSource.DataMember = "SP_BRC_OBTENER_TAGS_TIPO_PLANTILLA";
            this.sPBRCOBTENERTAGSTIPOPLANTILLABindingSource.DataSource = this.dataSetEncabezado;
            // 
            // dataSetEncabezado
            // 
            this.dataSetEncabezado.DataSetName = "DataSetEncabezado";
            this.dataSetEncabezado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_TAGS,
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
            this.colACTIVO,
            this.colUSER_6,
            this.colUSER_7,
            this.colUSER_8,
            this.colUSER_9,
            this.colUSER_10});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged_1);
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
            this.colID_TAGS.OptionsColumn.ReadOnly = true;
            this.colID_TAGS.Visible = true;
            this.colID_TAGS.VisibleIndex = 0;
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
            this.colTURNO.Width = 46;
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
            this.colUSUARIO_CREO.VisibleIndex = 6;
            // 
            // colFECHA_CREACION
            // 
            this.colFECHA_CREACION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colFECHA_CREACION.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colFECHA_CREACION.AppearanceHeader.Options.UseFont = true;
            this.colFECHA_CREACION.AppearanceHeader.Options.UseForeColor = true;
            this.colFECHA_CREACION.Caption = "Fecha Creacion";
            this.colFECHA_CREACION.FieldName = "FECHA_CREACION";
            this.colFECHA_CREACION.Name = "colFECHA_CREACION";
            this.colFECHA_CREACION.OptionsColumn.ReadOnly = true;
            // 
            // colID_TIPO_PLANTILLA
            // 
            this.colID_TIPO_PLANTILLA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_TIPO_PLANTILLA.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_TIPO_PLANTILLA.AppearanceHeader.Options.UseFont = true;
            this.colID_TIPO_PLANTILLA.AppearanceHeader.Options.UseForeColor = true;
            this.colID_TIPO_PLANTILLA.Caption = "Tipo Plantilla";
            this.colID_TIPO_PLANTILLA.FieldName = "ID_TIPO_PLANTILLA";
            this.colID_TIPO_PLANTILLA.Name = "colID_TIPO_PLANTILLA";
            this.colID_TIPO_PLANTILLA.OptionsColumn.ReadOnly = true;
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
            this.colID_MAQUINA.VisibleIndex = 3;
            this.colID_MAQUINA.Width = 89;
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
            this.colOP.VisibleIndex = 4;
            this.colOP.Width = 78;
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
            this.colCOD_ARTICULO.VisibleIndex = 5;
            this.colCOD_ARTICULO.Width = 83;
            // 
            // colUNIDAD_1
            // 
            this.colUNIDAD_1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUNIDAD_1.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUNIDAD_1.AppearanceHeader.Options.UseFont = true;
            this.colUNIDAD_1.AppearanceHeader.Options.UseForeColor = true;
            this.colUNIDAD_1.Caption = "Unidad 1";
            this.colUNIDAD_1.FieldName = "UNIDAD_1";
            this.colUNIDAD_1.Name = "colUNIDAD_1";
            this.colUNIDAD_1.OptionsColumn.ReadOnly = true;
            // 
            // colUNIDAD_2
            // 
            this.colUNIDAD_2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUNIDAD_2.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUNIDAD_2.AppearanceHeader.Options.UseFont = true;
            this.colUNIDAD_2.AppearanceHeader.Options.UseForeColor = true;
            this.colUNIDAD_2.Caption = "Unidad 2";
            this.colUNIDAD_2.FieldName = "UNIDAD_2";
            this.colUNIDAD_2.Name = "colUNIDAD_2";
            this.colUNIDAD_2.OptionsColumn.ReadOnly = true;
            this.colUNIDAD_2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UNIDAD_2", "{0:#.##}")});
            this.colUNIDAD_2.Visible = true;
            this.colUNIDAD_2.VisibleIndex = 7;
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
            this.colACTIVO.OptionsColumn.ReadOnly = true;
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
            // 
            // bRCTAGSBindingSource
            // 
            this.bRCTAGSBindingSource.DataMember = "BRC_TAGS";
            this.bRCTAGSBindingSource.DataSource = this.dataSetTags;
            // 
            // dataSetTags
            // 
            this.dataSetTags.DataSetName = "DataSetTags";
            this.dataSetTags.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupControl2.Controls.Add(this.btn_units);
            this.groupControl2.Controls.Add(this.btn_part);
            this.groupControl2.Controls.Add(this.btn_detalle_tarimas);
            this.groupControl2.Controls.Add(this.btn_entarimar);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.lbl_kls);
            this.groupControl2.Controls.Add(this.lbl_unidad_2);
            this.groupControl2.Controls.Add(this.lbl_unidad_1);
            this.groupControl2.Controls.Add(this.lst_operador);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.lbl_user10);
            this.groupControl2.Controls.Add(this.lbl_user9);
            this.groupControl2.Controls.Add(this.lbl_user8);
            this.groupControl2.Controls.Add(this.lbl_user7);
            this.groupControl2.Controls.Add(this.lbl_user6);
            this.groupControl2.Controls.Add(this.lbl_user5);
            this.groupControl2.Controls.Add(this.lbl_user4);
            this.groupControl2.Controls.Add(this.lbl_user3);
            this.groupControl2.Controls.Add(this.lbl_user2);
            this.groupControl2.Controls.Add(this.lbl_user1);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.brc_tags);
            this.groupControl2.Controls.Add(aCTIVOLabel);
            this.groupControl2.Controls.Add(this.chk_activo);
            this.groupControl2.Controls.Add(this.txt_user10);
            this.groupControl2.Controls.Add(this.txt_user9);
            this.groupControl2.Controls.Add(this.txt_user8);
            this.groupControl2.Controls.Add(this.txt_user7);
            this.groupControl2.Controls.Add(this.txt_user6);
            this.groupControl2.Controls.Add(this.txt_user5);
            this.groupControl2.Controls.Add(this.txt_user4);
            this.groupControl2.Controls.Add(this.txt_user2);
            this.groupControl2.Controls.Add(this.txt_user1);
            this.groupControl2.Controls.Add(this.lst_unidad2);
            this.groupControl2.Controls.Add(this.lst_unidad1);
            this.groupControl2.Controls.Add(cOD_ARTICULOLabel);
            this.groupControl2.Controls.Add(this.lst_articulo);
            this.groupControl2.Controls.Add(oPLabel);
            this.groupControl2.Controls.Add(this.lst_op);
            this.groupControl2.Controls.Add(iD_MAQUINALabel);
            this.groupControl2.Controls.Add(this.lst_maquina);
            this.groupControl2.Controls.Add(iD_TIPO_PLANTILLALabel);
            this.groupControl2.Controls.Add(this.txt_tipo_plantilla);
            this.groupControl2.Controls.Add(fECHA_CREACIONLabel);
            this.groupControl2.Controls.Add(this.lst_fecha_creacion);
            this.groupControl2.Controls.Add(uSUARIO_CREOLabel);
            this.groupControl2.Controls.Add(this.txt_usuario_creo);
            this.groupControl2.Controls.Add(tURNOLabel);
            this.groupControl2.Controls.Add(this.lst_turno);
            this.groupControl2.Controls.Add(fECHA_TRANSACCIONLabel);
            this.groupControl2.Controls.Add(this.lst_fecha_transaccion);
            this.groupControl2.Controls.Add(iD_TAGSLabel);
            this.groupControl2.Controls.Add(this.txt_tag);
            this.groupControl2.Controls.Add(this.txt_user3);
            this.groupControl2.Location = new System.Drawing.Point(478, 147);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(715, 478);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Detalle Tags";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // btn_units
            // 
            this.btn_units.Image = global::brc_tags.Properties.Resources.UNITS64;
            this.btn_units.Location = new System.Drawing.Point(516, 280);
            this.btn_units.Name = "btn_units";
            this.btn_units.Size = new System.Drawing.Size(75, 74);
            this.btn_units.TabIndex = 68;
            this.btn_units.Text = "simpleButton3";
            this.btn_units.Click += new System.EventHandler(this.btn_units_Click);
            // 
            // btn_part
            // 
            this.btn_part.Image = global::brc_tags.Properties.Resources.PART64;
            this.btn_part.Location = new System.Drawing.Point(454, 205);
            this.btn_part.Name = "btn_part";
            this.btn_part.Size = new System.Drawing.Size(73, 74);
            this.btn_part.TabIndex = 67;
            this.btn_part.Click += new System.EventHandler(this.btn_part_Click);
            // 
            // btn_detalle_tarimas
            // 
            this.btn_detalle_tarimas.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalle_tarimas.Appearance.Options.UseFont = true;
            this.btn_detalle_tarimas.Image = ((System.Drawing.Image)(resources.GetObject("btn_detalle_tarimas.Image")));
            this.btn_detalle_tarimas.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_detalle_tarimas.Location = new System.Drawing.Point(690, 34);
            this.btn_detalle_tarimas.Name = "btn_detalle_tarimas";
            this.btn_detalle_tarimas.Size = new System.Drawing.Size(45, 33);
            this.btn_detalle_tarimas.TabIndex = 66;
            this.btn_detalle_tarimas.Text = "Detalle Tarimas";
            this.btn_detalle_tarimas.Visible = false;
            this.btn_detalle_tarimas.Click += new System.EventHandler(this.btn_detalle_tarimas_Click);
            // 
            // btn_entarimar
            // 
            this.btn_entarimar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entarimar.Appearance.Options.UseFont = true;
            this.btn_entarimar.Image = ((System.Drawing.Image)(resources.GetObject("btn_entarimar.Image")));
            this.btn_entarimar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_entarimar.Location = new System.Drawing.Point(639, 21);
            this.btn_entarimar.Name = "btn_entarimar";
            this.btn_entarimar.Size = new System.Drawing.Size(45, 45);
            this.btn_entarimar.TabIndex = 65;
            this.btn_entarimar.Text = "Entarimar";
            this.btn_entarimar.Visible = false;
            this.btn_entarimar.Click += new System.EventHandler(this.btn_entarimar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(454, 285);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(42, 45);
            this.simpleButton1.TabIndex = 64;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // lbl_kls
            // 
            this.lbl_kls.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kls.Location = new System.Drawing.Point(265, 346);
            this.lbl_kls.Name = "lbl_kls";
            this.lbl_kls.Size = new System.Drawing.Size(89, 58);
            this.lbl_kls.TabIndex = 63;
            this.lbl_kls.Text = "Kls:";
            // 
            // lbl_unidad_2
            // 
            this.lbl_unidad_2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_unidad_2.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_unidad_2.Location = new System.Drawing.Point(76, 374);
            this.lbl_unidad_2.Name = "lbl_unidad_2";
            this.lbl_unidad_2.Size = new System.Drawing.Size(60, 16);
            this.lbl_unidad_2.TabIndex = 62;
            this.lbl_unidad_2.Text = "Unidad 2:";
            // 
            // lbl_unidad_1
            // 
            this.lbl_unidad_1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_unidad_1.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_unidad_1.Location = new System.Drawing.Point(76, 336);
            this.lbl_unidad_1.Name = "lbl_unidad_1";
            this.lbl_unidad_1.Size = new System.Drawing.Size(60, 16);
            this.lbl_unidad_1.TabIndex = 61;
            this.lbl_unidad_1.Text = "Unidad 1:";
            // 
            // lst_operador
            // 
            this.lst_operador.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "ID_OPERADOR", true));
            this.lst_operador.Location = new System.Drawing.Point(142, 294);
            this.lst_operador.MenuManager = this.ribbonControl1;
            this.lst_operador.Name = "lst_operador";
            this.lst_operador.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_operador.Properties.Appearance.Options.UseFont = true;
            this.lst_operador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_operador.Properties.View = this.iD_OPERADORSearchLookUpEditView;
            this.lst_operador.Size = new System.Drawing.Size(302, 20);
            this.lst_operador.TabIndex = 7;
            this.lst_operador.EditValueChanged += new System.EventHandler(this.lst_operador_EditValueChanged);
            // 
            // iD_OPERADORSearchLookUpEditView
            // 
            this.iD_OPERADORSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.iD_OPERADORSearchLookUpEditView.Name = "iD_OPERADORSearchLookUpEditView";
            this.iD_OPERADORSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.iD_OPERADORSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelControl2.Location = new System.Drawing.Point(70, 298);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 16);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Operador:";
            // 
            // lbl_user10
            // 
            this.lbl_user10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user10.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user10.Location = new System.Drawing.Point(473, 179);
            this.lbl_user10.Name = "lbl_user10";
            this.lbl_user10.Size = new System.Drawing.Size(54, 16);
            this.lbl_user10.TabIndex = 56;
            this.lbl_user10.Text = "User 10:";
            // 
            // lbl_user9
            // 
            this.lbl_user9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user9.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user9.Location = new System.Drawing.Point(481, 139);
            this.lbl_user9.Name = "lbl_user9";
            this.lbl_user9.Size = new System.Drawing.Size(46, 16);
            this.lbl_user9.TabIndex = 55;
            this.lbl_user9.Text = "User 9:";
            // 
            // lbl_user8
            // 
            this.lbl_user8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user8.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user8.Location = new System.Drawing.Point(481, 105);
            this.lbl_user8.Name = "lbl_user8";
            this.lbl_user8.Size = new System.Drawing.Size(46, 16);
            this.lbl_user8.TabIndex = 54;
            this.lbl_user8.Text = "User 8:";
            // 
            // lbl_user7
            // 
            this.lbl_user7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user7.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user7.Location = new System.Drawing.Point(481, 68);
            this.lbl_user7.Name = "lbl_user7";
            this.lbl_user7.Size = new System.Drawing.Size(46, 16);
            this.lbl_user7.TabIndex = 53;
            this.lbl_user7.Text = "User 7:";
            // 
            // lbl_user6
            // 
            this.lbl_user6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user6.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user6.Location = new System.Drawing.Point(481, 31);
            this.lbl_user6.Name = "lbl_user6";
            this.lbl_user6.Size = new System.Drawing.Size(46, 16);
            this.lbl_user6.TabIndex = 52;
            this.lbl_user6.Text = "User 6:";
            // 
            // lbl_user5
            // 
            this.lbl_user5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user5.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user5.Location = new System.Drawing.Point(295, 180);
            this.lbl_user5.Name = "lbl_user5";
            this.lbl_user5.Size = new System.Drawing.Size(46, 16);
            this.lbl_user5.TabIndex = 51;
            this.lbl_user5.Text = "User 5:";
            // 
            // lbl_user4
            // 
            this.lbl_user4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user4.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user4.Location = new System.Drawing.Point(295, 140);
            this.lbl_user4.Name = "lbl_user4";
            this.lbl_user4.Size = new System.Drawing.Size(46, 16);
            this.lbl_user4.TabIndex = 50;
            this.lbl_user4.Text = "User 4:";
            // 
            // lbl_user3
            // 
            this.lbl_user3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user3.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user3.Location = new System.Drawing.Point(295, 106);
            this.lbl_user3.Name = "lbl_user3";
            this.lbl_user3.Size = new System.Drawing.Size(46, 16);
            this.lbl_user3.TabIndex = 49;
            this.lbl_user3.Text = "User 3:";
            // 
            // lbl_user2
            // 
            this.lbl_user2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user2.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user2.Location = new System.Drawing.Point(295, 69);
            this.lbl_user2.Name = "lbl_user2";
            this.lbl_user2.Size = new System.Drawing.Size(46, 16);
            this.lbl_user2.TabIndex = 48;
            this.lbl_user2.Text = "User 2:";
            // 
            // lbl_user1
            // 
            this.lbl_user1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_user1.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_user1.Location = new System.Drawing.Point(295, 32);
            this.lbl_user1.Name = "lbl_user1";
            this.lbl_user1.Size = new System.Drawing.Size(46, 16);
            this.lbl_user1.TabIndex = 47;
            this.lbl_user1.Text = "User 1:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelControl1.Location = new System.Drawing.Point(48, 437);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Codigo Barra:";
            // 
            // brc_tags
            // 
            this.brc_tags.Location = new System.Drawing.Point(142, 437);
            this.brc_tags.Name = "brc_tags";
            this.brc_tags.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.brc_tags.Size = new System.Drawing.Size(338, 66);
            this.brc_tags.Symbology = eaN128Generator1;
            this.brc_tags.TabIndex = 45;
            // 
            // chk_activo
            // 
            this.chk_activo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "ACTIVO", true));
            this.chk_activo.Location = new System.Drawing.Point(142, 408);
            this.chk_activo.MenuManager = this.ribbonControl1;
            this.chk_activo.Name = "chk_activo";
            this.chk_activo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_activo.Properties.Appearance.Options.UseFont = true;
            this.chk_activo.Properties.Caption = "";
            this.chk_activo.Properties.DisplayValueChecked = "Y";
            this.chk_activo.Properties.DisplayValueGrayed = "-";
            this.chk_activo.Properties.DisplayValueUnchecked = "N";
            this.chk_activo.Properties.ValueChecked = "Y";
            this.chk_activo.Properties.ValueUnchecked = "N";
            this.chk_activo.Size = new System.Drawing.Size(75, 19);
            this.chk_activo.TabIndex = 12;
            // 
            // txt_user10
            // 
            this.txt_user10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_10", true));
            this.txt_user10.Location = new System.Drawing.Point(533, 176);
            this.txt_user10.MenuManager = this.ribbonControl1;
            this.txt_user10.Name = "txt_user10";
            this.txt_user10.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user10.Properties.Appearance.Options.UseFont = true;
            this.txt_user10.Size = new System.Drawing.Size(100, 20);
            this.txt_user10.TabIndex = 19;
            this.txt_user10.EditValueChanged += new System.EventHandler(this.txt_user10_EditValueChanged);
            // 
            // txt_user9
            // 
            this.txt_user9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_9", true));
            this.txt_user9.Location = new System.Drawing.Point(533, 136);
            this.txt_user9.MenuManager = this.ribbonControl1;
            this.txt_user9.Name = "txt_user9";
            this.txt_user9.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user9.Properties.Appearance.Options.UseFont = true;
            this.txt_user9.Size = new System.Drawing.Size(100, 20);
            this.txt_user9.TabIndex = 18;
            this.txt_user9.EditValueChanged += new System.EventHandler(this.txt_user9_EditValueChanged);
            // 
            // txt_user8
            // 
            this.txt_user8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_8", true));
            this.txt_user8.Location = new System.Drawing.Point(533, 102);
            this.txt_user8.MenuManager = this.ribbonControl1;
            this.txt_user8.Name = "txt_user8";
            this.txt_user8.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user8.Properties.Appearance.Options.UseFont = true;
            this.txt_user8.Size = new System.Drawing.Size(100, 20);
            this.txt_user8.TabIndex = 17;
            this.txt_user8.EditValueChanged += new System.EventHandler(this.txt_user8_EditValueChanged);
            // 
            // txt_user7
            // 
            this.txt_user7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_7", true));
            this.txt_user7.Location = new System.Drawing.Point(533, 65);
            this.txt_user7.MenuManager = this.ribbonControl1;
            this.txt_user7.Name = "txt_user7";
            this.txt_user7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user7.Properties.Appearance.Options.UseFont = true;
            this.txt_user7.Size = new System.Drawing.Size(100, 20);
            this.txt_user7.TabIndex = 16;
            this.txt_user7.EditValueChanged += new System.EventHandler(this.txt_user7_EditValueChanged);
            // 
            // txt_user6
            // 
            this.txt_user6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_6", true));
            this.txt_user6.Location = new System.Drawing.Point(533, 28);
            this.txt_user6.MenuManager = this.ribbonControl1;
            this.txt_user6.Name = "txt_user6";
            this.txt_user6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user6.Properties.Appearance.Options.UseFont = true;
            this.txt_user6.Size = new System.Drawing.Size(100, 20);
            this.txt_user6.TabIndex = 15;
            this.txt_user6.EditValueChanged += new System.EventHandler(this.txt_user6_EditValueChanged);
            // 
            // txt_user5
            // 
            this.txt_user5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_5", true));
            this.txt_user5.Location = new System.Drawing.Point(347, 176);
            this.txt_user5.MenuManager = this.ribbonControl1;
            this.txt_user5.Name = "txt_user5";
            this.txt_user5.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user5.Properties.Appearance.Options.UseFont = true;
            this.txt_user5.Size = new System.Drawing.Size(100, 20);
            this.txt_user5.TabIndex = 14;
            this.txt_user5.EditValueChanged += new System.EventHandler(this.txt_user5_EditValueChanged);
            // 
            // txt_user4
            // 
            this.txt_user4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_4", true));
            this.txt_user4.Location = new System.Drawing.Point(347, 136);
            this.txt_user4.MenuManager = this.ribbonControl1;
            this.txt_user4.Name = "txt_user4";
            this.txt_user4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user4.Properties.Appearance.Options.UseFont = true;
            this.txt_user4.Size = new System.Drawing.Size(100, 20);
            this.txt_user4.TabIndex = 13;
            this.txt_user4.EditValueChanged += new System.EventHandler(this.txt_user4_EditValueChanged);
            // 
            // txt_user2
            // 
            this.txt_user2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_2", true));
            this.txt_user2.Location = new System.Drawing.Point(347, 65);
            this.txt_user2.MenuManager = this.ribbonControl1;
            this.txt_user2.Name = "txt_user2";
            this.txt_user2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user2.Properties.Appearance.Options.UseFont = true;
            this.txt_user2.Size = new System.Drawing.Size(100, 20);
            this.txt_user2.TabIndex = 11;
            this.txt_user2.EditValueChanged += new System.EventHandler(this.txt_user2_EditValueChanged);
            // 
            // txt_user1
            // 
            this.txt_user1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_1", true));
            this.txt_user1.Location = new System.Drawing.Point(347, 28);
            this.txt_user1.MenuManager = this.ribbonControl1;
            this.txt_user1.Name = "txt_user1";
            this.txt_user1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user1.Properties.Appearance.Options.UseFont = true;
            this.txt_user1.Size = new System.Drawing.Size(100, 20);
            this.txt_user1.TabIndex = 10;
            this.txt_user1.EditValueChanged += new System.EventHandler(this.txt_user1_EditValueChanged);
            // 
            // lst_unidad2
            // 
            this.lst_unidad2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "UNIDAD_2", true));
            this.lst_unidad2.Location = new System.Drawing.Point(142, 370);
            this.lst_unidad2.MenuManager = this.ribbonControl1;
            this.lst_unidad2.Name = "lst_unidad2";
            this.lst_unidad2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_unidad2.Properties.Appearance.Options.UseFont = true;
            this.lst_unidad2.Size = new System.Drawing.Size(100, 20);
            this.lst_unidad2.TabIndex = 9;
            this.lst_unidad2.EditValueChanged += new System.EventHandler(this.uNIDAD_2TextEdit_EditValueChanged);
            // 
            // lst_unidad1
            // 
            this.lst_unidad1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "UNIDAD_1", true));
            this.lst_unidad1.Location = new System.Drawing.Point(142, 332);
            this.lst_unidad1.MenuManager = this.ribbonControl1;
            this.lst_unidad1.Name = "lst_unidad1";
            this.lst_unidad1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_unidad1.Properties.Appearance.Options.UseFont = true;
            this.lst_unidad1.Size = new System.Drawing.Size(100, 20);
            this.lst_unidad1.TabIndex = 8;
            this.lst_unidad1.EditValueChanged += new System.EventHandler(this.lst_unidad1_EditValueChanged);
            // 
            // lst_articulo
            // 
            this.lst_articulo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "COD_ARTICULO", true));
            this.lst_articulo.Location = new System.Drawing.Point(142, 256);
            this.lst_articulo.MenuManager = this.ribbonControl1;
            this.lst_articulo.Name = "lst_articulo";
            this.lst_articulo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_articulo.Properties.Appearance.Options.UseFont = true;
            this.lst_articulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_articulo.Properties.View = this.cOD_ARTICULOSearchLookUpEditView;
            this.lst_articulo.Size = new System.Drawing.Size(302, 20);
            this.lst_articulo.TabIndex = 6;
            this.lst_articulo.EditValueChanged += new System.EventHandler(this.lst_articulo_EditValueChanged);
            // 
            // cOD_ARTICULOSearchLookUpEditView
            // 
            this.cOD_ARTICULOSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cOD_ARTICULOSearchLookUpEditView.Name = "cOD_ARTICULOSearchLookUpEditView";
            this.cOD_ARTICULOSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cOD_ARTICULOSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // lst_op
            // 
            this.lst_op.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "OP", true));
            this.lst_op.Location = new System.Drawing.Point(646, 361);
            this.lst_op.MenuManager = this.ribbonControl1;
            this.lst_op.Name = "lst_op";
            this.lst_op.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_op.Properties.Appearance.Options.UseFont = true;
            this.lst_op.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_op.Properties.View = this.oPSearchLookUpEditView;
            this.lst_op.Size = new System.Drawing.Size(38, 20);
            this.lst_op.TabIndex = 8;
            this.lst_op.Visible = false;
            this.lst_op.EditValueChanged += new System.EventHandler(this.lst_op_EditValueChanged);
            // 
            // oPSearchLookUpEditView
            // 
            this.oPSearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.oPSearchLookUpEditView.Name = "oPSearchLookUpEditView";
            this.oPSearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.oPSearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // lst_maquina
            // 
            this.lst_maquina.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "ID_MAQUINA", true));
            this.lst_maquina.Location = new System.Drawing.Point(610, 361);
            this.lst_maquina.MenuManager = this.ribbonControl1;
            this.lst_maquina.Name = "lst_maquina";
            this.lst_maquina.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_maquina.Properties.Appearance.Options.UseFont = true;
            this.lst_maquina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_maquina.Properties.View = this.iD_MAQUINASearchLookUpEditView;
            this.lst_maquina.Size = new System.Drawing.Size(39, 20);
            this.lst_maquina.TabIndex = 6;
            this.lst_maquina.Visible = false;
            this.lst_maquina.EditValueChanged += new System.EventHandler(this.lst_maquina_EditValueChanged);
            // 
            // iD_MAQUINASearchLookUpEditView
            // 
            this.iD_MAQUINASearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.iD_MAQUINASearchLookUpEditView.Name = "iD_MAQUINASearchLookUpEditView";
            this.iD_MAQUINASearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.iD_MAQUINASearchLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // txt_tipo_plantilla
            // 
            this.txt_tipo_plantilla.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "ID_TIPO_PLANTILLA", true));
            this.txt_tipo_plantilla.Location = new System.Drawing.Point(142, 218);
            this.txt_tipo_plantilla.MenuManager = this.ribbonControl1;
            this.txt_tipo_plantilla.Name = "txt_tipo_plantilla";
            this.txt_tipo_plantilla.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_plantilla.Properties.Appearance.Options.UseFont = true;
            this.txt_tipo_plantilla.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo_plantilla.TabIndex = 5;
            // 
            // lst_fecha_creacion
            // 
            this.lst_fecha_creacion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "FECHA_CREACION", true));
            this.lst_fecha_creacion.EditValue = null;
            this.lst_fecha_creacion.Location = new System.Drawing.Point(142, 180);
            this.lst_fecha_creacion.MenuManager = this.ribbonControl1;
            this.lst_fecha_creacion.Name = "lst_fecha_creacion";
            this.lst_fecha_creacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_fecha_creacion.Properties.Appearance.Options.UseFont = true;
            this.lst_fecha_creacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_fecha_creacion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_fecha_creacion.Size = new System.Drawing.Size(100, 20);
            this.lst_fecha_creacion.TabIndex = 4;
            // 
            // txt_usuario_creo
            // 
            this.txt_usuario_creo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USUARIO_CREO", true));
            this.txt_usuario_creo.Location = new System.Drawing.Point(142, 142);
            this.txt_usuario_creo.MenuManager = this.ribbonControl1;
            this.txt_usuario_creo.Name = "txt_usuario_creo";
            this.txt_usuario_creo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_creo.Properties.Appearance.Options.UseFont = true;
            this.txt_usuario_creo.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario_creo.TabIndex = 3;
            // 
            // lst_turno
            // 
            this.lst_turno.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "TURNO", true));
            this.lst_turno.Location = new System.Drawing.Point(142, 104);
            this.lst_turno.MenuManager = this.ribbonControl1;
            this.lst_turno.Name = "lst_turno";
            this.lst_turno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_turno.Properties.Appearance.Options.UseFont = true;
            this.lst_turno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_turno.Size = new System.Drawing.Size(100, 20);
            this.lst_turno.TabIndex = 2;
            // 
            // lst_fecha_transaccion
            // 
            this.lst_fecha_transaccion.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "FECHA_TRANSACCION", true));
            this.lst_fecha_transaccion.EditValue = null;
            this.lst_fecha_transaccion.Location = new System.Drawing.Point(142, 66);
            this.lst_fecha_transaccion.MenuManager = this.ribbonControl1;
            this.lst_fecha_transaccion.Name = "lst_fecha_transaccion";
            this.lst_fecha_transaccion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_fecha_transaccion.Properties.Appearance.Options.UseFont = true;
            this.lst_fecha_transaccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_fecha_transaccion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_fecha_transaccion.Size = new System.Drawing.Size(100, 20);
            this.lst_fecha_transaccion.TabIndex = 1;
            // 
            // txt_tag
            // 
            this.txt_tag.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "ID_TAGS", true));
            this.txt_tag.Location = new System.Drawing.Point(142, 28);
            this.txt_tag.MenuManager = this.ribbonControl1;
            this.txt_tag.Name = "txt_tag";
            this.txt_tag.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tag.Properties.Appearance.Options.UseFont = true;
            this.txt_tag.Size = new System.Drawing.Size(100, 20);
            this.txt_tag.TabIndex = 0;
            this.txt_tag.EditValueChanged += new System.EventHandler(this.txt_tag_EditValueChanged);
            // 
            // txt_user3
            // 
            this.txt_user3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bRCTAGSBindingSource, "USER_3", true));
            this.txt_user3.Location = new System.Drawing.Point(347, 102);
            this.txt_user3.MenuManager = this.ribbonControl1;
            this.txt_user3.Name = "txt_user3";
            this.txt_user3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user3.Properties.Appearance.Options.UseFont = true;
            this.txt_user3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_user3.Properties.NullText = "";
            this.txt_user3.Properties.View = this.searchLookUpEdit1View;
            this.txt_user3.Size = new System.Drawing.Size(100, 20);
            this.txt_user3.TabIndex = 12;
            this.txt_user3.EditValueChanged += new System.EventHandler(this.txt_user3_EditValueChanged);
            this.txt_user3.DragOver += new System.Windows.Forms.DragEventHandler(this.txt_user3_DragOver);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // bRC_TAGSTableAdapter
            // 
            this.bRC_TAGSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BRC_TAGSTableAdapter = this.bRC_TAGSTableAdapter;
            this.tableAdapterManager.UpdateOrder = DA.DataSetTagsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp1
            // 
            this.sp1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp1_DataReceived);
            // 
            // tm_lectura
            // 
            this.tm_lectura.Enabled = true;
            this.tm_lectura.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter
            // 
            this.sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 701);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ctrlTitulo1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tags";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBRCOBTENERTAGSTIPOPLANTILLABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCTAGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_operador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_OPERADORSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_activo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_unidad2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_unidad1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_articulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOD_ARTICULOSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_op.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPSearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_maquina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_MAQUINASearchLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tipo_plantilla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_creacion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_creacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario_creo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_turno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_transaccion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_fecha_transaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private BltCtr.CtrlTituloFrm ctrlTitulo1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.BarEditItem lst_tipo_plantilla;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DA.DataSetTags dataSetTags;
        private System.Windows.Forms.BindingSource bRCTAGSBindingSource;
        private DA.DataSetTagsTableAdapters.BRC_TAGSTableAdapter bRC_TAGSTableAdapter;
        private DevExpress.XtraEditors.CheckEdit chk_activo;
        private DevExpress.XtraEditors.TextEdit txt_user10;
        private DevExpress.XtraEditors.TextEdit txt_user9;
        private DevExpress.XtraEditors.TextEdit txt_user8;
        private DevExpress.XtraEditors.TextEdit txt_user7;
        private DevExpress.XtraEditors.TextEdit txt_user6;
        private DevExpress.XtraEditors.TextEdit txt_user5;
        private DevExpress.XtraEditors.TextEdit txt_user4;
        private DevExpress.XtraEditors.TextEdit txt_user2;
        private DevExpress.XtraEditors.TextEdit txt_user1;
        private DevExpress.XtraEditors.TextEdit lst_unidad2;
        private DevExpress.XtraEditors.TextEdit lst_unidad1;
        private DevExpress.XtraEditors.SearchLookUpEdit lst_articulo;
        private DevExpress.XtraGrid.Views.Grid.GridView cOD_ARTICULOSearchLookUpEditView;
        private DevExpress.XtraEditors.SearchLookUpEdit lst_op;
        private DevExpress.XtraGrid.Views.Grid.GridView oPSearchLookUpEditView;
        private DevExpress.XtraEditors.SearchLookUpEdit lst_maquina;
        private DevExpress.XtraGrid.Views.Grid.GridView iD_MAQUINASearchLookUpEditView;
        private DevExpress.XtraEditors.TextEdit txt_tipo_plantilla;
        private DevExpress.XtraEditors.DateEdit lst_fecha_creacion;
        private DevExpress.XtraEditors.TextEdit txt_usuario_creo;
        private DevExpress.XtraEditors.LookUpEdit lst_turno;
        private DevExpress.XtraEditors.DateEdit lst_fecha_transaccion;
        private DevExpress.XtraEditors.TextEdit txt_tag;
        private DA.DataSetTagsTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.BarCodeControl brc_tags;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraEditors.LabelControl lbl_user1;
        private DevExpress.XtraEditors.LabelControl lbl_user10;
        private DevExpress.XtraEditors.LabelControl lbl_user9;
        private DevExpress.XtraEditors.LabelControl lbl_user8;
        private DevExpress.XtraEditors.LabelControl lbl_user7;
        private DevExpress.XtraEditors.LabelControl lbl_user6;
        private DevExpress.XtraEditors.LabelControl lbl_user5;
        private DevExpress.XtraEditors.LabelControl lbl_user4;
        private DevExpress.XtraEditors.LabelControl lbl_user3;
        private DevExpress.XtraEditors.LabelControl lbl_user2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit lst_operador;
        private DevExpress.XtraGrid.Views.Grid.GridView iD_OPERADORSearchLookUpEditView;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarEditItem txt_no_copias;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.LabelControl lbl_unidad_2;
        private DevExpress.XtraEditors.LabelControl lbl_unidad_1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarEditItem lst_fecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraEditors.LabelControl lbl_kls;
        public System.IO.Ports.SerialPort sp1;
        private System.Windows.Forms.Timer tm_lectura;
        private DevExpress.XtraBars.BarButtonItem barButtonItem17;
        private DevExpress.XtraBars.BarButtonItem barButtonItem18;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource sPBRCOBTENERTAGSTIPOPLANTILLABindingSource;
        private DA.DataSetEncabezado dataSetEncabezado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TAGS;
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
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVO;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_6;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_7;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_8;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_9;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_10;
        private DA.DataSetEncabezadoTableAdapters.SP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter sP_BRC_OBTENER_TAGS_TIPO_PLANTILLATableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_entarimar;
        private DevExpress.XtraEditors.SimpleButton btn_detalle_tarimas;
        private DevExpress.XtraEditors.SimpleButton btn_part;
        private DevExpress.XtraEditors.SimpleButton btn_units;
        private DevExpress.XtraBars.BarButtonItem barButtonItem19;
        private DevExpress.XtraEditors.SearchLookUpEdit txt_user3;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;

    }
}

