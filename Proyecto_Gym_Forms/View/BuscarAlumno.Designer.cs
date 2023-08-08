namespace Proyecto_Gym_Forms.View
{
    partial class BuscarAlumno
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombreDe2campos = new System.Windows.Forms.TextBox();
            this.btnBuscarNombreYApellido = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreSolo = new System.Windows.Forms.TextBox();
            this.gbxNombreSolo = new System.Windows.Forms.GroupBox();
            this.btnBuscarNombreSolo = new System.Windows.Forms.Button();
            this.gbNombreYApellido = new System.Windows.Forms.GroupBox();
            this.bgxDni = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorDni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxNombreSolo.SuspendLayout();
            this.gbNombreYApellido.SuspendLayout();
            this.bgxDni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(17, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(17, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(124, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(129, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombreDe2campos
            // 
            this.txtNombreDe2campos.Location = new System.Drawing.Point(124, 21);
            this.txtNombreDe2campos.Name = "txtNombreDe2campos";
            this.txtNombreDe2campos.Size = new System.Drawing.Size(129, 20);
            this.txtNombreDe2campos.TabIndex = 6;
            // 
            // btnBuscarNombreYApellido
            // 
            this.btnBuscarNombreYApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombreYApellido.Location = new System.Drawing.Point(124, 76);
            this.btnBuscarNombreYApellido.Name = "btnBuscarNombreYApellido";
            this.btnBuscarNombreYApellido.Size = new System.Drawing.Size(129, 28);
            this.btnBuscarNombreYApellido.TabIndex = 21;
            this.btnBuscarNombreYApellido.Text = "Buscar";
            this.btnBuscarNombreYApellido.UseVisualStyleBackColor = true;
            this.btnBuscarNombreYApellido.Click += new System.EventHandler(this.btnBuscarNombreYApellido_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(820, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 60);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Volver atrás";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre";
            // 
            // txtNombreSolo
            // 
            this.txtNombreSolo.Location = new System.Drawing.Point(116, 31);
            this.txtNombreSolo.Name = "txtNombreSolo";
            this.txtNombreSolo.Size = new System.Drawing.Size(129, 20);
            this.txtNombreSolo.TabIndex = 23;
            // 
            // gbxNombreSolo
            // 
            this.gbxNombreSolo.Controls.Add(this.btnBuscarNombreSolo);
            this.gbxNombreSolo.Controls.Add(this.label1);
            this.gbxNombreSolo.Controls.Add(this.txtNombreSolo);
            this.gbxNombreSolo.Location = new System.Drawing.Point(12, 73);
            this.gbxNombreSolo.Name = "gbxNombreSolo";
            this.gbxNombreSolo.Size = new System.Drawing.Size(264, 114);
            this.gbxNombreSolo.TabIndex = 25;
            this.gbxNombreSolo.TabStop = false;
            // 
            // btnBuscarNombreSolo
            // 
            this.btnBuscarNombreSolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombreSolo.Location = new System.Drawing.Point(116, 80);
            this.btnBuscarNombreSolo.Name = "btnBuscarNombreSolo";
            this.btnBuscarNombreSolo.Size = new System.Drawing.Size(129, 28);
            this.btnBuscarNombreSolo.TabIndex = 26;
            this.btnBuscarNombreSolo.Text = "Buscar";
            this.btnBuscarNombreSolo.UseVisualStyleBackColor = true;
            this.btnBuscarNombreSolo.Click += new System.EventHandler(this.btnBuscarNombreSolo_Click);
            // 
            // gbNombreYApellido
            // 
            this.gbNombreYApellido.Controls.Add(this.txtNombreDe2campos);
            this.gbNombreYApellido.Controls.Add(this.txtApellido);
            this.gbNombreYApellido.Controls.Add(this.lblNombre);
            this.gbNombreYApellido.Controls.Add(this.btnBuscarNombreYApellido);
            this.gbNombreYApellido.Controls.Add(this.lblApellido);
            this.gbNombreYApellido.Location = new System.Drawing.Point(314, 73);
            this.gbNombreYApellido.Name = "gbNombreYApellido";
            this.gbNombreYApellido.Size = new System.Drawing.Size(298, 114);
            this.gbNombreYApellido.TabIndex = 26;
            this.gbNombreYApellido.TabStop = false;
            // 
            // bgxDni
            // 
            this.bgxDni.Controls.Add(this.btnBuscarPorDni);
            this.bgxDni.Controls.Add(this.label2);
            this.bgxDni.Controls.Add(this.txtDni);
            this.bgxDni.Location = new System.Drawing.Point(641, 82);
            this.bgxDni.Name = "bgxDni";
            this.bgxDni.Size = new System.Drawing.Size(276, 105);
            this.bgxDni.TabIndex = 27;
            this.bgxDni.TabStop = false;
            // 
            // btnBuscarPorDni
            // 
            this.btnBuscarPorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorDni.Location = new System.Drawing.Point(116, 71);
            this.btnBuscarPorDni.Name = "btnBuscarPorDni";
            this.btnBuscarPorDni.Size = new System.Drawing.Size(129, 28);
            this.btnBuscarPorDni.TabIndex = 26;
            this.btnBuscarPorDni.Text = "Buscar";
            this.btnBuscarPorDni.UseVisualStyleBackColor = true;
            this.btnBuscarPorDni.Click += new System.EventHandler(this.btnBuscarPorDni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(116, 22);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(129, 20);
            this.txtDni.TabIndex = 23;
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(128, 210);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.Size = new System.Drawing.Size(641, 122);
            this.dgvMostrarDatos.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Buscar Alumno";
            // 
            // BuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.bgxDni);
            this.Controls.Add(this.gbNombreYApellido);
            this.Controls.Add(this.gbxNombreSolo);
            this.Controls.Add(this.btnBack);
            this.Name = "BuscarAlumno";
            this.Text = "BuscarAlumno";
            this.gbxNombreSolo.ResumeLayout(false);
            this.gbxNombreSolo.PerformLayout();
            this.gbNombreYApellido.ResumeLayout(false);
            this.gbNombreYApellido.PerformLayout();
            this.bgxDni.ResumeLayout(false);
            this.bgxDni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombreDe2campos;
        private System.Windows.Forms.Button btnBuscarNombreYApellido;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreSolo;
        private System.Windows.Forms.GroupBox gbxNombreSolo;
        private System.Windows.Forms.Button btnBuscarNombreSolo;
        private System.Windows.Forms.GroupBox gbNombreYApellido;
        private System.Windows.Forms.GroupBox bgxDni;
        private System.Windows.Forms.Button btnBuscarPorDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Label label3;
    }
}