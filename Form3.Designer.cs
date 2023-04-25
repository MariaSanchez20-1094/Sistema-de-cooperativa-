
namespace COOPERATIVAahcr
{
    partial class InicioSocios
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
            this.cbConfiguracion = new System.Windows.Forms.ComboBox();
            this.cbCuentaAhorro = new System.Windows.Forms.ComboBox();
            this.cbPrestamos = new System.Windows.Forms.ComboBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbConfiguracion
            // 
            this.cbConfiguracion.FormattingEnabled = true;
            this.cbConfiguracion.Items.AddRange(new object[] {
            "1.1 Cambiar info- básica",
            "2.2 Cambio contraseña"});
            this.cbConfiguracion.Location = new System.Drawing.Point(12, 17);
            this.cbConfiguracion.Name = "cbConfiguracion";
            this.cbConfiguracion.Size = new System.Drawing.Size(147, 24);
            this.cbConfiguracion.TabIndex = 0;
            this.cbConfiguracion.Text = "1. Configuración";
            this.cbConfiguracion.SelectedIndexChanged += new System.EventHandler(this.cbConfiguracion_SelectedIndexChanged);
            // 
            // cbCuentaAhorro
            // 
            this.cbCuentaAhorro.FormattingEnabled = true;
            this.cbCuentaAhorro.Items.AddRange(new object[] {
            "2.1 Reportes Cuentas",
            "2.2 Aporte a Cuenta Ahorro",
            "2.3 Retiro a Cuenta Ahorro",
            "2.4 Información Cuenta Ahorro"});
            this.cbCuentaAhorro.Location = new System.Drawing.Point(165, 17);
            this.cbCuentaAhorro.Name = "cbCuentaAhorro";
            this.cbCuentaAhorro.Size = new System.Drawing.Size(147, 24);
            this.cbCuentaAhorro.TabIndex = 1;
            this.cbCuentaAhorro.Text = "2. Cuentas Ahorro";
            // 
            // cbPrestamos
            // 
            this.cbPrestamos.FormattingEnabled = true;
            this.cbPrestamos.Items.AddRange(new object[] {
            "3.1 Información Prestamo.",
            "3.2 Pagar Prestamo.",
            "3.3 Abonar Capital Prestamo.",
            "3.4 Saldar Prestamo."});
            this.cbPrestamos.Location = new System.Drawing.Point(318, 17);
            this.cbPrestamos.Name = "cbPrestamos";
            this.cbPrestamos.Size = new System.Drawing.Size(147, 24);
            this.cbPrestamos.TabIndex = 2;
            this.cbPrestamos.Text = "3. Prestamos";
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(610, 33);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(128, 55);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(632, 101);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 45);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(632, 183);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(79, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(36, 79);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(129, 22);
            this.nombre.TabIndex = 7;
            this.nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(234, 87);
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Size = new System.Drawing.Size(146, 22);
            this.apellido.TabIndex = 8;
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(414, 95);
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Size = new System.Drawing.Size(154, 22);
            this.cedula.TabIndex = 9;
            // 
            // InicioSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 265);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.cbPrestamos);
            this.Controls.Add(this.cbCuentaAhorro);
            this.Controls.Add(this.cbConfiguracion);
            this.Name = "InicioSocios";
            this.Text = "Menú Inicio - Socios";
            this.Load += new System.EventHandler(this.InicioSocios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConfiguracion;
        private System.Windows.Forms.ComboBox cbCuentaAhorro;
        private System.Windows.Forms.ComboBox cbPrestamos;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox cedula;
    }
}