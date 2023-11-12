using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Comic
    {


        private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

        private string categoria;
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string editorial;

		public string Editorial
		{
			get { return editorial; }
			set { editorial = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}
		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private string portada;

		public string Portada
		{
			get { return portada; }
			set { portada = value; }
		}

		private int stock;

		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}


		




	}
}
