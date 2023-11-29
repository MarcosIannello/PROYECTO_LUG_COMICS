using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{
    public class PagoDAL
    {
        Random rnd = new Random();
        public int InsertarPago( string domicilio, string tipoTarjeta, string numTarjeta, int importe, int idUsuario)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            try
            {
                int idPago = rnd.Next();

                SqlParameter[] parametros = new SqlParameter[6];
                parametros[0] = new SqlParameter("@idPago", idPago);
                parametros[1] = new SqlParameter("@domicilio", domicilio);
                parametros[2] = new SqlParameter("@tipoTarjeta", tipoTarjeta);
                parametros[3] = new SqlParameter("@numTarjeta", numTarjeta);
                parametros[4] = new SqlParameter("@importe", importe);
                parametros[5] = new SqlParameter("@id_usuario", idUsuario);


                int resultado = conexionSQL.RUD("CREAR_PAGO_COMIC", parametros);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<dynamic> traerPagos(string id = null)
        {
            List<dynamic> listaPagos = new List<dynamic>();

            ConexionSQL conexionSQL = new ConexionSQL();
            try
            {

                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@idUsuario", id);
              

                var resultado = conexionSQL.Leer("TRAER_PAGOS_COMICS", parametros);

                foreach(DataRow row in resultado.Rows) 
                {
                    dynamic pc = new
                    {
                        IDPAGO = Convert.ToInt32(row["idPago"]),
                        DOMICILIO = row["domicilio"].ToString(),
                        FECHA = row["fecha"].ToString(),
                        IMPORTE = Convert.ToInt32(row["importe"])
                    };
                    listaPagos.Add(pc);
                }

                return listaPagos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    }
}
