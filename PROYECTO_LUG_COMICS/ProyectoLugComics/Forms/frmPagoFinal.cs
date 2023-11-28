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
    public partial class frmPagoFinal : RoundedForm
    {
        List<dynamic> resumen = new List<dynamic>();
        List<Comic> comics = new List<Comic>();
        ServicioPagos oServPagos = new ServicioPagos();
        ServicioComic oServComic = new  ServicioComic();
        frmHome home = new frmHome();
        public frmPagoFinal(List<dynamic> lResumenPago, List<Comic> comicsAModificar)
        {
            resumen = lResumenPago; //RESUMEN DE PAGO PARA VISUAL
            comics = comicsAModificar; //PARA BAJAR LA CANTIDAD DE STOCK
            InitializeComponent();
        }

        private void frmPagoFinal_Load(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = resumen.Sum(r => r.Precio).ToString();
            txtCantArticulos.Text = resumen.Count.ToString();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtTotalAPagar.Text = (resumen.Sum(r => r.Precio) + 1000).ToString();

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDebito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void btnPagoFinal_Click(object sender, EventArgs e)
        {
            string domicilio = txtDomicilio.Text;
            string tipoTarjeta = cmbTarjeta.SelectedItem.ToString();
            string numTarjeta = txtNumeroTarjeta.Text;
            int importe = Convert.ToInt32(txtTotalAPagar.Text);
            int resultado = oServPagos.InsertarPago(domicilio,tipoTarjeta,numTarjeta,importe);

            if(resultado == 1)
            {
                MessageBox.Show($"Su Pago de {importe} fue realizado con exito!");
                foreach(Comic c in comics)
                {
                    oServComic.EditarStock(c.ID, c.Stock-1);
                }
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar el pago");
            }
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerde que el pago quedara pendiente hasta que lo realize o cancele!");
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
