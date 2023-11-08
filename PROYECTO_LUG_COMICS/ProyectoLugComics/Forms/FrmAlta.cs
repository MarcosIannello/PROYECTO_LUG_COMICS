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
    public partial class FrmAlta : Form
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
            byte[] portada = ImageToByte(pbPortada.Image);
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
            
        }

        public void CargarDataGrid()
        {
            var lista = oServicioComics.TraerComics();
            dgvComics.DataSource = null;
            dgvComics.DataSource = lista;
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
         /*   Image img = Image.FromStream(ByteToImage(aux.Portada));
            

            if (aux.Portada != null)
            {   
                pbPortada.Image = Image.FromStream(ByteToImage(aux.Portada));
            }
            else
            {
                pbPortada.Image = null;
            }
         */
        }

        public byte[] ImageToByte(Image imagen)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, ImageFormat.Jpeg);  // Cambiar a un formato compatible si es necesario
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente
                Console.WriteLine("Error al convertir la imagen en bytes: " + ex.Message);
                return new byte[0]; // Devolver un arreglo vacío o null si hay un error
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
            byte[] portada = null;//ImageToByte(pbPortada.Image);
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
        }
    }
}
