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
    public partial class PagarCuota : Form
    {
        public PagarCuota()
        {
            InitializeComponent();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            calcularVencimiento();
            cargarFormasDePago();
            txtResponsable.Text = InicioSecion.responsableLogueado;

            // no se debe editar desde esta pesataña ni nombre ni apellido
            habilitarCampos(false);
        }

        private void cargarFormasDePago()
        {
            string[] formasDePago = { "Efectivo", "Tarjeta De Debito","Tarjeta De Credito",
                                    "Transferencia", "Mercado Pago", "Otros(Aclarar en Observaciones)" };
            cboFormasDePago.DataSource = formasDePago;

        }

        private void habilitarCampos(bool valor)
        {
            
            txtMontoCuota.Enabled=valor;
            txtObservaciones.Enabled = valor;
            txtResponsable.Enabled = valor;
            btnActualizar.Enabled = valor;
            btnCancelar.Enabled = valor;
            dtpFinCuota.Enabled = valor;
            dtpInicioCuota.Enabled = valor;
            cboFormasDePago.Enabled = valor;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DatosCuotas datosCuota = new DatosCuotas();
            datosCuota.alumno = InicioSecion.service.consultaAlumno(Convert.ToInt32(txtDNI.Text));
            datosCuota.valorCuota = Convert.ToInt32(txtMontoCuota.Text);
            datosCuota.fechaInicio = dtpInicioCuota.Value;
            datosCuota.fechaVencimiento = dtpFinCuota.Value;
            datosCuota.observaciones = txtObservaciones.Text;
            datosCuota.responsableDeCobro = txtResponsable.Text;
            datosCuota.formaDePago = cboFormasDePago.Text;


            if(InicioSecion.service.cobrarCuota(datosCuota))
            {
                MessageBox.Show("Se registro el cobro con exito");
                limpiarCampos();

            }
            else
            {
                MessageBox.Show("Ocurrio un error al registrar cobro");
            }


        }

        private void limpiarCampos()
        {
            txtMontoCuota.Text = "";
            txtObservaciones.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDNI.Text = "";
            cboFormasDePago.SelectedIndex = -1;
            dtpInicioCuota.Value = DateTime.Now;
            calcularVencimiento();

            habilitarCampos(false);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI del alumno que quiere pagar la cuota");
                return;
            }

            Alumno alumno = InicioSecion.service.consultaAlumno(Convert.ToInt32(txtDNI.Text));

            if (alumno.nombre == null)
            {
                MessageBox.Show("Atención, el DNI no existe en nuestros registros");
                return;
            }
            else
            {
                habilitarCampos(true);
                txtNombre.Text = alumno.nombre;
                txtApellido.Text = alumno.apellido;

            }



        }

        private void dtpInicioCuota_ValueChanged(object sender, EventArgs e)
        {
            calcularVencimiento();
           
        }

        private void calcularVencimiento()
        {
            DateTime fechaInicio = dtpInicioCuota.Value;
            DateTime fechaFin = fechaInicio.AddDays(30);
            dtpFinCuota.Value = fechaFin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            limpiarCampos();

        }

        
    }
}
