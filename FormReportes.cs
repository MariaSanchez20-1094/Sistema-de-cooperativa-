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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            // Agrega las opciones de reporte al ComboBox
            cmbOpcionesReporte.Items.Add("Usuarios");
            cmbOpcionesReporte.Items.Add("Admins");
            cmbOpcionesReporte.Items.Add("Préstamos");
            cmbOpcionesReporte.Items.Add("Certificados");
        }

        private void cmbOpcionesReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén la opción seleccionada del ComboBox
            string opcionSeleccionada = cmbOpcionesReporte.SelectedItem.ToString();

            Form formularioReporte;
            switch (opcionSeleccionada)
            {
                case "Usuarios":
                    formularioReporte = new FormReporteUsuarios();
                    break;
                case "Admins":
                    formularioReporte = new FormReporteAdmins();
                    break;
                case "Préstamos":
                    formularioReporte = new FormReportePrestamos();
                    break;
                case "Certificados":
                    formularioReporte = new FormReporteCertificados();
                    break;
                default:
                    return; // Sal del evento si no se selecciona una opción válida
            }

            // Muestra el formulario correspondiente al reporte seleccionado
            formularioReporte.Show();
        }
    }
    }

