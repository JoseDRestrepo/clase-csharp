using controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = AccesoLogica.ObtenerTiposVehiculos();
            limpiarCampos();
        }
        //Return limpiarCampos(); 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // button de registrar 
        private void button1_Click(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica(); 
            int idtipo = Int32.Parse(txtIdVehi.Text);
            string nombretipo = textBox2.Text;
            int resultado = negocio.InsertTipoVehi(idtipo, nombretipo);

            if (resultado  > 0)
                txtMensaje.Text = "Nuevo Registro Agregado Sactisfactoriamente";
            else
                txtMensaje.Text = "Id ya Existe, agregue otro o no se inserto el dato";

            negocio = null;
            limpiarCampos(); 
        }

        void limpiarCampos()
        {
            txtIdVehi.Text = "";
            textBox2.Text = "";
            txtIdVehi.Focus(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // boton para listar los datos
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.ObtenerTiposVehiculos();
        }


        //mostrar datos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = dataGridView1.CurrentRow.Index;
            txtIdVehi.Text = dataGridView1[0, pocision].Value.ToString();
            textBox2.Text = dataGridView1[1, pocision].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ValidarIngreso(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }


        //actualizar boton
        private void button3_Click(object sender, EventArgs e)
        {
            AccesoLogica actualizar = new AccesoLogica();
            int idtipo = Int32.Parse(txtIdVehi.Text); 
            string nombretipo = textBox2.Text;
            ValidarIngreso(txtIdVehi);
            ValidarIngreso(textBox2);

            int resultadoActualizar = actualizar.UpdateTipoVehi(idtipo, nombretipo);

            if (resultadoActualizar > 0)
            {
                txtMensaje.Text = "Registro Actualizado";
            }
            else
            {
                txtMensaje.Text = "Registro no Actualizado";
                actualizar = null; 
            }
            limpiarCampos();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //eliminar boton    
        private void button4_Click(object sender, EventArgs e)
        {
            AccesoLogica eliminar = new AccesoLogica();
            int idtipo = Int32.Parse(txtIdVehi.Text);
            int resultadoEliminar = eliminar.DeleteTipoVehi(idtipo);
            if (resultadoEliminar > 0)
            {
                txtMensaje.Text = "Registro Eliminado";
            }
            else
            {
                txtMensaje.Text = "Registro no Eliminado";
                eliminar = null;
            }
            limpiarCampos();
        }
    }
}
