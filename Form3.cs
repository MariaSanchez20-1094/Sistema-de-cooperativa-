using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace COOPERATIVAahcr
{
    public partial class InicioSocios : Form
    {
        public InicioSocios()
        {
            InitializeComponent();
        }

        //TRAEMOS LA VARIABLE CONTRASEÑA DEL LOG IN
        string ps = logIn.contrasena;


        private void InicioSocios_Load(object sender, EventArgs e)
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
                command.Parameters.AddWithValue("@pss", ps);

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

        // SE TRAE LA VARIABLE CONTRASENA DEL INICIO DE SESIÓN
        string password = logIn.contrasena;

        // BOTÓN CERRAR APP
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // BOTÓN VUELVE AL LOG IN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            logIn FormLogIn = new logIn();
            FormLogIn.Show();
            this.Hide();
        }

        // BOTÓN PERFIL USUARIOS
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            perfilUsuario FpU = new perfilUsuario();
            FpU.Show();
            this.Hide();
        }

        private void cbConfiguracion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void socioLogeado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
