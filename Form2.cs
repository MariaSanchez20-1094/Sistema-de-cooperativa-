﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        // BOTÓN CERRAR APP
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logIn FormLogIn = new logIn();
            FormLogIn.Show();
            this.Hide();
        }

        private void btnGestionSocios_Click(object sender, EventArgs e)
        {
            gestionSocios gsForm = new gestionSocios();
            gsForm.Show();
            this.Hide();
        }
    }
}
