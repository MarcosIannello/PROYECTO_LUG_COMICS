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

        UsuarioDal UsuarioDal = new UsuarioDal();

        public int ValidarUsuario(string nombreUsuario, string contraseña)
        {
          
            string hashPassword = PasswordHasher.HashPassword(contraseña); // Encripta la contraseña

            int resultado;

            resultado = UsuarioDal.ValidarUsuario(nombreUsuario, hashPassword);

            return resultado;

        }

        
        public int RegistrarUsuario(string username, string password)
        {
           
            string hashPassword = PasswordHasher.HashPassword(password); // Encripta la contraseña

            int resultado = UsuarioDal.RegistrarUsuario(username, hashPassword);

            return resultado;
        }

    }
}
