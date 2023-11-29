using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BLL
{
    public class ServicioUsuarioLogueado
    {
        UsuarioLogueadoDAL UsuarioLogueadoDAL = new UsuarioLogueadoDAL();

        public int InsertarUsuarioLogueado(UsuarioLogueado user)
        {
            int resultado = UsuarioLogueadoDAL.InsertarUsuarioLogueado(user);

            return resultado;
        }

        public int EliminarUsuarioLogueado()
        {
            int resultado = UsuarioLogueadoDAL.EliminarUsuarioLogueado();

            return resultado;
        }

        public UsuarioLogueado TraerUsuarioLogueado ()
        {
            UsuarioLogueado user = UsuarioLogueadoDAL.TraerUsuarioLogueado();
            return user;
        }


    }
}
