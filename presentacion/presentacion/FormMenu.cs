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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }

        private void label1TITULO_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formVehiculos = new Form3();
            formVehiculos.Show();
        }

        private void btnTipoVehi_Click(object sender, EventArgs e)
        {
            Form1 formTipoVehi = new Form1();
            formTipoVehi.Show();
        }

        private void btnTipoCon_Click(object sender, EventArgs e)
        {
            Form2 TipoCon = new Form2();
            TipoCon.Show();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            Form4 formConductor = new Form4();
            formConductor.Show();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            Form5 formContrato = new Form5();
            formContrato.Show();
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            Form6 formRuta = new Form6();
            formRuta.Show();
        }
    }
}
