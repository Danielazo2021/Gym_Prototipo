using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gym_Forms.View
{
    public partial class VerificarVencimiento : Form
    {
        public VerificarVencimiento()
        {
            InitializeComponent();
        }

        private void VerificarVencimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            dgvResultados.DataSource = null;

            dgvResultados.DataSource= IniciarSecion.service.buscarProximosVencimientos(dtpDesde.Value, dtpHasta.Value);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
