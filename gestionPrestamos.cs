﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COOPERATIVAahcr
{
    public partial class frmGestionPrestamos : Form
    {
        public frmGestionPrestamos()
        {
            InitializeComponent();
        }

        private void volverAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal FormLogIn = new FormPrincipal();
            FormLogIn.Show();
            this.Hide();
        }
    }
}
