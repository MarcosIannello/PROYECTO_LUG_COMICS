using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPagos
    {
        PagoDAL PagoDAL = new PagoDAL();

        public int InsertarPago(string domicilio, string tipoTarjeta, string numTarjeta, int importe)
        {
           
            try
            {
                int resultado = PagoDAL.InsertarPago(domicilio, tipoTarjeta, numTarjeta, importe);
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

    }
}
