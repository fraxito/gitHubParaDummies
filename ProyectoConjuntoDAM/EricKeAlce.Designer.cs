namespace ProyectoConjuntoDAM
{
    partial class EricKeAlce
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
            this.InicioDesdeEric = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InicioDesdeEric
            // 
            this.InicioDesdeEric.Location = new System.Drawing.Point(108, 81);
            this.InicioDesdeEric.Name = "InicioDesdeEric";
            this.InicioDesdeEric.Size = new System.Drawing.Size(75, 23);
            this.InicioDesdeEric.TabIndex = 0;
            this.InicioDesdeEric.Text = "Ve al Inicio";
            this.InicioDesdeEric.UseVisualStyleBackColor = true;
            this.InicioDesdeEric.Click += new System.EventHandler(this.InicioDesdeEric_Click);
            // 
            // EricKeAlce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.InicioDesdeEric);
            this.Name = "EricKeAlce";
            this.Text = "EricKeAlce";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InicioDesdeEric;
    }
}