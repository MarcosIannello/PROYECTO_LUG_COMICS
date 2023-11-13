using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using System.Drawing.Imaging;

namespace ProyectoLugComics.Forms
{
    public partial class FrmAlta : RoundedForm
    {
        public FrmAlta()
        {
            InitializeComponent();
        }
        ServicioComic oServicioComics = new ServicioComic();
        
        private void FrmAlta_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        List<Byte[]> listaPortadas = new List<Byte[]>();

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdCargarImagen = new OpenFileDialog();
            opdCargarImagen.InitialDirectory = "C:\\";
            opdCargarImagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            opdCargarImagen.Title = "Cargar Imagen";
            if (opdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                pbPortada.ImageLocation = opdCargarImagen.FileName;
            }
        }

        private void btnInsertarComic_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string categoria = txtCategoria.Text;
            string editorial = txtEditorial.Text;
            string descripcion = txtDescripcion.Text;
            float precio = float.Parse(txtPrecio.Text);
            string portada = ImageToBase64(pbPortada.ImageLocation);
            int stock = int.Parse(txtStock.Text);

            

            try
            {
                int resultado = oServicioComics.InsertarComic(titulo, categoria, editorial, descripcion, precio, portada, stock);
                if (resultado == 1)
                {
                    MessageBox.Show("Comic insertado con exito");
                    CargarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al insertar comic");
                }
            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message);
            }

            EstadoInicialForm();

        }

        public void CargarDataGrid()
        {
            var lista = oServicioComics.TraerComics();
            
            dgvComics.DataSource = null;
            dgvComics.DataSource = lista;
        }
        

        private void dgvComics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Comic aux;
            aux = (Comic)dgvComics.Rows[e.RowIndex].DataBoundItem;
            txtTitulo.Text = aux.Titulo;
            txtCategoria.Text = aux.Categoria;
            txtEditorial.Text = aux.Editorial;
            txtDescripcion.Text = aux.Descripcion;
            txtPrecio.Text = aux.Precio.ToString();
            txtStock.Text = aux.Stock.ToString();
            txtID.Text = aux.ID.ToString();

            pbPortada.Image = Image.FromStream(ByteToImage(aux.Portada));

        }

       public string ImageToBase64(string imagePath)
        {
            try 
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            
            }catch(Exception)
            {
                return string.Empty;
            }

        }

        public MemoryStream ByteToImage(byte[] img)
        {
            // byte[] img = (byte[])dgvComics.CurrentRow.Cells[6].Value;
            
            MemoryStream ms = new MemoryStream(img);
            return ms;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listaIDs = oServicioComics.TraerComics();
            cbDelete.Items.Clear();
            cbDelete.DataSource = listaIDs;
            cbDelete.DisplayMember = "ID";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string titulo = txtTitulo.Text;
            string categoria = txtCategoria.Text;
            string editorial = txtEditorial.Text;
            string descripcion = txtDescripcion.Text;
            float precio = float.Parse(txtPrecio.Text);
            string portada = ImageToBase64(pbPortada.ImageLocation);

            int stock = int.Parse(txtStock.Text);

            int resultado = oServicioComics.EditarComic(ID, titulo, categoria, editorial, descripcion, precio, portada, stock);
            if (resultado == 1)
            {
                MessageBox.Show("Comic modificado con exito");
                CargarDataGrid();
            }
            else
            {
                MessageBox.Show("Error al modificar comic");
            }

            EstadoInicialForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            try
            {
                int resultado = oServicioComics.EliminarComic(ID);
                if (resultado == 1)
                {
                    MessageBox.Show("Comic eliminado con exito");
                    CargarDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al eliminar comic");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            EstadoInicialForm();

        }


        public void EstadoInicialForm()
        {
            txtTitulo.Text = "";
            txtCategoria.Text = "";
            txtEditorial.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtID.Text = "";
            pbPortada.Image = null;
        }

        private void VolverAlHome()
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EstadoInicialForm();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            VolverAlHome();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
