﻿namespace ProyectoConjuntoDAM
{
    partial class FormularioEntrada
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.botonJorgeCisneros = new System.Windows.Forms.Button();
            this.EugenioAM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cada uno crea un botón que se llame con su nombre + apellido";
            // 
            // botonJorgeCisneros
            // 
            this.botonJorgeCisneros.Location = new System.Drawing.Point(32, 70);
            this.botonJorgeCisneros.Name = "botonJorgeCisneros";
            this.botonJorgeCisneros.Size = new System.Drawing.Size(89, 23);
            this.botonJorgeCisneros.TabIndex = 1;
            this.botonJorgeCisneros.Text = "JorgeCisneros";
            this.botonJorgeCisneros.UseVisualStyleBackColor = true;
            // 
            // EugenioAM
            // 
            this.EugenioAM.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EugenioAM.ForeColor = System.Drawing.Color.Blue;
            this.EugenioAM.Location = new System.Drawing.Point(145, 63);
            this.EugenioAM.Name = "EugenioAM";
            this.EugenioAM.Size = new System.Drawing.Size(86, 33);
            this.EugenioAM.TabIndex = 2;
            this.EugenioAM.Text = "Ir a Eu\'s";
            this.EugenioAM.UseVisualStyleBackColor = true;
            // 
            // FormularioEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 484);
            this.Controls.Add(this.EugenioAM);
            this.Controls.Add(this.botonJorgeCisneros);
            this.Controls.Add(this.label1);
            this.Name = "FormularioEntrada";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonJorgeCisneros;
        private System.Windows.Forms.Button EugenioAM;
    }
}

