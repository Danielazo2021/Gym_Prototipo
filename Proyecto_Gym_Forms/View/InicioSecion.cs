using Proyecto_Gym_Forms.Model;
using Proyecto_Gym_Forms.Services;
using Proyecto_Gym_Forms.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gym_Forms
{
    public partial class InicioSecion : Form
    {
        public static IService service;

        public InicioSecion()
        {
            InitializeComponent();
            service = new Service();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login login =new Login();
            login.Usuario= txtUsuario.Text;
            login.Password = txtContraseña.Text;
            if (service.validarLogin(login))
            {
                Menu_Principal inicio = new Menu_Principal();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña Invalidas");
            }
           

        }
    }
}
