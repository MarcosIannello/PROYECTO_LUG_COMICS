using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLugComics
{
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }

        private void frmRegistrarse_FormClosed(object sender, FormClosedEventArgs e)
        {
            volverAlLogin();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            string username = txtUsernameRegis.Text;
            string password = txtPasswordRegis.Text;

            ServicioUsuarios sUsuarios = new ServicioUsuarios();

            int resultado = sUsuarios.RegistrarUsuario(username, password);

            if(resultado == 1)
            {
                MessageBox.Show("Usuario registrado correctamente");
                ResetFields();
                volverAlLogin();
            }
            else
            {
                MessageBox.Show("Ocurrio un Problema al registrar el usuario");
                ResetFields();
                volverAlLogin();
            }
        }

        public void ResetFields()
        {
            txtUsernameRegis.Clear();
            txtPasswordRegis.Clear();
        }

        public void volverAlLogin()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
