namespace brc_tags
{
    partial class Part
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Part));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_unidades = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_agregar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bRCPARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPart = new brc_tags.DA.DataSetPart();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_UM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRODUCT_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMODITY_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colACTIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bRC_PARTTableAdapter = new brc_tags.DA.DataSetPartTableAdapters.BRC_PARTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCPARTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btn_unidades);
            this.groupControl1.Controls.Add(this.btn_guardar);
            this.groupControl1.Controls.Add(this.btn_agregar);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(9, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(881, 418);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Articulos";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(698, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(40, 40);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_unidades
            // 
            this.btn_unidades.Image = global::brc_tags.Properties.Resources.UNITS;
            this.btn_unidades.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_unidades.Location = new System.Drawing.Point(744, 1);
            this.btn_unidades.Name = "btn_unidades";
            this.btn_unidades.Size = new System.Drawing.Size(40, 40);
            this.btn_unidades.TabIndex = 3;
            this.btn_unidades.Click += new System.EventHandler(this.btn_unidades_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_guardar.Location = new System.Drawing.Point(836, 0);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 40);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_agregar.Location = new System.Drawing.Point(790, 1);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(40, 40);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bRCPARTBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(871, 392);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // bRCPARTBindingSource
            // 
            this.bRCPARTBindingSource.DataMember = "BRC_PART";
            this.bRCPARTBindingSource.DataSource = this.dataSetPart;
            // 
            // dataSetPart
            // 
            this.dataSetPart.DataSetName = "DataSetPart";
            this.dataSetPart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDESCRIPTION,
            this.colSTOCK_UM,
            this.colPRODUCT_CODE,
            this.colCOMMODITY_CODE,
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
            this.colACTIVO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ingrese el producto a buscar...";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseForeColor = true;
            this.colID.Caption = "Codigo";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 134;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colDESCRIPTION.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colDESCRIPTION.AppearanceHeader.Options.UseFont = true;
            this.colDESCRIPTION.AppearanceHeader.Options.UseForeColor = true;
            this.colDESCRIPTION.Caption = "Descripcion";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 1;
            this.colDESCRIPTION.Width = 370;
            // 
            // colSTOCK_UM
            // 
            this.colSTOCK_UM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colSTOCK_UM.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colSTOCK_UM.AppearanceHeader.Options.UseFont = true;
            this.colSTOCK_UM.AppearanceHeader.Options.UseForeColor = true;
            this.colSTOCK_UM.Caption = "Und";
            this.colSTOCK_UM.FieldName = "STOCK_UM";
            this.colSTOCK_UM.Name = "colSTOCK_UM";
            this.colSTOCK_UM.Visible = true;
            this.colSTOCK_UM.VisibleIndex = 2;
            // 
            // colPRODUCT_CODE
            // 
            this.colPRODUCT_CODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colPRODUCT_CODE.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colPRODUCT_CODE.AppearanceHeader.Options.UseFont = true;
            this.colPRODUCT_CODE.AppearanceHeader.Options.UseForeColor = true;
            this.colPRODUCT_CODE.Caption = "Familia";
            this.colPRODUCT_CODE.FieldName = "PRODUCT_CODE";
            this.colPRODUCT_CODE.Name = "colPRODUCT_CODE";
            // 
            // colCOMMODITY_CODE
            // 
            this.colCOMMODITY_CODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colCOMMODITY_CODE.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colCOMMODITY_CODE.AppearanceHeader.Options.UseFont = true;
            this.colCOMMODITY_CODE.AppearanceHeader.Options.UseForeColor = true;
            this.colCOMMODITY_CODE.Caption = "Sub Familia";
            this.colCOMMODITY_CODE.FieldName = "COMMODITY_CODE";
            this.colCOMMODITY_CODE.Name = "colCOMMODITY_CODE";
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
            this.colUSER_1.Visible = true;
            this.colUSER_1.VisibleIndex = 3;
            this.colUSER_1.Width = 100;
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
            this.colUSER_2.Visible = true;
            this.colUSER_2.VisibleIndex = 4;
            this.colUSER_2.Width = 100;
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
            this.colUSER_3.Visible = true;
            this.colUSER_3.VisibleIndex = 5;
            this.colUSER_3.Width = 100;
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
            this.colUSER_4.Visible = true;
            this.colUSER_4.VisibleIndex = 6;
            this.colUSER_4.Width = 100;
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
            this.colUSER_5.Visible = true;
            this.colUSER_5.VisibleIndex = 7;
            this.colUSER_5.Width = 100;
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
            this.colUSER_6.Visible = true;
            this.colUSER_6.VisibleIndex = 8;
            this.colUSER_6.Width = 100;
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
            this.colUSER_7.Visible = true;
            this.colUSER_7.VisibleIndex = 9;
            this.colUSER_7.Width = 100;
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
            this.colUSER_8.Visible = true;
            this.colUSER_8.VisibleIndex = 10;
            this.colUSER_8.Width = 100;
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
            this.colUSER_9.Visible = true;
            this.colUSER_9.VisibleIndex = 11;
            this.colUSER_9.Width = 100;
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
            this.colUSER_10.Visible = true;
            this.colUSER_10.VisibleIndex = 12;
            this.colUSER_10.Width = 100;
            // 
            // colACTIVO
            // 
            this.colACTIVO.Caption = "ACTIVO";
            this.colACTIVO.FieldName = "ACTIVO";
            this.colACTIVO.Name = "colACTIVO";
            this.colACTIVO.Visible = true;
            this.colACTIVO.VisibleIndex = 13;
            // 
            // bRC_PARTTableAdapter
            // 
            this.bRC_PARTTableAdapter.ClearBeforeFill = true;
            // 
            // Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 433);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Part";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.Load += new System.EventHandler(this.Part_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCPARTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_UM;
        private DevExpress.XtraGrid.Columns.GridColumn colPRODUCT_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMODITY_CODE;
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
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVO;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.SimpleButton btn_agregar;
        private DevExpress.XtraEditors.SimpleButton btn_unidades;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DA.DataSetPart dataSetPart;
        private System.Windows.Forms.BindingSource bRCPARTBindingSource;
        private DA.DataSetPartTableAdapters.BRC_PARTTableAdapter bRC_PARTTableAdapter;
    }
}