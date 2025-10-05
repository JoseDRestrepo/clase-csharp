using controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = AccesoLogica.ObtenerTiposConductor();
            limpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int idtipo = Int32.Parse(txtIdCon.Text);
            string nombretipo = txtNombreCon.Text;
            int resultado = negocio.InsertTipoCon(idtipo, nombretipo);

            if (resultado > 0)
            {
                txtMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente";
            }else
            {
                txtMensaje.Text = "Id ya Existe, agregue otro o no se inserto el dato";
            }

            negocio = null;
            limpiarCampos();
        }

        void limpiarCampos()
        {
            txtIdCon.Text = "";
            txtNombreCon.Text = "";
            txtIdCon.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.ObtenerTiposConductor();
            limpiarCampos();
            txtMensaje.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pocision = dataGridView1.CurrentRow.Index;
            txtIdCon.Text = dataGridView1[0, pocision].Value.ToString();
            txtNombreCon.Text = dataGridView1[1, pocision].Value.ToString();
            txtMensaje.Text = "";   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccesoLogica actualizar = new AccesoLogica();
            int idtipo = Int32.Parse(txtIdCon.Text);
            string nombretipo = txtNombreCon.Text;

            int resultadoActualizar = actualizar.UpdateTipoCon(idtipo, nombretipo);

            if (resultadoActualizar > 0)
            {
                txtMensaje.Text = "Registro Actualizado";
            }
            else
            {
                txtMensaje.Text = "Registro no Actualizado";
                actualizar = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccesoLogica eliminar = new AccesoLogica();
            int idtipo = Int32.Parse(txtIdCon.Text);
            int resultadoEliminar = eliminar.DeleteTipoCon(idtipo);
            if (resultadoEliminar > 0)
            {
                txtMensaje.Text = "Registro Eliminado";
            }
            else
            {
                txtMensaje.Text = "Registro no Eliminado";
                eliminar = null;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1TITULO_Click(object sender, EventArgs e)
        {

        }

        private void labelIdVehi_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
