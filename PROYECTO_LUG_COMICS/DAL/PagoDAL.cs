using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class PagoDAL
    {
        Random rnd = new Random();
        public int InsertarPago( string domicilio, string tipoTarjeta, string numTarjeta, int importe)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            try
            {
                int idPago = rnd.Next();

                SqlParameter[] parametros = new SqlParameter[5];
                parametros[0] = new SqlParameter("@idPago", idPago);
                parametros[1] = new SqlParameter("@domicilio", domicilio);
                parametros[2] = new SqlParameter("@tipoTarjeta", tipoTarjeta);
                parametros[3] = new SqlParameter("@numTarjeta", numTarjeta);
                parametros[4] = new SqlParameter("@importe", importe);

                int resultado = conexionSQL.RUD("CREAR_PAGO_COMIC", parametros);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
