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
    public partial class IniciarSecion : Form
    {
        public static IService service;
        public static string responsableLogueado;

        public IniciarSecion()
        {
            InitializeComponent();
            service = new Service();
            dtpFecha.Enabled = false;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtContraseña.Text== "" || txtUsuario.Text=="" )
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Atención!!");
                return;
            }
            Login login =new Login();
            login.Usuario= txtUsuario.Text;
            login.Password = txtContraseña.Text;
            if (service.validarLogin(login))
            {
                responsableLogueado = txtUsuario.Text;
                Menu_Principal inicio = new Menu_Principal();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña Invalidas");
            }
           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Esta saliendo de toda la aplicacion, esta seguro?", "Atencion", MessageBoxButtons.YesNo);
                        
                if(respuesta== DialogResult.Yes)
                {
                MessageBox.Show("Adios, hasta la próxima  ;)  ");
                this.Close();
                }
                else
                {
                    MessageBox.Show("Perfecto, ahora ingrese usuario y contraseña para seguir por favor");
                }
            
           
        }
    }
}
