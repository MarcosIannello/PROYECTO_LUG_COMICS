using BE;
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

namespace ProyectoLugComics.Forms
{
    public partial class frmCarritoCompra : RoundedForm
    {
        List<Comic> lcomics = new List<Comic>();
        List<dynamic> resumenPago = new List<dynamic>();
        ServicioUsuarioLogueado oServUL = new ServicioUsuarioLogueado();
        UsuarioLogueado user = new UsuarioLogueado();
        public frmCarritoCompra(List<Comic> comicsCarrito)
        {
            lcomics = comicsCarrito;
           
            InitializeComponent();
        }

        private void frmCarritoCompra_Load(object sender, EventArgs e)
        {
            GridItemsCarrito.DataSource = null;
            GridItemsCarrito.DataSource = lcomics;

            txtCantArticulos.Text = lcomics.Count.ToString();
            txtTotalAPagar.Text = lcomics.Sum(x => x.Precio).ToString();
            user = oServUL.TraerUsuarioLogueado();
            txtUserLogueadoName.Text = $"User: {user.NombreUsuario}";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach(Comic c in lcomics)
            {
                dynamic resumen = new
                {
                    c.ID,
                    c.Titulo,
                    Precio = Convert.ToInt32(c.Precio)
                };
                resumenPago.Add(resumen);
            }

            frmPagoFinal pago = new frmPagoFinal(resumenPago,lcomics);
            pago.Show();
            this.Close();

        }

        Comic temp;
        private void GridItemsCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = (Comic)GridItemsCarrito.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show($"Desea eliminar el comic {temp.Titulo} del carrito?","Eliminar Articulo",MessageBoxButtons.OKCancel);

            if(resultado == DialogResult.OK) 
            {
                lcomics.Remove(temp);
                GridItemsCarrito.DataSource = null;
                GridItemsCarrito.DataSource = lcomics;
                txtCantArticulos.Text = lcomics.Count.ToString();
                txtTotalAPagar.Text = lcomics.Sum(x => x.Precio).ToString();
            }
            else
            {
                return;
            }
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
