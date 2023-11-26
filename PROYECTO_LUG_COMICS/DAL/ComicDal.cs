using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ComicDal
    {
        public int InsertarComic(string titulo, string categoria, string editorial, string descripcion, float precio, string portada, int stock)
        {
            ConexionSQL conexionSQL = new ConexionSQL();

            try
            {
                SqlParameter[] parametros = new SqlParameter[8];
                Random rnd = new Random();
                int id = rnd.Next();
                parametros[0] = new SqlParameter("@ID", id);
                parametros[1] = new SqlParameter("@TITULO", titulo);
                parametros[2] = new SqlParameter("@CATEGORIA", categoria);
                parametros[3] = new SqlParameter("@EDITORIAL", editorial);
                parametros[4] = new SqlParameter("@DESCRIPCION", descripcion);
                parametros[5] = new SqlParameter("@PRECIO", precio);
                parametros[6] = new SqlParameter("@PORTADA", portada);
                parametros[7] = new SqlParameter("@STOCK", stock);

                int resultado = conexionSQL.RUD("INSERTAR_COMIC", parametros);

                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int EliminarComic(int id)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@ID", id);
                int resultado = conexionSQL.RUD("ELIMINAR_COMIC", parametros);
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EditarComic(int id, string titulo, string categoria, string editorial, string descripcion, float precio, string portada, int stock)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            try
            {
                SqlParameter[] parametros = new SqlParameter[8];
                parametros[0] = new SqlParameter("@ID", id);
                parametros[1] = new SqlParameter("@TITULO", titulo);
                parametros[2] = new SqlParameter("@CATEGORIA", categoria);
                parametros[3] = new SqlParameter("@EDITORIAL", editorial);
                parametros[4] = new SqlParameter("@DESCRIPCION", descripcion);
                parametros[5] = new SqlParameter("@PRECIO", precio);
                parametros[6] = new SqlParameter("@PORTADA", portada);
                parametros[7] = new SqlParameter("@STOCK", stock);

                int resultado = conexionSQL.RUD("EDITAR_COMIC", parametros);
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
                List<Comic> listacomics = new List<Comic>();


                ConexionSQL conexionSQL = new ConexionSQL();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@ID", id);
                DataTable resultado = conexionSQL.Leer("TRAER_COMICS", parametros);


                foreach (DataRow row in resultado.Rows)
                {
                    Comic comic = new Comic();
                    comic.ID = Convert.ToInt32(row["ID"]);
                    comic.Titulo = row["TITULO"].ToString();
                    comic.Categoria = row["CATEGORIA"].ToString();
                    comic.Editorial = row["EDITORIAL"].ToString();
                    comic.Descripcion = row["DESCRIPCION"].ToString();
                    comic.Precio = Convert.ToSingle(row["PRECIO"]);
                    comic.Stock = Convert.ToInt32(row["STOCK"]);

                    if (!row["PORTADA"].Equals(DBNull.Value))
                    {
                        string base64String = row["PORTADA"].ToString();

                        byte[] portadaBytes = Convert.FromBase64String(base64String);

                        comic.Portada = portadaBytes;
                    }


                    listacomics.Add(comic);
                }
                return listacomics;
            }
            catch (Exception)
            {
                return new List<Comic>();
            }

        }
    }
}
