
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaCooperativaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaCooperativaDataSet = new COOPERATIVAahcr.sistemaCooperativaDataSet();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bVolverAtras = new System.Windows.Forms.Button();
            this.imprimirPerfil = new System.Windows.Forms.Button();
            this.laberDS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgUsuarios.Location = new System.Drawing.Point(12, 45);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(434, 469);
            this.dgUsuarios.TabIndex = 1;
            this.dgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "DATOS";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "USUARIO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // sistemaCooperativaDataSetBindingSource
            // 
            this.sistemaCooperativaDataSetBindingSource.DataSource = this.sistemaCooperativaDataSet;
            this.sistemaCooperativaDataSetBindingSource.Position = 0;
            // 
            // sistemaCooperativaDataSet
            // 
            this.sistemaCooperativaDataSet.DataSetName = "sistemaCooperativaDataSet";
            this.sistemaCooperativaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // bVolverAtras
            // 
            this.bVolverAtras.Location = new System.Drawing.Point(458, 457);
            this.bVolverAtras.Name = "bVolverAtras";
            this.bVolverAtras.Size = new System.Drawing.Size(91, 57);
            this.bVolverAtras.TabIndex = 2;
            this.bVolverAtras.Text = "VOLVER ATRÁS";
            this.bVolverAtras.UseVisualStyleBackColor = true;
            this.bVolverAtras.Click += new System.EventHandler(this.bVolverAtras_Click);
            // 
            // imprimirPerfil
            // 
            this.imprimirPerfil.Location = new System.Drawing.Point(458, 45);
            this.imprimirPerfil.Name = "imprimirPerfil";
            this.imprimirPerfil.Size = new System.Drawing.Size(108, 54);
            this.imprimirPerfil.TabIndex = 3;
            this.imprimirPerfil.Text = "IMPRIMIR DATOS .PDF";
            this.imprimirPerfil.UseVisualStyleBackColor = true;
            this.imprimirPerfil.Click += new System.EventHandler(this.imprimirPerfil_Click);
            // 
            // laberDS
            // 
            this.laberDS.AutoSize = true;
            this.laberDS.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberDS.Location = new System.Drawing.Point(12, 12);
            this.laberDS.Name = "laberDS";
            this.laberDS.Size = new System.Drawing.Size(456, 24);
            this.laberDS.TabIndex = 6;
            this.laberDS.Text = "PERFIL DE DATOS USUARIO LOGEADO";
            this.laberDS.Click += new System.EventHandler(this.label1_Click);
            // 
            // perfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 527);
            this.Controls.Add(this.laberDS);
            this.Controls.Add(this.imprimirPerfil);
            this.Controls.Add(this.bVolverAtras);
            this.Controls.Add(this.dgUsuarios);
            this.Name = "perfilUsuario";
            this.Text = "Perfil Socio";
            this.Load += new System.EventHandler(this.perfilUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaCooperativaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.BindingSource sistemaCooperativaDataSetBindingSource;
        private sistemaCooperativaDataSet sistemaCooperativaDataSet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button bVolverAtras;
        private System.Windows.Forms.Button imprimirPerfil;
        private System.Windows.Forms.Label laberDS;
    }
}