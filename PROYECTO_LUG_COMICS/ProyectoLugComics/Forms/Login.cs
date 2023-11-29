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
using BE;

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
            
            ServicioUsuarios sUsuarios = new ServicioUsuarios();
            ServicioPermisoUsuario sPermisoUsuario = new ServicioPermisoUsuario();
            ServicioUsuarioLogueado sUsuarioLogueado = new ServicioUsuarioLogueado();
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            bool resultado = Convert.ToBoolean(sUsuarios.ValidarUsuario(userName, password));

            if (resultado)
            {   
                List<Usuarios> lUsuarios = sUsuarios.TraerUsuarios();
                var UsuarioLogueado = lUsuarios.Find(x => x.NombreUsuario == userName);
                int PermisoUsuario = sPermisoUsuario.TraerPermisoPorUsuario(UsuarioLogueado.id);
                MessageBox.Show($"Bienvenido al sistema {userName}");
                UsuarioLogueado Usuario = new UsuarioLogueado
                {
                    ID = UsuarioLogueado.id,
                    NombreUsuario = UsuarioLogueado.NombreUsuario,
                    IdPermiso = PermisoUsuario
                };
                sUsuarioLogueado.InsertarUsuarioLogueado(Usuario);
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
