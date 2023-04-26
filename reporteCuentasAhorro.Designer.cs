
namespace COOPERATIVAahcr
{
    partial class reporteCuentasAhorro
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
            this.laberDS = new System.Windows.Forms.Label();
            this.reporteuUsersAdmin = new System.Windows.Forms.DataGridView();
            this.imprimirReporte = new System.Windows.Forms.Button();
            this.volverAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reporteuUsersAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // laberDS
            // 
            this.laberDS.AccessibleDescription = "reporteCuentaAhorro";
            this.laberDS.AutoSize = true;
            this.laberDS.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberDS.Location = new System.Drawing.Point(12, 9);
            this.laberDS.Name = "laberDS";
            this.laberDS.Size = new System.Drawing.Size(575, 30);
            this.laberDS.TabIndex = 11;
            this.laberDS.Text = "REPORTE: CUENTAS AHORRO ACTIVAS";
            // 
            // reporteuUsersAdmin
            // 
            this.reporteuUsersAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reporteuUsersAdmin.ColumnHeadersHeight = 29;
            this.reporteuUsersAdmin.Location = new System.Drawing.Point(17, 42);
            this.reporteuUsersAdmin.Name = "reporteuUsersAdmin";
            this.reporteuUsersAdmin.ReadOnly = true;
            this.reporteuUsersAdmin.RowHeadersWidth = 51;
            this.reporteuUsersAdmin.RowTemplate.Height = 24;
            this.reporteuUsersAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.reporteuUsersAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reporteuUsersAdmin.Size = new System.Drawing.Size(626, 261);
            this.reporteuUsersAdmin.TabIndex = 10;
            this.reporteuUsersAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reporteuUsersAdmin_CellContentClick);
            // 
            // imprimirReporte
            // 
            this.imprimirReporte.Location = new System.Drawing.Point(665, 42);
            this.imprimirReporte.Name = "imprimirReporte";
            this.imprimirReporte.Size = new System.Drawing.Size(107, 66);
            this.imprimirReporte.TabIndex = 9;
            this.imprimirReporte.Text = "IMPRIMIR REPORTE";
            this.imprimirReporte.UseVisualStyleBackColor = true;
            this.imprimirReporte.Click += new System.EventHandler(this.imprimirReporte_Click);
            // 
            // volverAtras
            // 
            this.volverAtras.Location = new System.Drawing.Point(665, 231);
            this.volverAtras.Name = "volverAtras";
            this.volverAtras.Size = new System.Drawing.Size(107, 72);
            this.volverAtras.TabIndex = 8;
            this.volverAtras.Text = "VOLVER ATRÁS";
            this.volverAtras.UseVisualStyleBackColor = true;
            this.volverAtras.Click += new System.EventHandler(this.volverAtras_Click);
            // 
            // reporteCuentasAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 333);
            this.Controls.Add(this.laberDS);
            this.Controls.Add(this.reporteuUsersAdmin);
            this.Controls.Add(this.imprimirReporte);
            this.Controls.Add(this.volverAtras);
            this.Name = "reporteCuentasAhorro";
            this.Text = "FORMULARIO REPORTES - CUENTAS DE AHORRO";
            this.Load += new System.EventHandler(this.reporteCuentasAhorro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteuUsersAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laberDS;
        private System.Windows.Forms.DataGridView reporteuUsersAdmin;
        private System.Windows.Forms.Button imprimirReporte;
        private System.Windows.Forms.Button volverAtras;
    }
}