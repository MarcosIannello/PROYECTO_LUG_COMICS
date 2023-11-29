using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermisoUsuarioDAL
    {

        public int ValidarPermisoUsuario(int id)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@ID", id);

            int resultado = conexionSQL.TraerUnValor("VALIDAR_PERMISO", parametros);

            return resultado;
        }

    }
}
