
namespace COOPERATIVAahcr
{
    partial class frmCuentasAhorro
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
            this.botonAgregar = new System.Windows.Forms.Button();
            this.volverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(675, 86);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(96, 46);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.Text = "AGREGAR NUEVO";
            this.botonAgregar.UseVisualStyleBackColor = true;
            // 
            // volverAtras
            // 
            this.volverAtras.Location = new System.Drawing.Point(675, 150);
            this.volverAtras.Name = "volverAtras";
            this.volverAtras.Size = new System.Drawing.Size(96, 55);
            this.volverAtras.TabIndex = 1;
            this.volverAtras.Text = "VOLVER ATRÁS";
            this.volverAtras.UseVisualStyleBackColor = true;
            this.volverAtras.Click += new System.EventHandler(this.volverAtras_Click);
            // 
            // frmCuentasAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volverAtras);
            this.Controls.Add(this.botonAgregar);
            this.Name = "frmCuentasAhorro";
            this.Text = "FORMULARIO GESTIÓN - CUENTAS AHORRO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button volverAtras;
    }
}