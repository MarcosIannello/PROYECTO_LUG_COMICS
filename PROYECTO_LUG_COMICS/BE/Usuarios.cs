using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuarios
    {
		public Usuarios(int id, string nombreUsuario, string contrasena)
		{
			this.ID = id;	
			this.NOMBREUSUARIO = nombreUsuario;
			this.Password = contrasena;
		}

		private int ID;
		public int id
		{
			get { return ID; }
			set { ID = value; }
		}

		private string NOMBREUSUARIO;
		public string NombreUsuario
		{
			get { return NOMBREUSUARIO; }
			set { NOMBREUSUARIO = value; }
		}

		private string PASSWORD;
		public string Password
		{
			get { return PASSWORD; }
			set { PASSWORD = value; }
		}

	}
}
