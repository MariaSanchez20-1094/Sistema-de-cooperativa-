
namespace COOPERATIVAahcr
{
    partial class logIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.user = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.COOPERATIVA = new System.Windows.Forms.Label();
            this.mostrarContraseña = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(111, 249);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(218, 22);
            this.user.TabIndex = 0;
            this.user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(111, 297);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(218, 22);
            this.contraseña.TabIndex = 1;
            this.contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // COOPERATIVA
            // 
            this.COOPERATIVA.AutoSize = true;
            this.COOPERATIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COOPERATIVA.Location = new System.Drawing.Point(12, 9);
            this.COOPERATIVA.Name = "COOPERATIVA";
            this.COOPERATIVA.Size = new System.Drawing.Size(397, 17);
            this.COOPERATIVA.TabIndex = 3;
            this.COOPERATIVA.Text = "SISTEMA COOPERATIVA DE AHORRO Y CREDITO AHOCRE";
            this.COOPERATIVA.Click += new System.EventHandler(this.label1_Click);
            // 
            // mostrarContraseña
            // 
            this.mostrarContraseña.AutoSize = true;
            this.mostrarContraseña.Location = new System.Drawing.Point(141, 325);
            this.mostrarContraseña.Name = "mostrarContraseña";
            this.mostrarContraseña.Size = new System.Drawing.Size(153, 21);
            this.mostrarContraseña.TabIndex = 4;
            this.mostrarContraseña.Text = "Mostrar contraseña";
            this.mostrarContraseña.UseVisualStyleBackColor = true;
            this.mostrarContraseña.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COOPERATIVAahcr.Properties.Resources.imagenLogIn;
            this.pictureBox1.Location = new System.Drawing.Point(62, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 176);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(108, 229);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(125, 17);
            this.lbNombreUsuario.TabIndex = 6;
            this.lbNombreUsuario.Text = "Nombre Usuario";
            this.lbNombreUsuario.Click += new System.EventHandler(this.lbNombreUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña";
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mostrarContraseña);
            this.Controls.Add(this.COOPERATIVA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.user);
            this.Name = "logIn";
            this.Text = "Inicio de sesión - LogIn ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label COOPERATIVA;
        private System.Windows.Forms.CheckBox mostrarContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Label label1;
    }
}

