
namespace COOPERATIVAahcr
{
    partial class reporteAdministradores
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
            this.volverAtras = new System.Windows.Forms.Button();
            this.imprimirReporte = new System.Windows.Forms.Button();
            this.reporteuUsersAdmin = new System.Windows.Forms.DataGridView();
            this.laberDS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reporteuUsersAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // volverAtras
            // 
            this.volverAtras.Location = new System.Drawing.Point(660, 237);
            this.volverAtras.Name = "volverAtras";
            this.volverAtras.Size = new System.Drawing.Size(107, 72);
            this.volverAtras.TabIndex = 0;
            this.volverAtras.Text = "VOLVER ATRÁS";
            this.volverAtras.UseVisualStyleBackColor = true;
            this.volverAtras.Click += new System.EventHandler(this.volverAtras_Click);
            // 
            // imprimirReporte
            // 
            this.imprimirReporte.Location = new System.Drawing.Point(660, 48);
            this.imprimirReporte.Name = "imprimirReporte";
            this.imprimirReporte.Size = new System.Drawing.Size(107, 66);
            this.imprimirReporte.TabIndex = 1;
            this.imprimirReporte.Text = "IMPRIMIR REPORTE";
            this.imprimirReporte.UseVisualStyleBackColor = true;
            this.imprimirReporte.Click += new System.EventHandler(this.imprimirReporte_Click);
            // 
            // reporteuUsersAdmin
            // 
            this.reporteuUsersAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reporteuUsersAdmin.ColumnHeadersHeight = 29;
            this.reporteuUsersAdmin.Location = new System.Drawing.Point(12, 48);
            this.reporteuUsersAdmin.Name = "reporteuUsersAdmin";
            this.reporteuUsersAdmin.ReadOnly = true;
            this.reporteuUsersAdmin.RowHeadersWidth = 51;
            this.reporteuUsersAdmin.RowTemplate.Height = 24;
            this.reporteuUsersAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.reporteuUsersAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reporteuUsersAdmin.Size = new System.Drawing.Size(626, 261);
            this.reporteuUsersAdmin.TabIndex = 2;
            this.reporteuUsersAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // laberDS
            // 
            this.laberDS.AutoSize = true;
            this.laberDS.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberDS.Location = new System.Drawing.Point(7, 15);
            this.laberDS.Name = "laberDS";
            this.laberDS.Size = new System.Drawing.Size(633, 30);
            this.laberDS.TabIndex = 7;
            this.laberDS.Text = "REPORTE: USUARIOS ROL ADMINISTRADOR";
            this.laberDS.Click += new System.EventHandler(this.laberDS_Click);
            // 
            // reporteAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 332);
            this.Controls.Add(this.laberDS);
            this.Controls.Add(this.reporteuUsersAdmin);
            this.Controls.Add(this.imprimirReporte);
            this.Controls.Add(this.volverAtras);
            this.Name = "reporteAdministradores";
            this.Text = "FORMULARIO REPORTES - USUARIOS ADMINISTRADORES";
            this.Load += new System.EventHandler(this.reporteAdministradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteuUsersAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volverAtras;
        private System.Windows.Forms.Button imprimirReporte;
        private System.Windows.Forms.DataGridView reporteuUsersAdmin;
        private System.Windows.Forms.Label laberDS;
    }
}