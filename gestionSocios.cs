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
    public partial class gestionSocios : Form
    {
        public gestionSocios()
        {
            InitializeComponent();

        }


        private void LimpiarFormulario()
        {
            cedula.Text = "";
            logInUser.Text = "";
            apellidoUser.Text = "";
            direccionResidencia.Text = "";
            nombreUser.Text = "";
            contraseñaUser.Text = "";
            correoElectronico.Text = "";
            telefonoMovil.Text = "";

            telResidencia.Text = "";
            ocupacionUsuario.Text = "";
            referencias.Text = "";
            score.Text = "";
            fecha.Text = "";
            rolUser.Text = "";
            statusUser.Text = "";

        }

        private void gestionSocios_Load(object sender, EventArgs e)
        {

            // Crear una conexión a la base de datos
            string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Crear un comando SQL para seleccionar los datos de la tabla usuarios
            string query = "SELECT * FROM USUARIOS";
            SqlCommand command = new SqlCommand(query, connection);

            // Crear un objeto SqlDataAdapter para leer los datos de la base de datos
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Crear un objeto DataTable para almacenar los datos leídos de la base de datos
            DataTable dataTable = new DataTable();

            // Llenar el DataTable con los datos leídos de la base de datos
            adapter.Fill(dataTable);

            // Vincular el DataGridView con el DataTable
            dgGestionSocios.DataSource = dataTable;

            // Cerrar la conexión a la base de datos
            connection.Close();
        }


        private void CargarDatos()
        {
            // Crear una conexión a la base de datos
            string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            // Definir la consulta SQL
            string query = "SELECT * FROM USUARIOS";

            // Crear el objeto SqlCommand y asignar la consulta y la conexión
            SqlCommand cmd = new SqlCommand(query, connection);

            // Abrir la conexión a la base de datos
            connection.Open();

            // Ejecutar la consulta y almacenar los resultados en un objeto SqlDataReader
            SqlDataReader reader = cmd.ExecuteReader();

            // Limpiar los datos del DataGridView
            dgGestionSocios.Rows.Clear();

            // Leer los datos de cada fila y agregarlos al DataGridView
            while (reader.Read())
            {
                string[] row = {
            reader["cedulaUsuario"].ToString(),
            reader["nombreUsuario"].ToString(),
            reader["contraseñaUsuario"].ToString(),
            reader["correoElectrónico"].ToString(),
            reader["direcciónUsuario"].ToString(),
            reader["nmTelefonoMovil"].ToString()
        };
                dgGestionSocios.Rows.Add(row);
            }

            // Cerrar el objeto SqlDataReader y la conexión a la base de datos
            reader.Close();
            connection.Close();
        }

        private void volverAtras_Click(object sender, EventArgs e)
        {
            //  VUELVE A PANTALLA SOCIOS
            FormPrincipal FRM = new FormPrincipal();
            FRM.Show();
            this.Hide();
        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = cedulausuario.Text;
                string nombre = nombreUser.Text;
                string apellido = apellidoUser.Text;
                string contraseña = contraseñaUser.Text;
                string correo = correoElectronico.Text;
                string direccion = direccionResidencia.Text;
                string telefonoMovil = telMovil.Text;
                string telefonoResidencial = telResidencia.Text;
                string ocupacion = ocupacionUsuario.Text;
                string refPersonal = referencias.Text;
                int scoreCrediticio = int.Parse(score.Text);
                string fechaIngreso = fecha.Text;
                string rol = rolUser.Text;
                string status = statusUser.Text;

                // Crear una conexión a la base de datos
                string connectionString = @"Data Source=LAPTOP-JOCDUAG3;Initial Catalog=sistemaCooperativa;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                // HACER QUERY PARA CONFIRMAR SI EN LA BASE DE DATOS YA ESTÁ ESE NUMERO DE CEDULA
                string query = "SELECT COUNT(*) FROM USUARIOS WHERE cedulaUsuario = @cedula";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un usuario con esa cédula", "Error");
                            return;
                        }
                    }
                }

                // Insertar el nuevo usuario en la base de datos
                query = "INSERT INTO USUARIOS VALUES (@cedula, @nombre, @apellido, @contrasena, @correo, @direccion, @telefonoMovil, @telefonoResidencial, @ocupacion, @refPersonal, @scoreCrediticio, @fechaIngreso, @rol, @status, NULL, NULL)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@contrasena", contraseña);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefonoMovil", telefonoMovil);
                        cmd.Parameters.AddWithValue("@telefonoResidencial", telefonoResidencial);
                        cmd.Parameters.AddWithValue("@ocupacion", ocupacion);
                        cmd.Parameters.AddWithValue("@refPersonal", refPersonal);
                        cmd.Parameters.AddWithValue("@scoreCrediticio", scoreCrediticio);
                        cmd.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario agregado correctamente", "Éxito");
                            LimpiarFormulario();
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el usuario", "Error");
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
            }

        private void dgGestionSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

