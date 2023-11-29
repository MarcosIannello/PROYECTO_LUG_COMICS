using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ServicioPermisoUsuario
    {
        PermisoUsuarioDAL PermisoUsuarioDAL = new PermisoUsuarioDAL();

        public int TraerPermisoPorUsuario(int id)
        {
            try
            {
                int resultado = PermisoUsuarioDAL.ValidarPermisoUsuario(id);

                return resultado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
