using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace COOPERATIVAahcr
{
    public partial class reportePrestamos : Form
    {
        public reportePrestamos()
        {
            InitializeComponent();
        }

        private void reportePrestamos_Load(object sender, EventArgs e)
        {
            try
            {
                // Define la cadena de conexión a la base de datos
                string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                // Define la consulta SQL para verificar el usuario y la contraseña ADMIN
                string queryDatosAdmin = " SELECT * FROM PRESTAMOS WHERE status = 'ac'";

                // Crea una instancia de SqlCommand y asigna los parámetros de la consulta
                SqlCommand commandAdmin = new SqlCommand(queryDatosAdmin, conn);

                // Abre la conexión a la base de datos
                conn.Open();

                // SqlDataReader reader = commandAdmin.ExecuteReader();

                // Crear el adaptador de datos
                SqlDataAdapter da = new SqlDataAdapter(commandAdmin);

                // Crear el objeto DataTable
                DataTable dt = new DataTable();

                // Llenar el DataTable con los datos del comando
                da.Fill(dt);

                // Verificar si hay filas en el DataTable
                if (dt.Rows.Count > 0)
                {
                    // Asignar el DataTable al DataGridView
                    reportPrestamos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados.");
                }

            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si hay un problema con la conexión o la consulta
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void volverAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal FrmSocios = new FormPrincipal();
            FrmSocios.Show();
            this.Hide();
        }

        private void imprimirReporte_Click(object sender, EventArgs e)
        {
            // Crear un objeto SaveFileDialog para permitir al usuario seleccionar la ubicación de guardado del archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Guardar archivo PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crear un objeto Document de iTextSharp
                Document document = new Document();

                // Crear un objeto PdfWriter para escribir en el documento
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                // Abrir el documento
                document.Open();

                // Crear una tabla de iTextSharp con las mismas columnas que el DataGridView
                PdfPTable table = new PdfPTable(reportPrestamos.Columns.Count);

                // Agregar las cabeceras de las columnas al PDF
                for (int i = 0; i < reportPrestamos.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(reportPrestamos.Columns[i].HeaderText));
                }

                // Agregar las filas de datos al PDF
                for (int i = 0; i < reportPrestamos.Rows.Count; i++)
                {
                    for (int j = 0; j < reportPrestamos.Columns.Count; j++)
                    {
                        if (reportPrestamos.Rows[i].Cells[j].Value != null)
                        {
                            table.AddCell(new Phrase(reportPrestamos.Rows[i].Cells[j].Value.ToString()));
                        }
                    }
                }

                // Agregar la tabla al documento
                document.Add(table);

                // Cerrar el documento
                document.Close();

                MessageBox.Show("Archivo guardado exitosamente.");
            }
        }
    }
}
