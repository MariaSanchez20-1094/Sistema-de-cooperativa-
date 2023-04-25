
namespace COOPERATIVAahcr
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.sistemaCooperativaDataSet = new COOPERATIVAahcr.sistemaCooperativaDataSet();
            this.sistemaCooperativaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbConfiguracion = new System.Windows.Forms.ComboBox();
            this.cbReportes = new System.Windows.Forms.ComboBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.btnGestionSocios = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new COOPERATIVAahcr.sistemaCooperativaDataSetTableAdapters.USUARIOSTableAdapter();
            this.cUENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUENTATableAdapter = new COOPERATIVAahcr.sistemaCooperativaDataSetTableAdapters.CUENTATableAdapter();
            this.uSUARIOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaCooperativaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaCooperativaDataSet
            // 
            this.sistemaCooperativaDataSet.DataSetName = "sistemaCooperativaDataSet";
            this.sistemaCooperativaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaCooperativaDataSetBindingSource
            // 
            this.sistemaCooperativaDataSetBindingSource.DataSource = this.sistemaCooperativaDataSet;
            this.sistemaCooperativaDataSetBindingSource.Position = 0;
            // 
            // cbConfiguracion
            // 
            this.cbConfiguracion.FormattingEnabled = true;
            this.cbConfiguracion.Items.AddRange(new object[] {
            "1.1 Logs y eventos usuarios.",
            "1.2 Configuración conexión a base de datos.",
            "1.3 Backups/Restores.",
            "1.4 Alertas correo."});
            this.cbConfiguracion.Location = new System.Drawing.Point(12, 25);
            this.cbConfiguracion.Name = "cbConfiguracion";
            this.cbConfiguracion.Size = new System.Drawing.Size(145, 24);
            this.cbConfiguracion.TabIndex = 0;
            this.cbConfiguracion.Text = "1. Configuración";
            // 
            // cbReportes
            // 
            this.cbReportes.FormattingEnabled = true;
            this.cbReportes.Items.AddRange(new object[] {
            "2.1 Reporte administradores.",
            "2.2 Reporte socios. ",
            "2.3 Reporte prestamos.",
            "2.4 Reporte cuentas ahorro."});
            this.cbReportes.Location = new System.Drawing.Point(163, 25);
            this.cbReportes.Name = "cbReportes";
            this.cbReportes.Size = new System.Drawing.Size(145, 24);
            this.cbReportes.TabIndex = 1;
            this.cbReportes.Text = "2. Reportes";
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Items.AddRange(new object[] {
            "3.1 - Gestión Cuentas Ahorro Activas.",
            "3.2 - Gestión Prestamos Activos."});
            this.cbProductos.Location = new System.Drawing.Point(314, 24);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(151, 24);
            this.cbProductos.TabIndex = 2;
            this.cbProductos.Text = "3. Gestión Productos";
            // 
            // btnGestionSocios
            // 
            this.btnGestionSocios.Location = new System.Drawing.Point(471, 12);
            this.btnGestionSocios.Name = "btnGestionSocios";
            this.btnGestionSocios.Size = new System.Drawing.Size(148, 49);
            this.btnGestionSocios.TabIndex = 4;
            this.btnGestionSocios.Text = "Gestión Socios";
            this.btnGestionSocios.UseVisualStyleBackColor = true;
            this.btnGestionSocios.Click += new System.EventHandler(this.btnGestionSocios_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(623, 102);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 46);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(623, 202);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.sistemaCooperativaDataSetBindingSource;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // cUENTABindingSource
            // 
            this.cUENTABindingSource.DataMember = "CUENTA";
            this.cUENTABindingSource.DataSource = this.sistemaCooperativaDataSetBindingSource;
            // 
            // cUENTATableAdapter
            // 
            this.cUENTATableAdapter.ClearBeforeFill = true;
            // 
            // uSUARIOSBindingSource1
            // 
            this.uSUARIOSBindingSource1.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource1.DataSource = this.sistemaCooperativaDataSetBindingSource;
            // 
            // sistemaCooperativaDataSetBindingSource1
            // 
            this.sistemaCooperativaDataSetBindingSource1.DataSource = this.sistemaCooperativaDataSet;
            this.sistemaCooperativaDataSetBindingSource1.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(0, 148);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(170, 22);
            this.nombre.TabIndex = 8;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(193, 148);
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Size = new System.Drawing.Size(170, 22);
            this.apellido.TabIndex = 9;
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(387, 148);
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Size = new System.Drawing.Size(170, 22);
            this.cedula.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 428);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGestionSocios);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.cbReportes);
            this.Controls.Add(this.cbConfiguracion);
            this.Name = "FormPrincipal";
            this.Text = "Menú Inicio - Administradores";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sistemaCooperativaDataSetBindingSource;
        private sistemaCooperativaDataSet sistemaCooperativaDataSet;
        private System.Windows.Forms.ComboBox cbConfiguracion;
        private System.Windows.Forms.ComboBox cbReportes;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Button btnGestionSocios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private sistemaCooperativaDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.BindingSource cUENTABindingSource;
        private sistemaCooperativaDataSetTableAdapters.CUENTATableAdapter cUENTATableAdapter;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource1;
        private System.Windows.Forms.BindingSource sistemaCooperativaDataSetBindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox cedula;
    }
}