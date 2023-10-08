using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace ProyectoLugComics
{
    public partial class frmHome : RoundedForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void btnCloseLogin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton1_MouseHover(object sender, EventArgs e)
        {
            //sidebar.Show();
        }

        private void guna2TileButton1_MouseLeave(object sender, EventArgs e)
        {
            //sidebar.Hide();
        }

        private void sidebar_MouseHover(object sender, EventArgs e)
        {
            //sidebar.Show();

        }

        private void sidebar_MouseLeave(object sender, EventArgs e)
        {

            //sidebar.Hide();
        }
    }
}
