﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLugComics.Forms
{
    public partial class CompraComics : RoundedForm
    {
        public CompraComics()
        {
            InitializeComponent();
        }

        private void CompraComics_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
