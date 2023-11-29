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

        public int InsertarPago(string domicilio, string tipoTarjeta, string numTarjeta, int importe, int idUsuario)
        {
           
            try
            {
                int resultado = PagoDAL.InsertarPago(domicilio, tipoTarjeta, numTarjeta, importe, idUsuario);
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
            try
            {
                listaPagos = PagoDAL.traerPagos(id);

                return listaPagos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
