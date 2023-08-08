using Proyecto_Gym_Forms.Model;
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
    public partial class RegistrarAsistencia : Form
    {
        public RegistrarAsistencia()
        {
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            btnConfirmarAsistencia.Enabled = false;

        }

        private void RegistrarAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI del alumno que quiere registrar la asistencia", "Atención");
                return;
            }

            Alumno alumno = IniciarSecion.service.consultaAlumno(Convert.ToInt32(txtDNI.Text));

            if (alumno.nombre == null)
            {
                MessageBox.Show("Atención, el DNI no existe en nuestros registros", "Atención");
                return;
            }
            else
            {               
                txtNombre.Text = alumno.nombre;
                txtApellido.Text = alumno.apellido;
                btnConfirmarAsistencia.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

        }

        private void btnConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI del alumno que quiere registrar la asistencia", "Atención");
                return;
            }
            else
            {
                Asistencia asistencia = new Asistencia();
                asistencia.dni = Convert.ToInt32(txtDNI.Text);
                asistencia.fecha= dtpFechaAsistencia.Value;
                bool resultado= IniciarSecion.service.registrarAsistencia(asistencia);
                if (resultado)
                {
                    MessageBox.Show("Se registro con exito la asistencia!!");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al registrar la asistencia");
                }
            }


        }

        private void limpiarCampos()
        {

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            btnConfirmarAsistencia.Enabled = false;
        }
    }
}
