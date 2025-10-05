using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlador;

namespace presentacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SelectVehiculos();
            SelectTipoCon();
            limpiarCampos();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            cmbVehi.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            numId.Value = 0;
            txtNombre.Text = "";
            numId.Focus();
        }

        private void SelectVehiculos()
        {
            DataTable datos = AccesoLogica.ObtenerVehiculos();
            cmbVehi.DataSource = datos;
            cmbVehi.DisplayMember = "Matricula";
            cmbVehi.ValueMember = "IdVehi";
        }

        private void SelectTipoCon()
        {
            DataTable datos = AccesoLogica.ObtenerTiposConductor();
            cmbTipo.DataSource = datos;
            cmbTipo.DisplayMember = "NombreTipoCon";
            cmbTipo.ValueMember = "IdTipoCon";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccesoLogica actualizar = new AccesoLogica();
            int idConductor = Convert.ToInt32(numId.Value);
            string nombre = txtNombre.Text;
            int idVehiculo = Convert.ToInt32(cmbVehi.SelectedValue);
            int idTipoCon = Convert.ToInt32(cmbTipo.SelectedValue);
            int resultado = actualizar.UpdateConductor(idConductor, nombre, idVehiculo, idTipoCon);
            if (resultado > 0)
                txtMensaje.Text = "Registro Actualizado Satisfactoriamente";
            else
                txtMensaje.Text = "No se Actualizo el dato, verifique el Id";
            limpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AccesoLogica registrar = new AccesoLogica();
            int idConductor = Convert.ToInt32(numId.Value);
            string nombre = txtNombre.Text;
            int idVehiculo = Convert.ToInt32(cmbVehi.SelectedValue);
            int idTipoCon = Convert.ToInt32(cmbTipo.SelectedValue);
            int resultado = registrar.InsertConductor(idConductor, nombre, idVehiculo, idTipoCon);
            if (resultado > 0)
            {
                txtMensaje.Text = "Registro Actualizado";
            }
            else
            {
                txtMensaje.Text = "Registro no Actualizado";
                btnActualizar = null;
            }
            limpiarCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccesoLogica.ObtenerConductores();
            txtMensaje.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoLogica eliminar = new AccesoLogica();
            int idConductor = Convert.ToInt32(numId.Value);
            int resultado = eliminar.DeleteConductor(idConductor);
            if (resultado > 0)
            {
                txtMensaje.Text = "Registro Eliminado";
            }
            else
            {
                txtMensaje.Text = "Registro no Eliminado";
                eliminar = null;
            }
        }
    }
}
