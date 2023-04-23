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

            string consulta = "SELECT * FROM Usuarios WHERE NombreUsuario=@NombreUsuario AND Contraseña=@Contraseña";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Inicio de sesión exitoso
                    MessageBox.Show("Inicio de sesión exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Credenciales inválidas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                conexion.Close();

             
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

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

