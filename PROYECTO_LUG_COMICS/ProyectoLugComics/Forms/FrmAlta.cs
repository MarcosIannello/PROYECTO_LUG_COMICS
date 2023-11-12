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
            //string path = pbPortada.Image;
            string base64 = ToBase64(pbPortada.Image);


            string titulo = txtTitulo.Text;
            string categoria = txtCategoria.Text;
            string editorial = txtEditorial.Text;
            string descripcion = txtDescripcion.Text;
            float precio = float.Parse(txtPrecio.Text);
            string portada = base64;
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
            
            //foreach (Comic comic in lista)
            //{
            //    listaPortadas.Add(comic.Portada);
            //    comic.Portada = null;
            //}
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
<<<<<<< HEAD
            pbPortada.Image = FromBase64(aux.Portada);     
=======

            pbPortada.Image = Image.FromStream(ByteToImage(aux.Portada));
            

>>>>>>> ddf650733b5386620d4cc9cb12ba42d9eacfaf08
        }

        Image FromBase64(string base64)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir de Base64 a imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        string ToBase64(System.Drawing.Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    try
                    {
                        // Clonar la imagen para evitar conflictos de uso
                        using (Image clonedImage = (Image)image.Clone())
                        {
                            // Liberar recursos de la imagen original
                            image.Dispose();

                            // Guardar el clon en el MemoryStream
                            clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción
                        MessageBox.Show($"Error al salvar la imagen clonada: {ex.Message}");
                    }

                    byte[] imageBytes = ms.GetBuffer().ToArray();
                    return Convert.ToBase64String(imageBytes);
                }
            }
            else
            {
                return string.Empty;
            }
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
            int id = int.Parse(txtID.Text);
            string titulo = txtTitulo.Text;
            string categoria = txtCategoria.Text;
            string editorial = txtEditorial.Text;
            string descripcion = txtDescripcion.Text;
            float precio = float.Parse(txtPrecio.Text);
            string portada = ToBase64(pbPortada.Image);
            int stock = int.Parse(txtStock.Text);

            int resultado = oServicioComics.EditarComic(id, titulo, categoria, editorial, descripcion, precio, portada, stock);
            if (resultado == 1)
            {
                MessageBox.Show("comic modificado con exito");
                CargarDataGrid();
            }
            else
            {
                MessageBox.Show("error al modificar comic");
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
