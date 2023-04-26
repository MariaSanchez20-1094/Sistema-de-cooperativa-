
namespace COOPERATIVAahcr
{
    partial class frmGestionPrestamos
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
            this.agregarNuevo = new System.Windows.Forms.Button();
            this.volverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agregarNuevo
            // 
            this.agregarNuevo.Location = new System.Drawing.Point(579, 47);
            this.agregarNuevo.Name = "agregarNuevo";
            this.agregarNuevo.Size = new System.Drawing.Size(95, 47);
            this.agregarNuevo.TabIndex = 0;
            this.agregarNuevo.Text = "AGREGAR NUEVO";
            this.agregarNuevo.UseVisualStyleBackColor = true;
            // 
            // volverAtras
            // 
            this.volverAtras.Location = new System.Drawing.Point(579, 117);
            this.volverAtras.Name = "volverAtras";
            this.volverAtras.Size = new System.Drawing.Size(95, 47);
            this.volverAtras.TabIndex = 1;
            this.volverAtras.Text = "VOLVER ATRÁS";
            this.volverAtras.UseVisualStyleBackColor = true;
            this.volverAtras.Click += new System.EventHandler(this.volverAtras_Click);
            // 
            // frmGestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volverAtras);
            this.Controls.Add(this.agregarNuevo);
            this.Name = "frmGestionPrestamos";
            this.Text = "FORMILARIO GESTIÓN - PRESTAMOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button agregarNuevo;
        private System.Windows.Forms.Button volverAtras;
    }
}