using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisCoperativa
{
    public partial class Form1 : Form
    {
     

        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-C59873U;Initial Catalog=LoginDB;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtiene el usuario y la contraseña ingresados por el usuario
            string usuario = txtNombreUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Define la cadena de conexión a la base de datos
            string connectionString = @"Data Source=DESKTOP-C59873U;Initial Catalog=sistemaCooperativa;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();
                    // Define la consulta SQL para verificar el usuario y la contraseña
                    string query = "SELECT COUNT(*) FROM USUARIOS WHERE nombre_Usuario = @txtNombreUsuario.Text AND contraseña = @txtContraseña.Text";

                    // Crea una instancia de SqlCommand y asigna los parámetros de la consulta
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@txtNombreUsuario.Text", usuario);
                        command.Parameters.AddWithValue("@txtContraseña.Text", contrasena);

                        // Ejecuta la consulta y obtiene el número de filas afectadas
                        int result = (int)command.ExecuteScalar();

                        if (result > 0)
                        {
                            // Si el usuario y la contraseña son válidos, abre el formulario inicio
                            Form2 FrmPrincipal = new Form2();
                            FrmPrincipal.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Si el usuario y la contraseña son inválidos, mensaje error
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {

                }


        }

        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
          
           if (chkMostrarContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true; 
            }
        }
    }
}

