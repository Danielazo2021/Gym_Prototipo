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
                       
            this.StartPosition = FormStartPosition.CenterScreen;

            dtpFechaDeAlta.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="")
            {
                MessageBox.Show("No puede dejar campos sin llenar");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("No puede dejar campos sin llenar");
                return;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show("No puede dejar campos sin llenar");
                return;
            }
            if (txtEdad.Text == "")
            {
                MessageBox.Show("No puede dejar campos sin llenar");
                return;
            }
            if (txtInfoEmergencia.Text == "")
            {
                MessageBox.Show("No puede dejar campos sin llenar");
                return;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("No puede dejar campos sin llenar");
                return;
            }



            Alumno alumno = new Alumno();
                alumno.nombre = txtNombre.Text;
                alumno.apellido = txtApellido.Text;
                alumno.dni = Convert.ToInt32(txtDNI.Text);
                alumno.edad = Convert.ToInt32(txtEdad.Text);
                alumno.sexo = cboSexo.SelectedItem.ToString();
                alumno.contactoDeEmergencia= txtInfoEmergencia.Text.Trim();
                alumno.telefono = txtTelefono.Text;

                if (txtObservaciones.Text == "")
                {
                    alumno.observaciones = "ok";
                }
                else
                {
                    alumno.observaciones = txtObservaciones.Text;
                }
                alumno.fechaAlta = dtpFechaDeAlta.Value;

                if (IniciarSecion.service.consultaAlumno(alumno.dni).nombre != null)
                {
                    MessageBox.Show("Ya existe un alumno cargado con ese DNI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (IniciarSecion.service.agregarAlumno(alumno))
                {
                    MessageBox.Show("Alumno agregado con exito");

                    borrarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el alumno", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string[] sexos = { "F", "M", "X" };
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

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
