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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            selectVehiculo();
            selectConductor();
            limpiarCampos();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            numIdContrato.Value = 0;
            cmbVehiculo.SelectedIndex = -1;
            cmbConductor.SelectedIndex = -1;
            numIdContrato.Focus();
        }

        private void selectVehiculo()
        {
            DataTable datos = AccesoLogica.ObtenerVehiculos();
            cmbVehiculo.DataSource = datos;
            cmbVehiculo.DisplayMember = "Matricula";
            cmbVehiculo.ValueMember = "IdVehi";
        }

        private void selectConductor()
        {
            DataTable datos = AccesoLogica.ObtenerConductores();
            cmbConductor.DataSource = datos;
            cmbConductor.DisplayMember = "Nombre";
            cmbConductor.ValueMember = "IdConductor";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AccesoLogica registrar = new AccesoLogica();
            int idContrato = Convert.ToInt32(numIdContrato.Value);
            int idVehiculo = Convert.ToInt32(cmbVehiculo.SelectedValue);
            int idConductor = Convert.ToInt32(cmbConductor.SelectedValue);
            int resultado = registrar.InsertContrato(idContrato, idVehiculo, idConductor);
            if (resultado > 0)
                txtMensaje.Text = "Nuevo Registro Agregado Sactisfactoriamente";
            else
                txtMensaje.Text = "Id ya Existe, agregue otro o no se inserto el dato";
            limpiarCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AccesoLogica listar = new AccesoLogica();
            dataGridView1.DataSource = AccesoLogica.ObtenerContratos();
            txtMensaje.Text = "";
            limpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AccesoLogica actualizar = new AccesoLogica();
            int idContrato = Convert.ToInt32(numIdContrato.Value);
            int idVehiculo = Convert.ToInt32(cmbVehiculo.SelectedValue);
            int idConductor = Convert.ToInt32(cmbConductor.SelectedValue);
            int resultado = actualizar.UpdateContrato(idContrato, idVehiculo, idConductor);
            if (resultado > 0)
                txtMensaje.Text = "Registro Actualizado Satisfactoriamente";
            else
                txtMensaje.Text = "No se Actualizo el dato, verifique el Id";
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccesoLogica eliminar = new AccesoLogica();
            int idContrato = Convert.ToInt32(numIdContrato.Value);
            int resultado = eliminar.DeleteContrato(idContrato);
            if (resultado > 0)
                txtMensaje.Text = "Registro Eliminado Satisfactoriamente";
            else
                txtMensaje.Text = "No se Elimino el dato, verifique el Id";
            limpiarCampos();
        }
    }
}
