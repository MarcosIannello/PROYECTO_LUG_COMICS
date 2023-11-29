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
    public class UsuarioLogueadoDAL
    {
        public int InsertarUsuarioLogueado(UsuarioLogueado user)
        {
            ConexionSQL conexionSQL = new ConexionSQL();

            try
            {
                SqlParameter[] parametros = new SqlParameter[3];

                parametros[0] = new SqlParameter("@ID", user.ID);
                parametros[1] = new SqlParameter("@NOMBRE", user.NombreUsuario);
                parametros[2] = new SqlParameter("@IDPERMISO",user.IdPermiso );

                int resultado = conexionSQL.RUD("INSERTAR_USUARIO_LOGUEADO", parametros);

                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int EliminarUsuarioLogueado()
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            try
            {
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@ID",null);
                int resultado = conexionSQL.RUD("ELIMINAR_USUARIO_LOGUEADO", parametros);
                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public UsuarioLogueado TraerUsuarioLogueado()
        {
            try
            {
                UsuarioLogueado user = new UsuarioLogueado();

                ConexionSQL conexionSQL = new ConexionSQL();
                SqlParameter[] parametros = new SqlParameter[1];
                parametros[0] = new SqlParameter("@ID", null);
                DataTable resultado = conexionSQL.Leer("TRAER_USUARIO_LOGUEADO", parametros);

                foreach (DataRow row in resultado.Rows)
                {
                    user.ID = Convert.ToInt32(row["ID"]);
                    user.NombreUsuario = row["NOMBRE"].ToString();
                    user.IdPermiso = Convert.ToInt32(row["IDPERMISO"]);
                }
                return user;
                
            }
            catch (Exception)
            {
                return null;
            }

        }

    }
}
