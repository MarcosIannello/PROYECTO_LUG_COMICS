using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Security.Cryptography;

namespace BLL
{
    public class ServicioUsuarios
    {
        public ServicioUsuarios() { }


        public int ValidarUsuario(string nombreUsuario, string contraseña)
        {
            ConexionSQL conexionSQL = new ConexionSQL();

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter("@NOMBRE_USUARIO", SqlDbType.VarChar, 50) { Value = nombreUsuario.ToUpper() };
            parametros[1] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 50) { Value = contraseña };


            int resultado;

            resultado = conexionSQL.TraerUnValor("VALIDAR_USUARIO", parametros);

            return resultado;

        }

        
        public int RegistrarUsuario(string username, string password)
        {
            ConexionSQL conexionSQL = new ConexionSQL();
            Random rnd = new Random();
            int id = rnd.Next();

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter("@NOMBRE_USUARIO", username);
            parametros[1] = new SqlParameter("@PASSWORD", password);
            parametros[2] = new SqlParameter("@id", id);

            int resultado = conexionSQL.Escribir("REGISTRAR_USUARIO", parametros);

            return resultado;
        }

    }
}
