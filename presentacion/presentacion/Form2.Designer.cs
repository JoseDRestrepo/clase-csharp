namespace presentacion
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtIdCon = new System.Windows.Forms.TextBox();
            this.txtNombreCon = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1TITULO = new System.Windows.Forms.Label();
            this.labelIdCon = new System.Windows.Forms.Label();
            this.labelTipoCon = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCon
            // 
            this.txtIdCon.Location = new System.Drawing.Point(155, 34);
            this.txtIdCon.Name = "txtIdCon";
            this.txtIdCon.Size = new System.Drawing.Size(100, 20);
            this.txtIdCon.TabIndex = 0;
            this.txtIdCon.TextChanged += new System.EventHandler(this.txtIdCon_TextChanged);
            // 
            // txtNombreCon
            // 
            this.txtNombreCon.Location = new System.Drawing.Point(155, 71);
            this.txtNombreCon.Name = "txtNombreCon";
            this.txtNombreCon.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCon.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(37, 131);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 166);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(118, 131);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "listar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(199, 131);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(280, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1TITULO
            // 
            this.label1TITULO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1TITULO.AutoSize = true;
            this.label1TITULO.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1TITULO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1TITULO.Location = new System.Drawing.Point(111, 9);
            this.label1TITULO.Name = "label1TITULO";
            this.label1TITULO.Size = new System.Drawing.Size(118, 13);
            this.label1TITULO.TabIndex = 7;
            this.label1TITULO.Text = "SISTEMA VEHICULOS";
            this.label1TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1TITULO.Click += new System.EventHandler(this.label1TITULO_Click);
            // 
            // labelIdCon
            // 
            this.labelIdCon.AutoSize = true;
            this.labelIdCon.Location = new System.Drawing.Point(34, 41);
            this.labelIdCon.Name = "labelIdCon";
            this.labelIdCon.Size = new System.Drawing.Size(86, 13);
            this.labelIdCon.TabIndex = 8;
            this.labelIdCon.Text = "id tipo conductor";
            this.labelIdCon.Click += new System.EventHandler(this.labelIdVehi_Click);
            // 
            // labelTipoCon
            // 
            this.labelTipoCon.AutoSize = true;
            this.labelTipoCon.Location = new System.Drawing.Point(34, 71);
            this.labelTipoCon.Name = "labelTipoCon";
            this.labelTipoCon.Size = new System.Drawing.Size(106, 13);
            this.labelTipoCon.TabIndex = 9;
            this.labelTipoCon.Text = "nombre tipo Vehiculo";
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Location = new System.Drawing.Point(129, 105);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(0, 13);
            this.txtMensaje.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 364);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.labelTipoCon);
            this.Controls.Add(this.labelIdCon);
            this.Controls.Add(this.label1TITULO);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreCon);
            this.Controls.Add(this.txtIdCon);
            this.Name = "Form2";
            this.Text = "Tipo Conductor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCon;
        private System.Windows.Forms.TextBox txtNombreCon;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1TITULO;
        private System.Windows.Forms.Label labelIdCon;
        private System.Windows.Forms.Label labelTipoCon;
        private System.Windows.Forms.Label txtMensaje;
    }
}