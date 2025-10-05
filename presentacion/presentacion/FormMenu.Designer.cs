namespace presentacion
{
    partial class FormMenu
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
            this.label1TITULO = new System.Windows.Forms.Label();
            this.btnTipoVehi = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnTipoCon = new System.Windows.Forms.Button();
            this.btnVehi = new System.Windows.Forms.Button();
            this.btnConductor = new System.Windows.Forms.Button();
            this.btnContrato = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1TITULO
            // 
            this.label1TITULO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1TITULO.AutoSize = true;
            this.label1TITULO.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1TITULO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1TITULO.Location = new System.Drawing.Point(132, 9);
            this.label1TITULO.Name = "label1TITULO";
            this.label1TITULO.Size = new System.Drawing.Size(39, 13);
            this.label1TITULO.TabIndex = 8;
            this.label1TITULO.Text = "MENU";
            this.label1TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1TITULO.Click += new System.EventHandler(this.label1TITULO_Click);
            // 
            // btnTipoVehi
            // 
            this.btnTipoVehi.Location = new System.Drawing.Point(38, 38);
            this.btnTipoVehi.Name = "btnTipoVehi";
            this.btnTipoVehi.Size = new System.Drawing.Size(239, 23);
            this.btnTipoVehi.TabIndex = 9;
            this.btnTipoVehi.Text = "Tipo vehiculo";
            this.btnTipoVehi.UseVisualStyleBackColor = true;
            this.btnTipoVehi.Click += new System.EventHandler(this.btnTipoVehi_Click);
            // 
            // btnTipoCon
            // 
            this.btnTipoCon.Location = new System.Drawing.Point(38, 77);
            this.btnTipoCon.Name = "btnTipoCon";
            this.btnTipoCon.Size = new System.Drawing.Size(239, 23);
            this.btnTipoCon.TabIndex = 10;
            this.btnTipoCon.Text = "Tipo conductor";
            this.btnTipoCon.UseVisualStyleBackColor = true;
            this.btnTipoCon.Click += new System.EventHandler(this.btnTipoCon_Click);
            // 
            // btnVehi
            // 
            this.btnVehi.Location = new System.Drawing.Point(38, 116);
            this.btnVehi.Name = "btnVehi";
            this.btnVehi.Size = new System.Drawing.Size(239, 23);
            this.btnVehi.TabIndex = 11;
            this.btnVehi.Text = "Vehiculo";
            this.btnVehi.UseVisualStyleBackColor = true;
            this.btnVehi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConductor
            // 
            this.btnConductor.Location = new System.Drawing.Point(38, 157);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(239, 23);
            this.btnConductor.TabIndex = 12;
            this.btnConductor.Text = "Conductor";
            this.btnConductor.UseVisualStyleBackColor = true;
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(38, 197);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(239, 23);
            this.btnContrato.TabIndex = 13;
            this.btnContrato.Text = "Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(38, 237);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(239, 23);
            this.btnRuta.TabIndex = 14;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(314, 299);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnContrato);
            this.Controls.Add(this.btnConductor);
            this.Controls.Add(this.btnVehi);
            this.Controls.Add(this.btnTipoCon);
            this.Controls.Add(this.btnTipoVehi);
            this.Controls.Add(this.label1TITULO);
            this.Name = "FormMenu";
            this.Text = "Menu sitema vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1TITULO;
        private System.Windows.Forms.Button btnTipoVehi;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnTipoCon;
        private System.Windows.Forms.Button btnVehi;
        private System.Windows.Forms.Button btnConductor;
        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.Button btnRuta;
    }
}