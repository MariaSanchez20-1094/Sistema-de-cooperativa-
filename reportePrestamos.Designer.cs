
namespace COOPERATIVAahcr
{
    partial class reportePrestamos
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
            this.reportPrestamos = new System.Windows.Forms.DataGridView();
            this.imprimirReporte = new System.Windows.Forms.Button();
            this.volverAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // laberDS
            // 
            this.laberDS.AutoSize = true;
            this.laberDS.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberDS.Location = new System.Drawing.Point(12, 9);
            this.laberDS.Name = "laberDS";
            this.laberDS.Size = new System.Drawing.Size(486, 30);
            this.laberDS.TabIndex = 15;
            this.laberDS.Text = "REPORTE: PRESTAMOS ACTIVOS";
            // 
            // reportPrestamos
            // 
            this.reportPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reportPrestamos.ColumnHeadersHeight = 29;
            this.reportPrestamos.Location = new System.Drawing.Point(17, 42);
            this.reportPrestamos.Name = "reportPrestamos";
            this.reportPrestamos.ReadOnly = true;
            this.reportPrestamos.RowHeadersWidth = 51;
            this.reportPrestamos.RowTemplate.Height = 24;
            this.reportPrestamos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.reportPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportPrestamos.Size = new System.Drawing.Size(626, 261);
            this.reportPrestamos.TabIndex = 14;
            // 
            // imprimirReporte
            // 
            this.imprimirReporte.Location = new System.Drawing.Point(665, 42);
            this.imprimirReporte.Name = "imprimirReporte";
            this.imprimirReporte.Size = new System.Drawing.Size(107, 66);
            this.imprimirReporte.TabIndex = 13;
            this.imprimirReporte.Text = "IMPRIMIR REPORTE";
            this.imprimirReporte.UseVisualStyleBackColor = true;
            this.imprimirReporte.Click += new System.EventHandler(this.imprimirReporte_Click);
            // 
            // volverAtras
            // 
            this.volverAtras.Location = new System.Drawing.Point(665, 231);
            this.volverAtras.Name = "volverAtras";
            this.volverAtras.Size = new System.Drawing.Size(107, 72);
            this.volverAtras.TabIndex = 12;
            this.volverAtras.Text = "VOLVER ATRÁS";
            this.volverAtras.UseVisualStyleBackColor = true;
            this.volverAtras.Click += new System.EventHandler(this.volverAtras_Click);
            // 
            // reportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 322);
            this.Controls.Add(this.laberDS);
            this.Controls.Add(this.reportPrestamos);
            this.Controls.Add(this.imprimirReporte);
            this.Controls.Add(this.volverAtras);
            this.Name = "reportePrestamos";
            this.Text = "FORMULARIO REPORTES - PRESTAMOS ACTIVOS";
            this.Load += new System.EventHandler(this.reportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laberDS;
        private System.Windows.Forms.DataGridView reportPrestamos;
        private System.Windows.Forms.Button imprimirReporte;
        private System.Windows.Forms.Button volverAtras;
    }
}