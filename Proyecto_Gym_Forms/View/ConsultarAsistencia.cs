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
    public partial class ConsultarAsistencia : Form
    {
        public ConsultarAsistencia()
        {
            InitializeComponent();
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI del alumno que quiere pagar la cuota", "Atención",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Alumno alumno = IniciarSecion.service.consultaAlumno(Convert.ToInt32(txtDNI.Text));

            if (alumno.nombre == null)
            {
                MessageBox.Show("Atención, el DNI no existe en nuestros registros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
               
                txtNombre.Text = alumno.nombre;
                txtApellido.Text = alumno.apellido;
               dgvMostrarDatos.DataSource= IniciarSecion.service.consultarAsistencia(Convert.ToInt32(txtDNI.Text));
                ResizeColumnsToFit();
            }


        }

        private void ResizeColumnsToFit()
        {
            dgvMostrarDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
