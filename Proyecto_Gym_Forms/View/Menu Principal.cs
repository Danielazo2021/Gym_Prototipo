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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
      
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno nuevoAlumno =new AgregarAlumno();
            nuevoAlumno.ShowDialog();
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            EditarAlumno editar = new EditarAlumno();
            editar.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            PagarCuota pagarCuota = new PagarCuota();
            pagarCuota.ShowDialog();
        }

        private void btnVerificarVencimiento_Click(object sender, EventArgs e)
        {
            VerificarVencimientoPorFecha verificarVencimiento = new VerificarVencimientoPorFecha();
            verificarVencimiento.ShowDialog();

        }

        private void btnBuscarPorNombreYApellido_Click(object sender, EventArgs e)
        {
            BuscarAlumno buscarAlumno = new BuscarAlumno();
            buscarAlumno.ShowDialog();
        }

        private void btnConsultarCuotasPorDia_Click(object sender, EventArgs e)
        {
            ConsultarCuotasPorDia cuotasPorDia = new ConsultarCuotasPorDia();
            cuotasPorDia.ShowDialog();

        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            RegistrarAsistencia registrarAsistencia= new RegistrarAsistencia();
            registrarAsistencia.ShowDialog();
        }

        private void btnConsultarAsistencia_Click(object sender, EventArgs e)
        {
            ConsultarAsistencia consultarAsistencia= new ConsultarAsistencia();
            consultarAsistencia.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
