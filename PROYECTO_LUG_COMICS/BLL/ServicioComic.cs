using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace BLL
{
    public class ServicioComic
    {
        ComicDal comicDAL = new ComicDal();
        public int InsertarComic(string titulo, string categoria, string editorial, string descripcion, float precio, string portada, int stock)
        {
           
            try
            {
                int resultado = comicDAL.InsertarComic( titulo,  categoria,  editorial,  descripcion,  precio,  portada,  stock);

                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public int EliminarComic(int id)
        {
            try
            {
                int resultado = comicDAL.EliminarComic(id);
                return resultado;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditarComic (int id, string titulo, string categoria, string editorial, string descripcion, float precio, string portada, int stock)
        {
            try
            {
                
                int resultado = comicDAL.EditarComic( id,  titulo,  categoria,  editorial,  descripcion,  precio,  portada,  stock);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditarStock(int id, int stock)
        {
            try
            {
                int resultado = comicDAL.EditarStock(id, stock);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Comic> TraerComics(string id = null)
        {
            try
            {  
               return comicDAL.TraerComics(id);
            }
            catch (Exception)
            {
                return new List<Comic>();
            }

        }

        public string ImageToBase64(string imagePath)
        {
            try
            {
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;

            }
            catch (Exception)
            {
                return string.Empty;
            }

        }

        public string BDImgToBase64(byte[] img)
        {
            try
            {
                string base64String = Convert.ToBase64String(img);
                return base64String;

            }
            catch (Exception)
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

      
    }
}
