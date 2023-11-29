using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PagoComic
    {
        //idPago int,
        //domicilio int,
        //tipoTarjeta varchar(max),
        //numTarjeta varchar(max),
        //importe int,
        //Fecha varchar(max)

        private int idpago;

        public int IDPAGO
        {
            get { return idpago; }
            set { idpago = value; }
        }

        private string domicilio;

        public string DOMICILIO
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        private string tipoTarjeta;

        public string TIPO_TARJETA
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }

        private string numTarjeta;

        public string NUM_TARJETA
        {
            get { return numTarjeta; }
            set { numTarjeta = value; }
        }

        private int importe;

        public int IMPORTE
        {
            get { return importe; }
            set { importe = value; }
        }

        private string fecha;

        public string FECHA
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private int idUsuario;

        public int ID_USUARIO
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


    }
}
