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

        private void InicioSocios_Load(object sender, EventArgs e)
        {

        }

        // BOTÓN CERRAR APP
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            logIn FormLogIn = new logIn();
            FormLogIn.Show();
            this.Hide();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            perfilUsuario FpU = new perfilUsuario();
            FpU.Show();
            this.Hide();
        }
    }
}
