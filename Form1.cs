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

namespace COOPERATIVAahcr
{
    public partial class logIn : Form
    {
        
    // SE DECLARA LA CONTRASEÑA INGRESADA COMO PUBLICA PARA SER ACCEDIDA 
    public static string contrasena;

    public logIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtiene el usuario y la contraseña ingresados por el usuario
            string usuario = user.Text;
            contrasena = contraseña.Text;

            // Define la cadena de conexión a la base de datos
            string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    // Abre la conexión a la base de datos
                    connection.Open();
                    // Define la consulta SQL para verificar el usuario y la contraseña ADMIN
                    string queryAdmin = "SELECT COUNT(*) FROM USUARIOS WHERE nombre_Usuario = @user AND contraseña = @contraseña AND rolUsuario = 'admin'";

                    // Define la consulta SQL para verificar el usuario y la contraseña SOCIO
                    string querySocios = "SELECT COUNT(*) FROM USUARIOS WHERE nombre_Usuario = @user AND contraseña = @contraseña AND rolUsuario = 'socio'";


                    // Crea una instancia de SqlCommand y asigna los parámetros de la consulta
                    using (SqlCommand commandA = new SqlCommand(queryAdmin, connection))
                    using (SqlCommand commandS = new SqlCommand(querySocios, connection))

                    {   // APLICA ALIAS A USUARIO Y CONTRASEÑA
                        commandA.Parameters.AddWithValue("@user", usuario);
                        commandA.Parameters.AddWithValue("@contraseña", contrasena);

                        commandS.Parameters.AddWithValue("@user", usuario);
                        commandS.Parameters.AddWithValue("@contraseña", contrasena);

                        // Ejecuta la consulta y obtiene el número de filas afectadas
                        int admin = (int)commandA.ExecuteScalar();
                        int socios = (int)commandS.ExecuteScalar();

                        // SI ESTÁN VACIOS LOS TEXT BOX SALTA MENSAJE ERROR, RELLENAR
                        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
                        {
                            MessageBox.Show("Por favor, ingrese un nombre de usuario y una contraseña", "Error inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // SI APARECEN SOCIOS PERO NO ADMIN ENTRA AL FORMULARIO DE SOCIOS
                        if (socios > 0 && admin == 0)
                        {
                            // SI EL USUARIO ES ADMIN, ABRE FORM 1 SOCIOS
                            InicioSocios FrmSocios = new InicioSocios();
                            FrmSocios.Show();
                            this.Hide();
                        }
                        // SI APARECEN ADMIN PERO NO SOCIOS ENTRA AL FORMULARIO DE ADMINS
                        if (admin > 0 && socios == 0)
                        {
                            // SI EL USUARIO ES ADMIN, ABRE FORM 2 ADMINISTRADORES
                            FormPrincipal FrmPrincipal = new FormPrincipal();
                            FrmPrincipal.Show();
                            this.Hide();
                        }
                        // SI NO APARECEN NINGUNOS, SALTA MENSAJE ERROR RELLENAR
                        if (socios == 0 && admin == 0)
                        {
                            // Si el usuario y la contraseña son inválidos, mensaje error
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } // ATRAPA LA EXCEPCIÓN Y NO DEJA CERRAR EL PROGRAMA
                catch (Exception ex)
                {

                }
        
    }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            // MEDIANTE ESTAS CONDICIONES SE ESTABLECE LA CONTRASEÑA OCULTA MIENTRAS NO SEA TRUE EL CHECKBOX
            if (mostrarContraseña.Checked)
            {
                contraseña.PasswordChar = '\0'; // Carácter nulo
            }
            else
            {
                contraseña.PasswordChar = '*'; // Carácter oculto (punto)
            }
        }


    }

    }

