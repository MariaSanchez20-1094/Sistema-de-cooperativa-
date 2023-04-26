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
    public partial class perfilUsuario : Form
    {
        public perfilUsuario()
        {
            InitializeComponent();
        }

        string password = logIn.contrasena;


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void perfilUsuario_Load(object sender, EventArgs e)
        {
            // Define la cadena de conexión a la base de datos, conexion string e instancia conexion
            string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // QUERY QUE SE PASARÁ A LA BASE DE DATOS CON LA INSTANCIA PARAMETRIZADO
                string queryString = "SELECT * FROM USUARIOS WHERE contraseña = @pss";

                // CREAR LA INSTANCIAS COMMAND
                SqlCommand command = new SqlCommand(queryString, connection);

                // PARAMETRIZANDO EL QUERY
                command.Parameters.AddWithValue("@pss", password);

                // Abrir la conexión
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string cedulaUsuario = reader.GetString(0);
                        string nombreUsuario = reader.GetString(1);
                        string nombre_Usuario = reader.GetString(2);
                        string apellidoUsuario = reader.GetString(3);
                        string contraseña = reader.GetString(4);
                        string correoElectronico = reader.GetString(5);
                        string direcciónUsuario = reader.GetString(6);
                        string nmTelefonoMovil = reader.GetString(7);
                        string nmTeléfonoResidencial = reader.GetString(8);
                        string statusUsuario = reader.GetString(9);
                        string opcupacionUsuario = reader.GetString(10);
                        string refPersonal = reader.GetString(11);
                        int scoreCrediticio = reader.GetInt32(12);
                        string fechaIngreso = reader.GetString(13);
                        string rolUsuario = reader.GetString(14);
                       

                        dgUsuarios.AutoGenerateColumns = false;

                        // AGREGAR FILAS
                        dgUsuarios.Rows.Add("CÉDULA: ", cedulaUsuario);
                        dgUsuarios.Rows.Add("NOMBRES: ", nombreUsuario);
                        dgUsuarios.Rows.Add("NOMBRE USUARIO: ", nombre_Usuario);
                        dgUsuarios.Rows.Add("APELLIDO USUARIO: ", apellidoUsuario);
                        dgUsuarios.Rows.Add("CONTRASEÑA: ", contraseña);
                        dgUsuarios.Rows.Add("CORREO ELECTRÓNICO: ", correoElectronico);
                        dgUsuarios.Rows.Add("DIRECCIÓN RESIDENCIA: ", direcciónUsuario);
                        dgUsuarios.Rows.Add("NÚMERO DE TELÉFONO (MÓVIL): ", nmTelefonoMovil); 
                        dgUsuarios.Rows.Add("NÚMERO DE TELÉFONO RESIDENCIAL: ",nmTeléfonoResidencial);
                        dgUsuarios.Rows.Add("OCUPACIÓN USUARIO: ", opcupacionUsuario);
                        dgUsuarios.Rows.Add("REFERENCIAS PERSONALES: ", refPersonal);
                        dgUsuarios.Rows.Add("SCORE CREDITICIO (CHANCES PREDICTIVOS): ", scoreCrediticio);
                        dgUsuarios.Rows.Add("FECHA INGRESO: ", fechaIngreso);
                        dgUsuarios.Rows.Add("ROL USUARIO: ", rolUsuario);              
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron resultados.");
                }
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si hay un problema con la conexión o la consulta
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bVolverAtras_Click(object sender, EventArgs e)
        {
            //  VUELVE A PANTALLA SOCIOS
            InicioSocios FrmSocios = new InicioSocios();
            FrmSocios.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void imprimirPerfil_Click(object sender, EventArgs e)
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
                PdfPTable table = new PdfPTable(dgUsuarios.Columns.Count);

                // Agregar las cabeceras de las columnas al PDF
                for (int i = 0; i < dgUsuarios.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgUsuarios.Columns[i].HeaderText));
                }

                // Agregar las filas de datos al PDF
                for (int i = 0; i < dgUsuarios.Rows.Count; i++)
                {
                    for (int j = 0; j < dgUsuarios.Columns.Count; j++)
                    {
                        if (dgUsuarios.Rows[i].Cells[j].Value != null)
                        {
                            table.AddCell(new Phrase(dgUsuarios.Rows[i].Cells[j].Value.ToString()));
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
