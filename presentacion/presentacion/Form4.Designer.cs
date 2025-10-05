namespace presentacion
{
    partial class Form4
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
            this.lbIdConductor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipoCon = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbVehi = new System.Windows.Forms.ComboBox();
            this.txtMensaje = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1TITULO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdConductor
            // 
            this.lbIdConductor.AutoSize = true;
            this.lbIdConductor.Location = new System.Drawing.Point(75, 39);
            this.lbIdConductor.Name = "lbIdConductor";
            this.lbIdConductor.Size = new System.Drawing.Size(16, 13);
            this.lbIdConductor.TabIndex = 0;
            this.lbIdConductor.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(128, 37);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 20);
            this.numId.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(284, 39);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(48, 13);
            this.lblVehiculo.TabIndex = 4;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(368, 75);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(120, 21);
            this.cmbTipo.TabIndex = 6;
            // 
            // lblTipoCon
            // 
            this.lblTipoCon.AutoSize = true;
            this.lblTipoCon.Location = new System.Drawing.Point(284, 79);
            this.lblTipoCon.Name = "lblTipoCon";
            this.lblTipoCon.Size = new System.Drawing.Size(79, 13);
            this.lblTipoCon.TabIndex = 7;
            this.lblTipoCon.Text = "Tipo conductor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 149);
            this.dataGridView1.TabIndex = 8;
            // 
            // cmbVehi
            // 
            this.cmbVehi.FormattingEnabled = true;
            this.cmbVehi.Location = new System.Drawing.Point(368, 36);
            this.cmbVehi.Name = "cmbVehi";
            this.cmbVehi.Size = new System.Drawing.Size(121, 21);
            this.cmbVehi.TabIndex = 9;
            // 
            // txtMensaje
            // 
            this.txtMensaje.AutoSize = true;
            this.txtMensaje.Location = new System.Drawing.Point(194, 116);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(0, 13);
            this.txtMensaje.TabIndex = 10;
            this.txtMensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(78, 152);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(288, 152);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(185, 152);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(398, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1TITULO
            // 
            this.label1TITULO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1TITULO.AutoSize = true;
            this.label1TITULO.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1TITULO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1TITULO.Location = new System.Drawing.Point(232, 9);
            this.label1TITULO.Name = "label1TITULO";
            this.label1TITULO.Size = new System.Drawing.Size(118, 13);
            this.label1TITULO.TabIndex = 15;
            this.label1TITULO.Text = "SISTEMA VEHICULOS";
            this.label1TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 368);
            this.Controls.Add(this.label1TITULO);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.cmbVehi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTipoCon);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbIdConductor);
            this.Name = "Form4";
            this.Text = "Conductor";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdConductor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipoCon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbVehi;
        private System.Windows.Forms.Label txtMensaje;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1TITULO;
    }
}