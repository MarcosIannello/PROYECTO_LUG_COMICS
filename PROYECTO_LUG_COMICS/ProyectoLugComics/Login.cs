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
    public partial class Login : MetroSetForm
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cn;

        public void Conectar()
        {
            cn = new SqlConnection();

            cn.ConnectionString = "Data Source=.;Initial Catalog=FACULTAD;Integrated Security=True";

            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
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

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse frmRegistrarse = new frmRegistrarse();
            frmRegistrarse.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
