namespace brc_tags
{
    partial class GenerarTarima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarTarima));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sPBRCOBTENERLISTADOENTARIMADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetResumenEntarimado = new brc_tags.DA.DataSetResumenEntarimado();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_ARTICULO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_MAQUINA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIDAD_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIDAD_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTURNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter = new brc_tags.DA.DataSetResumenEntarimadoTableAdapters.SP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter();
            this.colFECHA_TRANSACCION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lst_turno = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBRCOBTENERLISTADOENTARIMADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetResumenEntarimado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_turno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lst_turno);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(831, 418);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tarimas A Generar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(215, 26);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(397, 63);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Seleccione la orden que desea entarimar y presione el boton.";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sPBRCOBTENERLISTADOENTARIMADOBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(7, 95);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(819, 315);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sPBRCOBTENERLISTADOENTARIMADOBindingSource
            // 
            this.sPBRCOBTENERLISTADOENTARIMADOBindingSource.DataMember = "SP_BRC_OBTENER_LISTADO_ENTARIMADO";
            this.sPBRCOBTENERLISTADOENTARIMADOBindingSource.DataSource = this.dataSetResumenEntarimado;
            // 
            // dataSetResumenEntarimado
            // 
            this.dataSetResumenEntarimado.DataSetName = "DataSetResumenEntarimado";
            this.dataSetResumenEntarimado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOP,
            this.colCOD_ARTICULO,
            this.colID_MAQUINA,
            this.colUNIDAD_1,
            this.colUNIDAD_2,
            this.colTURNO,
            this.colFECHA_TRANSACCION});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
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
            this.colOP.VisibleIndex = 3;
            this.colOP.Width = 90;
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
            this.colCOD_ARTICULO.VisibleIndex = 4;
            this.colCOD_ARTICULO.Width = 212;
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
            this.colID_MAQUINA.VisibleIndex = 2;
            this.colID_MAQUINA.Width = 137;
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
            this.colUNIDAD_1.Visible = true;
            this.colUNIDAD_1.VisibleIndex = 6;
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
            this.colUNIDAD_2.Visible = true;
            this.colUNIDAD_2.VisibleIndex = 7;
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
            this.colTURNO.VisibleIndex = 5;
            this.colTURNO.Width = 50;
            // 
            // sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter
            // 
            this.sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter.ClearBeforeFill = true;
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
            this.colFECHA_TRANSACCION.Width = 111;
            // 
            // lst_turno
            // 
            this.lst_turno.Location = new System.Drawing.Point(79, 52);
            this.lst_turno.Name = "lst_turno";
            this.lst_turno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lst_turno.Properties.View = this.searchLookUpEdit1View;
            this.lst_turno.Size = new System.Drawing.Size(100, 20);
            this.lst_turno.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(33, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Turno:";
            // 
            // GenerarTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 426);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarTarima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Tarima";
            this.Load += new System.EventHandler(this.GenerarTarima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBRCOBTENERLISTADOENTARIMADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetResumenEntarimado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lst_turno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource sPBRCOBTENERLISTADOENTARIMADOBindingSource;
        private DA.DataSetResumenEntarimado dataSetResumenEntarimado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colOP;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_ARTICULO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_MAQUINA;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIDAD_1;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIDAD_2;
        private DA.DataSetResumenEntarimadoTableAdapters.SP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter sP_BRC_OBTENER_LISTADO_ENTARIMADOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTURNO;
        private DevExpress.XtraGrid.Columns.GridColumn colFECHA_TRANSACCION;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lst_turno;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}