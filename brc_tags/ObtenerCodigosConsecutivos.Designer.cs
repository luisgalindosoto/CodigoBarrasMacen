﻿namespace brc_tags
{
    partial class ObtenerCodigosConsecutivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerCodigosConsecutivos));
            this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_aceptar = new DevExpress.XtraEditors.SimpleButton();
            this.lst_comandos = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.txt_codigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_borrar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lst_comandos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(149, 141);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 38);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(53, 141);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(90, 38);
            this.btn_aceptar.TabIndex = 15;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lst_comandos
            // 
            this.lst_comandos.Location = new System.Drawing.Point(65, 40);
            this.lst_comandos.Name = "lst_comandos";
            this.lst_comandos.Size = new System.Drawing.Size(265, 95);
            this.lst_comandos.TabIndex = 14;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(65, 14);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(265, 20);
            this.txt_codigo.TabIndex = 13;
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Codigos:";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.Location = new System.Drawing.Point(245, 141);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 38);
            this.btn_borrar.TabIndex = 17;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // ObtenerCodigosConsecutivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 192);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lst_comandos);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ObtenerCodigosConsecutivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener Codigos";
            this.Load += new System.EventHandler(this.ObtenerCodigosConsecutivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_comandos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_borrar;
        private DevExpress.XtraEditors.SimpleButton btn_cancelar;
        private DevExpress.XtraEditors.SimpleButton btn_aceptar;
        private DevExpress.XtraEditors.CheckedListBoxControl lst_comandos;
        private DevExpress.XtraEditors.TextEdit txt_codigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}