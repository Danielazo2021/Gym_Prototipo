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
    public partial class VerificarVencimientoPorFecha : Form
    {
        public VerificarVencimientoPorFecha()
        {
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            dgvResultados.DataSource = null;

            dgvResultados.DataSource= IniciarSecion.service.buscarProximosVencimientos(dtpDesde.Value, dtpHasta.Value);
            ResizeColumnsToFit();
        }

       
        private void ResizeColumnsToFit()
        {
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
