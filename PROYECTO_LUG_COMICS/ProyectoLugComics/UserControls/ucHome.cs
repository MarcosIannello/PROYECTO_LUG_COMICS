using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLugComics.UserControls
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        public void SetUserControl(UsuarioLogueado user)
        {
            txtUserControl.Text = $"Bienvenido { user.NombreUsuario}";
        }
    }
}
