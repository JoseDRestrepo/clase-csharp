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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            SelectVehiculos();
            limpiarCampos();
        }

        private void label1TITULO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            numId.Value = 0;
            txtEstacion.Text = "";
            cmbVehi.SelectedIndex = -1;
            numId.Focus();
        }
        private void SelectVehiculos()
        {
            DataTable datos = AccesoLogica.ObtenerVehiculos();
            cmbVehi.DataSource = datos;
            cmbVehi.DisplayMember = "Matricula";
            cmbVehi.ValueMember = "IdVehi";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AccesoLogica registrar = new AccesoLogica();
            int idtipo = Convert.ToInt32(numId.Value);
            string nombretipo = txtEstacion.Text;
            int idvehi = Convert.ToInt32(cmbVehi.SelectedValue);
            int resultado = registrar.InsertRuta(idtipo, nombretipo, idvehi);
            if (resultado > 0)
                txtMensaje.Text = "Nuevo Registro Agregado Sactisfactoriamente";
            else
                txtMensaje.Text = "Id ya Existe, agregue otro o no se inserto el dato";
            limpiarCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AccesoLogica listar = new AccesoLogica();
            dataGridView1.DataSource = AccesoLogica.ObtenerRutas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AccesoLogica actualizar = new AccesoLogica();
            int idtipo = Convert.ToInt32(numId.Value);
            string nombretipo = txtEstacion.Text;
            int idvehi = Convert.ToInt32(cmbVehi.SelectedValue);
            int resultado = actualizar.UpdateRuta(idtipo, nombretipo, idvehi);
            if (resultado > 0)
                txtMensaje.Text = "Registro Actualizado Satisfactoriamente";
            else
                txtMensaje.Text = "No se Actualizo el dato, verifique el Id";
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoLogica eliminar = new AccesoLogica();
            int idtipo = Convert.ToInt32(numId.Value);
            int resultado = eliminar.DeleteRuta(idtipo);
            if (resultado > 0)
                txtMensaje.Text = "Registro Eliminado Satisfactoriamente";
            else
                txtMensaje.Text = "No se Elimino el dato, verifique el Id";
        }
    }
}
