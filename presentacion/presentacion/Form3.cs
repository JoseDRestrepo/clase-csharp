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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = AccesoLogica.ObtenerVehiculos();
            SelectDinamico();
            limpiarCampos();
        }

        private void label1TITULO_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelIdCon_Click(object sender, EventArgs e)
        {

        }

        private void txtIdVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        //private void listTipo_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void listTipo_Click(object sender, EventArgs e)
        //{

        //}

        private void limpiarCampos()
        {
            txtIdVehiculo.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtMatricula.Text = "";
            txtAnnio.Text = "";
            cmbIdtipo.SelectedIndex = -1;
            txtIdVehiculo.Focus();
        }

        private void SelectDinamico()
        {
            DataTable datos = AccesoLogica.ObtenerTiposVehiculos();
            cmbIdtipo.DataSource = datos;
            cmbIdtipo.DisplayMember = "NombreTipo";
            cmbIdtipo.ValueMember = "IdTipo";
            cmbIdtipo.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int idvehiculo = Int32.Parse(txtIdVehiculo.Text);
            string matricula = txtMatricula.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int annio = Int32.Parse(txtAnnio.Text);
            int idtipo = Convert.ToInt32(cmbIdtipo.SelectedValue);

            int resultado = negocio.InsertVehiculo(idvehiculo, marca, modelo, matricula, annio, idtipo);

            if (resultado > 0)
            {
                txtMensaje.Text = "Nuevo Registro Agregado Satisfactoriamente";
            }
            else
            {
                txtMensaje.Text = "Id ya Existe, agregue otro o no se inserto el dato";
                negocio = null;
            }
            limpiarCampos();
        }

        private void cmbIdtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.ObtenerVehiculos();
            txtMensaje.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int idvehiculo = Int32.Parse(txtIdVehiculo.Text);
            string matricula = txtMatricula.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int annio = Int32.Parse(txtAnnio.Text);
            int idtipo = Convert.ToInt32(cmbIdtipo.SelectedValue);
            int resultado = negocio.UpdateVehiculo(idvehiculo, marca, modelo, matricula, annio, idtipo);

            if (resultado > 0)
            {
                txtMensaje.Text = "Registro Actualizado";
            }
            else
            {
                txtMensaje.Text = "Registro no Actualizado";
                negocio = null;
            }
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoLogica negocio = new AccesoLogica();
            int idvehiculo = Int32.Parse(txtIdVehiculo.Text);
            int resultado = negocio.DeleteVehiculo(idvehiculo);
            if (resultado > 0)
            {
                txtMensaje.Text = "Registro Eliminado";
            }
            else
            {
                txtMensaje.Text = "Registro no Eliminado";
                negocio = null;
            }
        }
    }
}
