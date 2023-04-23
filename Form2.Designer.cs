namespace SisCoperativa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.cmbReportes = new System.Windows.Forms.ComboBox();
            this.cmbConfiguracion = new System.Windows.Forms.ComboBox();
            this.btnUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.ImageKey = "(ninguno)";
            this.btnSalir.Location = new System.Drawing.Point(12, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalir.Size = new System.Drawing.Size(85, 53);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(354, 12);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 28);
            this.cmbProductos.TabIndex = 7;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // cmbReportes
            // 
            this.cmbReportes.FormattingEnabled = true;
            this.cmbReportes.Location = new System.Drawing.Point(205, 12);
            this.cmbReportes.Name = "cmbReportes";
            this.cmbReportes.Size = new System.Drawing.Size(121, 28);
            this.cmbReportes.TabIndex = 8;
            this.cmbReportes.SelectedIndexChanged += new System.EventHandler(this.cmbReportes_SelectedIndexChanged);
            // 
            // cmbConfiguracion
            // 
            this.cmbConfiguracion.FormattingEnabled = true;
            this.cmbConfiguracion.Location = new System.Drawing.Point(499, 12);
            this.cmbConfiguracion.Name = "cmbConfiguracion";
            this.cmbConfiguracion.Size = new System.Drawing.Size(121, 28);
            this.cmbConfiguracion.TabIndex = 9;
            this.cmbConfiguracion.SelectedIndexChanged += new System.EventHandler(this.cmbConfiguracion_SelectedIndexChanged);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(655, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(121, 34);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.cmbConfiguracion);
            this.Controls.Add(this.cmbReportes);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.ComboBox cmbReportes;
        private System.Windows.Forms.ComboBox cmbConfiguracion;
        private System.Windows.Forms.Button btnUsuarios;
    }
}