﻿using BE;
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
    public partial class CompraComics : RoundedForm
    {
        public CompraComics()
        {
            InitializeComponent();
        }

        ServicioComic oServComics = new ServicioComic();
        List<Comic> comics = new List<Comic>();
        List<dynamic> Portadas = new List<dynamic>();
        int indicesComics;
        int indiceActual;
        List<Comic> ComicsEnCarrito = new List<Comic>();

        private void CompraComics_Load(object sender, EventArgs e)
        {
            comics.Clear();
            comics = oServComics.TraerComics();

            foreach(Comic comic in comics)
            {
                var Portada = new
                {
                    id = comic.ID,
                    Portada = comic.Portada,
                };

                Portadas.Add(Portada);
            }
            CargarComic(comics[0].ID);
            indicesComics = comics.Count;
            indiceActual = 0;
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

        private void btnProxImagen_Click(object sender, EventArgs e)
        {
            if (indiceActual == comics.Count-1)
            {
                return;

            }

            indiceActual++;
            
            CargarComic(comics[indiceActual].ID);
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            if(indiceActual == 0)
            {
                return;
            }

            indiceActual--;
            CargarComic(comics[indiceActual].ID);

        }

        private void CargarComic(int id)
        {
           
            Comic comic = comics.Find(x => x.ID == id);
            PortadaComic.Image = Image.FromStream(oServComics.ByteToImage(comic.Portada));

            txtTitulo.Text = comic.Titulo;
            txtDescripcion.Text = comic.Descripcion;
            txtPrecio.Text = comic.Precio.ToString();
            txtStock.Text = comic.Stock.ToString();

           
        }

        private void btnCarritoCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            var comic = comics[indiceActual];
            ComicsEnCarrito.Add(comic);
            CantComicsCarrito.Text = ComicsEnCarrito.Count.ToString();
            CantComicsCarrito.Visible = true;
            btnCarrito.Visible = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
