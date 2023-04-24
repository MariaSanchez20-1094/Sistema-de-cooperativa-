
namespace COOPERATIVAahcr
{
    partial class perfilUsuario
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sistemaCooperativaDataSet = new COOPERATIVAahcr.sistemaCooperativaDataSet();
            this.sistemaCooperativaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreUsuario,
            this.Nombre,
            this.Apellido,
            this.correo,
            this.Dirección,
            this.numTelefono,
            this.Ocupación,
            this.Score,
            this.Fecha,
            this.idPrestamo,
            this.numCuenta});
            this.dataGridView1.DataSource = this.sistemaCooperativaDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 334);
            this.dataGridView1.TabIndex = 1;
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
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "User";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreUsuario.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // correo
            // 
            this.correo.HeaderText = "CorreoElectronico";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.MinimumWidth = 6;
            this.Dirección.Name = "Dirección";
            this.Dirección.Width = 125;
            // 
            // numTelefono
            // 
            this.numTelefono.HeaderText = "Número Teléfono";
            this.numTelefono.MinimumWidth = 6;
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Width = 125;
            // 
            // Ocupación
            // 
            this.Ocupación.HeaderText = "Ocupación";
            this.Ocupación.MinimumWidth = 6;
            this.Ocupación.Name = "Ocupación";
            this.Ocupación.Width = 125;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score Crediticio";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Asociación";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // idPrestamo
            // 
            this.idPrestamo.HeaderText = "Prestamos Activos";
            this.idPrestamo.MinimumWidth = 6;
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.Width = 125;
            // 
            // numCuenta
            // 
            this.numCuenta.HeaderText = "Numero Cuenta Activa";
            this.numCuenta.MinimumWidth = 6;
            this.numCuenta.Name = "numCuenta";
            this.numCuenta.Width = 125;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // perfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 425);
            this.Controls.Add(this.dataGridView1);
            this.Name = "perfilUsuario";
            this.Text = "Perfil Socio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuenta;
        private System.Windows.Forms.BindingSource sistemaCooperativaDataSetBindingSource;
        private sistemaCooperativaDataSet sistemaCooperativaDataSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}