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
    public partial class BuscarAlumno : Form
    {
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarNombreSolo_Click(object sender, EventArgs e)
        {
            if (txtNombreSolo.Text == "")
            {
                MessageBox.Show("Debe ingresar el Nombre!!");
                return;
            }
            dgvMostrarDatos.DataSource = null;
            dgvMostrarDatos.DataSource= InicioSecion.service.consultaAlumno(txtNombreSolo.Text);

           
        }

    
    }
}
