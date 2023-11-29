using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MetroSet_UI.Forms;
using ProyectoLugComics.Forms;
using BE;
using System.Web.UI.WebControls;
using ProyectoLugComics.UserControls;

namespace ProyectoLugComics
{
    public partial class frmHome : RoundedForm
    {
        public frmHome()
        {
            InitializeComponent();
            ucLogout1.CerrarSesionClick += ucLogout1_CerrarSesionClick;
        }
        ServicioUsuarioLogueado sUsuarioLogueado = new ServicioUsuarioLogueado();
        UsuarioLogueado user = new UsuarioLogueado();
        ServicioPagos oServPagos = new ServicioPagos();

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            user = sUsuarioLogueado.TraerUsuarioLogueado();
            //txtUserLogueadoName.Text = $"User: {user.NombreUsuario}";

            if(user.IdPermiso == 1)
            {
                AdminView();
            }
            else
            {
                userView();
            }

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
            sUsuarioLogueado.EliminarUsuarioLogueado();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void btnCloseLogin_Click_1(object sender, EventArgs e)
        {
            sUsuarioLogueado.EliminarUsuarioLogueado();
            Application.Exit();
        }

        private void guna2TileButton1_MouseHover(object sender, EventArgs e)
        {
            //sidebar.Show();
        }

        private void guna2TileButton1_MouseLeave(object sender, EventArgs e)
        {
            //sidebar.Hide();
        }

        private void sidebar_MouseHover(object sender, EventArgs e)
        {
            //sidebar.Show();

        }

        private void sidebar_MouseLeave(object sender, EventArgs e)
        {

            //sidebar.Hide();
        }

        private void btnMostrarComics_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();
            this.Hide();
            frmAlta.Show();
        }

        private void BtnComprarComics_Click(object sender, EventArgs e)
        {
            CompraComics compraComics = new CompraComics();
            this.Hide();
            compraComics.Show();
        }

        public void AdminView()
        {
            btnMostrarComics.Visible = true;
            gridUltimosMovimientos.DataSource = null;
            List<dynamic> lpagos = oServPagos.traerPagos();
            gridUltimosMovimientos.DataSource = lpagos;
        }
        

        public void userView()
        {
            btnMostrarComics.Visible = false;
            gridUltimosMovimientos.DataSource = null;
            gridUltimosMovimientos.DataSource = oServPagos.traerPagos(user.ID.ToString());

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucHome_1_Load(object sender, EventArgs e)
        {
            user = sUsuarioLogueado.TraerUsuarioLogueado();
            ucHome_1.SetUserControl(user);
        }

        private void ucLogout1_CerrarSesionClick(object sender, EventArgs e)
        {
            this.Hide();
            sUsuarioLogueado.EliminarUsuarioLogueado();
            Login login = new Login();
            login.Show();
        }

        

        private void btnGenerarXML_Click(object sender, EventArgs e)
        {
            try
            {
                List<dynamic> lpagos = oServPagos.traerPagos();
                DataTable odt = ConvertirListaADT(lpagos);
                
                if (odt != null)
                {
                    DataSet ds = new DataSet();
                    ds.Tables.Add(odt);
                    string directorio = AppDomain.CurrentDomain.BaseDirectory;
                    string rutaXML = Path.Combine(directorio, "XML");
                    ds.WriteXml(rutaXML);
                    MessageBox.Show("XML generado con exito!");
                    Console.WriteLine($"La ruta es: {rutaXML}");
                }
                else
                {
                    MessageBox.Show("No hay datos para generar el XML");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar XML: {ex}");
                Console.WriteLine(ex);
            }
            
        }

        private DataTable ConvertirListaADT(List<dynamic> lista)
        {
            DataTable dt = new DataTable();

            try
            {
                if (lista.Count > 0)
                {
                    foreach (var item in lista[0].GetType().GetProperties())
                    {
                        dt.Columns.Add(item.Name);
                    }

                    foreach (var item in lista)
                    {
                        DataRow row = dt.NewRow();
                        foreach (var item2 in item.GetType().GetProperties())
                        {
                            row[item2.Name] = item2.GetValue(item, null);
                        }
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    dt = null;
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir lista a DataTable: {ex}");
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
