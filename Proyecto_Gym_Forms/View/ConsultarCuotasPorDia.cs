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
    public partial class ConsultarCuotasPorDia : Form
    {
        public ConsultarCuotasPorDia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvResultados.DataSource = null;

            dgvResultados.DataSource = IniciarSecion.service.consultarCuotas(dtpFecha.Value);


        }
    }
}
