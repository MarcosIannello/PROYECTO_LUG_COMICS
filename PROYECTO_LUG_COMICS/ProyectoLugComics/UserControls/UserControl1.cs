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
    public partial class ucDetalles : UserControl
    {
        private DataGridView dgv;
        private bool dgvVisible = true;
        public ucDetalles()
        {
            InitializeComponent();
            btnDetalles.Click += BtnDetalles_Click;
        }
        public void setDgv(DataGridView dgv)
        {
            this.dgv = dgv;
            MessageBox.Show("Se seteo el dgv");
        }
        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgv != null)
            {
                dgv.Visible = !dgvVisible;
                dgvVisible = !dgvVisible;

                if (dgvVisible)
                    btnDetalles.Text = "Ocultar Detalle";
                else
                    btnDetalles.Text = "Mostrar Detalle";
            }
        }
    }
}
