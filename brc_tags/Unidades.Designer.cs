namespace brc_tags
{
    partial class Unidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unidades));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_nuevo = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bRCUNITSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPart = new brc_tags.DA.DataSetPart();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUNIT_OF_MEASURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bRC_UNITSTableAdapter = new brc_tags.DA.DataSetPartTableAdapters.BRC_UNITSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCUNITSBindingSource)).BeginInit();
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
            this.groupControl1.Controls.Add(this.btn_guardar);
            this.groupControl1.Controls.Add(this.btn_nuevo);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(524, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Lista";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_guardar.Location = new System.Drawing.Point(461, 10);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 40);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_nuevo.Location = new System.Drawing.Point(409, 10);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(40, 40);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bRCUNITSBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(5, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(514, 219);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bRCUNITSBindingSource
            // 
            this.bRCUNITSBindingSource.DataMember = "BRC_UNITS";
            this.bRCUNITSBindingSource.DataSource = this.dataSetPart;
            // 
            // dataSetPart
            // 
            this.dataSetPart.DataSetName = "DataSetPart";
            this.dataSetPart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUNIT_OF_MEASURE,
            this.colDESCRIPTION});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colUNIT_OF_MEASURE
            // 
            this.colUNIT_OF_MEASURE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.colUNIT_OF_MEASURE.AppearanceHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.colUNIT_OF_MEASURE.AppearanceHeader.Options.UseFont = true;
            this.colUNIT_OF_MEASURE.AppearanceHeader.Options.UseForeColor = true;
            this.colUNIT_OF_MEASURE.Caption = "Codigo";
            this.colUNIT_OF_MEASURE.FieldName = "UNIT_OF_MEASURE";
            this.colUNIT_OF_MEASURE.Name = "colUNIT_OF_MEASURE";
            this.colUNIT_OF_MEASURE.Visible = true;
            this.colUNIT_OF_MEASURE.VisibleIndex = 0;
            this.colUNIT_OF_MEASURE.Width = 79;
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
            this.colDESCRIPTION.Width = 336;
            // 
            // bRC_UNITSTableAdapter
            // 
            this.bRC_UNITSTableAdapter.ClearBeforeFill = true;
            // 
            // Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 262);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades";
            this.Load += new System.EventHandler(this.Unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bRCUNITSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DA.DataSetPart dataSetPart;
        private System.Windows.Forms.BindingSource bRCUNITSBindingSource;
        private DA.DataSetPartTableAdapters.BRC_UNITSTableAdapter bRC_UNITSTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
        private DevExpress.XtraEditors.SimpleButton btn_nuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_OF_MEASURE;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
    }
}