using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COOPERATIVAahcr
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // SE TRAE LA VARIABLE CONTRASENA DEL INICIO DE SESIÓN
        string password = logIn.contrasena;


        private void Form2_Load(object sender, EventArgs e)
        {
            // Define la cadena de conexión a la base de datos, conexion string e instancia conexion
            string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // QUERY QUE SE PASARÁ A LA BASE DE DATOS CON LA INSTANCIA PARAMETRIZADO
                string queryString = "SELECT nombreUsuario, apellidoUsuario, cedulaUsuario FROM USUARIOS WHERE contraseña = @pss";

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
                        nombre.Text = reader.GetString(0);
                        apellido.Text = reader.GetString(1);
                        cedula.Text = reader.GetString(2);

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
        // BOTÓN CERRAR APP
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //VUELVE A LOG IN
            logIn FormLogIn = new logIn();
            FormLogIn.Show();
            this.Hide();
        }

        private void btnGestionSocios_Click(object sender, EventArgs e)
        {   // BOTÓN GESTIÓN SOCIOS            
            gestionSocios gsForm = new gestionSocios();
            gsForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}