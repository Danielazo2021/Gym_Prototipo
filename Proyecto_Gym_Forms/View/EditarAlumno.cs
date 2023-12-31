﻿using Proyecto_Gym_Forms.Services;
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
    public partial class EditarAlumno : Form
    {
        public EditarAlumno()
        {
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;

            cargarCombo();
            habilitarCampos(false);
        }

        private void habilitarCampos(bool opcion)
        {
            txtApellido.Enabled = opcion;
            txtNombre.Enabled = opcion;
            txtEdad.Enabled = opcion;
            txtObservaciones.Enabled = opcion;
            cboSexo.Enabled = opcion;
        }

        private void cargarCombo()
        {
            string[] sexos = { "M", "F", "X" };
            cboSexo.DataSource = sexos;
        }

        private void EditarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text== "")
            {
                MessageBox.Show("Debe ingresar el DNI del alumno que quiere editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Alumno alumno = IniciarSecion.service.consultaAlumno(Convert.ToInt32(txtDNI.Text));

            if (alumno.nombre== null)
            {
                MessageBox.Show("Atención, el DNI no existe en nuestros registros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                habilitarCampos(true);

                txtNombre.Text = alumno.nombre;
                txtApellido.Text = alumno.apellido;
                txtEdad.Text= alumno.edad.ToString();
                txtObservaciones.Text = alumno.observaciones;
                txtTelefono.Text = alumno.telefono;
                txtInfoEmergencia.Text = alumno.contactoDeEmergencia;
                switch (alumno.sexo)
                {
                    case "M":
                    case "m":

                        cboSexo.SelectedIndex = 0;
                        break;
                    case "F":
                    case "f":
                        cboSexo.SelectedIndex = 1;
                        break;
                    case "X":
                    case "x":
                        cboSexo.SelectedIndex = 2;
                        break;
                         
                    default:
                        cboSexo.SelectedIndex = -1;
                        break;
                }
               
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = txtNombre.Text;
            alumno.apellido = txtApellido.Text;
            alumno.dni = Convert.ToInt32(txtDNI.Text);
            alumno.edad = Convert.ToInt32(txtEdad.Text);
            alumno.sexo = cboSexo.SelectedItem.ToString();
            alumno.telefono = txtTelefono.Text;
            alumno.contactoDeEmergencia= txtInfoEmergencia.Text;
            if (txtObservaciones.Text == "")
            {
                alumno.observaciones = "ok";
            }
            else
            {
                alumno.observaciones = txtObservaciones.Text;
            }

            if (IniciarSecion.service.actualizarAlumno(alumno))
            {
                MessageBox.Show("Se actualizo con exito!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Error al actualizar el alumno!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            borrarCampos();
            habilitarCampos(false);
            
        }
        private void borrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEdad.Clear();
            txtObservaciones.Clear();
            txtInfoEmergencia.Clear();
            txtTelefono.Clear();

        }
    }
}
