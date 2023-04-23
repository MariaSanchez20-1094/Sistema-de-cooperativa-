using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisCoperativa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            cmbProductos.Items.Add("Cuentas de Ahorro");
            cmbProductos.Items.Add("Préstamos");

            cmbReportes.Items.Add("Admins");
            cmbReportes.Items.Add("Usuarios");
            cmbReportes.Items.Add("Prestamos");
            cmbReportes.Items.Add("Certificados");


            cmbConfiguracion.Items.Add("Configuración del Sistema");




        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbProductos.SelectedItem.ToString();

            // Verificar la opción seleccionada y abrir el formulario correspondiente
            if (opcionSeleccionada == "Cuentas de Ahorro")
            {
                FormCuentasAhorro formCuentasAhorro = new FormCuentasAhorro();
                formCuentasAhorro.ShowDialog();
            }
            else if (opcionSeleccionada == "Préstamos")
            {
                FormPrestamos formPrestamos = new FormPrestamos();
                formPrestamos.ShowDialog();
            }
        }

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbReportes.SelectedItem.ToString();

            // Verificar la opción seleccionada y abrir el formulario correspondiente
            if (opcionSeleccionada == "Admins")
            {
                FormReporteAdmins formAdmins = new FormReporteAdmins();
                formAdmins.ShowDialog();
            }
            else if (opcionSeleccionada == "Usuarios")
            {
                FormReporteUsuarios formUsuarios = new FormReporteUsuarios();
                formUsuarios.ShowDialog();
            }
            else if (opcionSeleccionada == "Prestamos")
            {
                FormReportePrestamos formReportePrestamos = new FormReportePrestamos();
                formReportePrestamos.ShowDialog();
            }
            else if (opcionSeleccionada == "Certificados")
            {
                FormReporteCertificados formCertificados = new FormReporteCertificados();
                formCertificados.ShowDialog();
            }
        }

        private void cmbConfiguracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcionSeleccionada = cmbConfiguracion.SelectedItem.ToString();

            // Verificar la opción seleccionada y abrir el formulario correspondiente
            if (opcionSeleccionada == "Configuración del Sistema")
            {
                FormConfiguracion formConfiguracion = new FormConfiguracion();
                formConfiguracion.ShowDialog();
            }
        }

      

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
        }
    }
}
