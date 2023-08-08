using Proyecto_Gym_Forms.Services;
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
    public partial class AgregarAlumno : Form
    {
        public AgregarAlumno()
        {
            InitializeComponent();
            dtpFechaDeAlta.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = txtNombre.Text;
            alumno.apellido = txtApellido.Text;
            alumno.dni = Convert.ToInt32(txtDNI.Text);
            alumno.edad = Convert.ToInt32(txtEdad.Text);
            alumno.sexo = cboSexo.SelectedItem.ToString();
            if (txtObservaciones.Text == "")
            {
                alumno.observaciones = "ok";
            }
                else
                {
                    alumno.observaciones = txtObservaciones.Text;
                }
            alumno.fechaAlta=dtpFechaDeAlta.Value;

            if (IniciarSecion.service.consultaAlumno(alumno.dni).nombre != null)
            {
                MessageBox.Show("Atención, ya existe un alumno cargado con ese DNI");
               
            }
                else if (IniciarSecion.service.agregarAlumno(alumno))
                {
                    MessageBox.Show("Alumno agregado con exito");

                    borrarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el alumno");
                }
        }

        private void borrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEdad.Clear();
            txtObservaciones.Clear();

        }

        private void AgregarAlumno_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void cargarCombo()
        {
            string[] sexos = { "m", "f", "x" };
            cboSexo.DataSource = sexos;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            borrarCampos();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
