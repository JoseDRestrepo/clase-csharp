namespace presentacion
{
    partial class Form3
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
            this.lbIdVehiculo = new System.Windows.Forms.Label();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblAnnio = new System.Windows.Forms.Label();
            this.txtAnnio = new System.Windows.Forms.TextBox();
            this.lblIdTipo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.Label();
            this.cmbIdtipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1TITULO.Location = new System.Drawing.Point(289, 23);
            this.label1TITULO.Name = "label1TITULO";
            this.label1TITULO.Size = new System.Drawing.Size(118, 13);
            this.label1TITULO.TabIndex = 8;
            this.label1TITULO.Text = "SISTEMA VEHICULOS";
            this.label1TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1TITULO.Click += new System.EventHandler(this.label1TITULO_Click);
            // 
            // lbIdVehiculo
            // 
            this.lbIdVehiculo.AutoSize = true;
            this.lbIdVehiculo.Location = new System.Drawing.Point(81, 60);
            this.lbIdVehiculo.Name = "lbIdVehiculo";
            this.lbIdVehiculo.Size = new System.Drawing.Size(15, 13);
            this.lbIdVehiculo.TabIndex = 9;
            this.lbIdVehiculo.Text = "id";
            this.lbIdVehiculo.Click += new System.EventHandler(this.labelIdCon_Click);
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(127, 57);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtIdVehiculo.TabIndex = 10;
            this.txtIdVehiculo.TextChanged += new System.EventHandler(this.txtIdVehiculo_TextChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(81, 92);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(36, 13);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "marca";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(127, 89);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 12;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(251, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(41, 13);
            this.lblModelo.TabIndex = 13;
            this.lblModelo.Text = "modelo";
            this.lblModelo.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(307, 57);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 14;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(251, 92);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(49, 13);
            this.lblMatricula.TabIndex = 15;
            this.lblMatricula.Text = "matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(307, 89);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 16;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            // 
            // lblAnnio
            // 
            this.lblAnnio.AutoSize = true;
            this.lblAnnio.Location = new System.Drawing.Point(436, 60);
            this.lblAnnio.Name = "lblAnnio";
            this.lblAnnio.Size = new System.Drawing.Size(25, 13);
            this.lblAnnio.TabIndex = 17;
            this.lblAnnio.Text = "año";
            // 
            // txtAnnio
            // 
            this.txtAnnio.Location = new System.Drawing.Point(476, 57);
            this.txtAnnio.Name = "txtAnnio";
            this.txtAnnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnnio.TabIndex = 18;
            // 
            // lblIdTipo
            // 
            this.lblIdTipo.AutoSize = true;
            this.lblIdTipo.Location = new System.Drawing.Point(436, 92);
            this.lblIdTipo.Name = "lblIdTipo";
            this.lblIdTipo.Size = new System.Drawing.Size(28, 13);
            this.lblIdTipo.TabIndex = 19;
            this.lblIdTipo.Text = "Tipo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 181);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(127, 176);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(90, 24);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(234, 176);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 24);
            this.btnListar.TabIndex = 23;
            this.btnListar.Text = "listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(342, 176);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 24);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(453, 176);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 24);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Location = new System.Drawing.Point(239, 139);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(0, 13);
            this.txtMensaje.TabIndex = 26;
            // 
            // cmbIdtipo
            // 
            this.cmbIdtipo.FormattingEnabled = true;
            this.cmbIdtipo.Location = new System.Drawing.Point(476, 89);
            this.cmbIdtipo.Name = "cmbIdtipo";
            this.cmbIdtipo.Size = new System.Drawing.Size(100, 21);
            this.cmbIdtipo.TabIndex = 27;
            this.cmbIdtipo.SelectedIndexChanged += new System.EventHandler(this.cmbIdtipo_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.cmbIdtipo);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIdTipo);
            this.Controls.Add(this.txtAnnio);
            this.Controls.Add(this.lblAnnio);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.lbIdVehiculo);
            this.Controls.Add(this.label1TITULO);
            this.Name = "Form3";
            this.Text = "Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1TITULO;
        private System.Windows.Forms.Label lbIdVehiculo;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblAnnio;
        private System.Windows.Forms.TextBox txtAnnio;
        private System.Windows.Forms.Label lblIdTipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label txtMensaje;
        private System.Windows.Forms.ComboBox cmbIdtipo;
    }
}