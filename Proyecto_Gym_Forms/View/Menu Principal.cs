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
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno nuevoAlumno =new AgregarAlumno();
            nuevoAlumno.Show();
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            EditarAlumno editar = new EditarAlumno();
            editar.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            PagarCuota pagarCuota = new PagarCuota();
            pagarCuota.Show();
        }
    }
}
