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

namespace ProyectoLugComics.Forms
{
    public partial class frmCarritoCompra : RoundedForm
    {
        public frmCarritoCompra(List<Comic> comics)
        {
            MessageBox.Show(comics[0].Titulo);
            InitializeComponent();
        }

        private void frmCarritoCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
