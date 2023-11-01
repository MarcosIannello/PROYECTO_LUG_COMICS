using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioComic
    {

        public int InsertarComic(string titulo, string categoria, string editorial, string descripcion, float precio, byte[] portada, int stock)
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

               int resultado = conexionSQL.Escribir("INSERTAR_COMIC", parametros);

                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public List<Comic> TraerComics(int id = -1)
        {
            try
            {   List<Comic> listacomics = new List<Comic>();
                string sID = id.ToString();
                if (id ==-1)
                {
                      sID = null;
                }

                ConexionSQL conexionSQL = new ConexionSQL();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@ID", sID);
                DataTable resultado = conexionSQL.TraerDataTable("TRAER_COMICS", parametros);

                
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
                        comic.Portada = (byte[])row["PORTADA"];
                    }
                    
                    
                    listacomics.Add(comic);
                }
                return listacomics;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        



    }
}
