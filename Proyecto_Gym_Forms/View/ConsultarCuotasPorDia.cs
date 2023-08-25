﻿using System;
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
           
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvResultados.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dgvResultados.DataSource = null;
            
            dgvResultados.DataSource = IniciarSecion.service.consultarCuotas(dtpFecha.Value);
            ResizeColumnsToFit();

        }
        private void ResizeColumnsToFit()
        {
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

      
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarCuotasPorDia_Load(object sender, EventArgs e)
        {

        }
    }
}
