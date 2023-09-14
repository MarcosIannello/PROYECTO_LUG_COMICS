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
using BLL;
using MetroSet_UI.Forms;

namespace ProyectoLugComics
{
    public partial class Login : RoundedForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == ".")
            {
                frmHome home = new frmHome();
                this.Hide();
                home.Show();
                return;
            }
            else
            {
                ServicioUsuarios sUsuarios = new ServicioUsuarios();

                string userName = txtUsername.Text;
                string password = txtPassword.Text;
                bool resultado = Convert.ToBoolean(sUsuarios.ValidarUsuario(userName, password));

                if (resultado)
                {
                    MessageBox.Show($"Bienvenido al sistema {userName}");
                    frmHome Home = new frmHome();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña invalidas!");
                }
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse frmRegistrarse = new frmRegistrarse();
            this.Hide();
            frmRegistrarse.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
