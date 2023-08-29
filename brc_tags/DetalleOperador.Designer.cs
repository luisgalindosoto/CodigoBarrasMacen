namespace brc_tags
{
    partial class DetalleOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleOperador));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bRCDETALLEOPERADORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDetalleOperadores = new brc_tags.DA.DataSetDetalleOperadores();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_TAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_OPERADOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bRC_DETALLE_OPERADORTableAdapter = new brc_tags.DA.DataSetDetalleOperadoresTableAdapters.BRC_DETALLE_OPERADORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCDETALLEOPERADORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleOperadores)).BeginInit();
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
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(501, 581);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Detalle";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bRCDETALLEOPERADORBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(491, 550);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bRCDETALLEOPERADORBindingSource
            // 
            this.bRCDETALLEOPERADORBindingSource.DataMember = "BRC_DETALLE_OPERADOR";
            this.bRCDETALLEOPERADORBindingSource.DataSource = this.dataSetDetalleOperadores;
            // 
            // dataSetDetalleOperadores
            // 
            this.dataSetDetalleOperadores.DataSetName = "DataSetDetalleOperadores";
            this.dataSetDetalleOperadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_TAGS,
            this.colID_OPERADOR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // 
            // colID_OPERADOR
            // 
            this.colID_OPERADOR.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colID_OPERADOR.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colID_OPERADOR.AppearanceHeader.Options.UseFont = true;
            this.colID_OPERADOR.AppearanceHeader.Options.UseForeColor = true;
            this.colID_OPERADOR.Caption = "Operador";
            this.colID_OPERADOR.FieldName = "ID_OPERADOR";
            this.colID_OPERADOR.Name = "colID_OPERADOR";
            this.colID_OPERADOR.Visible = true;
            this.colID_OPERADOR.VisibleIndex = 0;
            // 
            // bRC_DETALLE_OPERADORTableAdapter
            // 
            this.bRC_DETALLE_OPERADORTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 586);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Operador";
            this.Load += new System.EventHandler(this.DetalleOperador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCDETALLEOPERADORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDetalleOperadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DA.DataSetDetalleOperadores dataSetDetalleOperadores;
        private System.Windows.Forms.BindingSource bRCDETALLEOPERADORBindingSource;
        private DA.DataSetDetalleOperadoresTableAdapters.BRC_DETALLE_OPERADORTableAdapter bRC_DETALLE_OPERADORTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colID_OPERADOR;
    }
}