namespace Proyecto_Gym_Forms.View
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnActualizarAlumno = new System.Windows.Forms.Button();
            this.btnVerificarVencimiento = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Location = new System.Drawing.Point(248, 43);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(113, 60);
            this.btnNuevoAlumno.TabIndex = 0;
            this.btnNuevoAlumno.Text = "Registrar nuevo alumno";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.Location = new System.Drawing.Point(247, 119);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(114, 60);
            this.btnPagarCuota.TabIndex = 1;
            this.btnPagarCuota.Text = "Pagar cuota";
            this.btnPagarCuota.UseVisualStyleBackColor = true;
            // 
            // btnActualizarAlumno
            // 
            this.btnActualizarAlumno.Location = new System.Drawing.Point(248, 200);
            this.btnActualizarAlumno.Name = "btnActualizarAlumno";
            this.btnActualizarAlumno.Size = new System.Drawing.Size(114, 55);
            this.btnActualizarAlumno.TabIndex = 2;
            this.btnActualizarAlumno.Text = "Actualizar datos del alumno";
            this.btnActualizarAlumno.UseVisualStyleBackColor = true;
            this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);
            // 
            // btnVerificarVencimiento
            // 
            this.btnVerificarVencimiento.Location = new System.Drawing.Point(247, 278);
            this.btnVerificarVencimiento.Name = "btnVerificarVencimiento";
            this.btnVerificarVencimiento.Size = new System.Drawing.Size(114, 48);
            this.btnVerificarVencimiento.TabIndex = 3;
            this.btnVerificarVencimiento.Text = "Verificar Vencimiento";
            this.btnVerificarVencimiento.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(643, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 48);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Volver atrás";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnVerificarVencimiento);
            this.Controls.Add(this.btnActualizarAlumno);
            this.Controls.Add(this.btnPagarCuota);
            this.Controls.Add(this.btnNuevoAlumno);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnActualizarAlumno;
        private System.Windows.Forms.Button btnVerificarVencimiento;
        private System.Windows.Forms.Button btnBack;
    }
}