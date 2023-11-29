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
    public partial class ucLogout : UserControl
    {
        public event EventHandler CerrarSesionClick;
        public ucLogout()
        {
            InitializeComponent();
            btnCerrarSesion.Click += BtnCerrarSesion_Click;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesionClick?.Invoke(this, EventArgs.Empty);
        }
        

        

    }
}
