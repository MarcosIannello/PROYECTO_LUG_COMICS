using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ConexionSQL
    {
        public string _conexion;
        private SqlConnection conexion;

        public ConexionSQL()
        {
            this._conexion = "Data Source=.;Initial Catalog=FACULTAD;Integrated Security=True";
            this.conexion = new SqlConnection(this._conexion);
        }

        public void Open()
        { 
            conexion.Open();
        }

        public void Close()
        {
            conexion.Close();
        }

        public SqlConnection GetConnection()
        {
            return conexion;
        }

        public int TraerUnValor(string storeProcedure, SqlParameter[] parametros)
        {
            try
            {
                SqlConnection cn = this.GetConnection();

                this.Open();

                SqlCommand cmd = new SqlCommand(storeProcedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
            
                cmd.Parameters.AddRange(parametros);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                this.Close();

                return resultado;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Escribir(string storeProcedure, SqlParameter[] parametros)
        {
            try
            {
                SqlConnection cn = this.GetConnection();
                this.Open();
                SqlCommand cmd = new SqlCommand(storeProcedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametros);
                cmd.ExecuteNonQuery();
                this.Close();

                return 1;

            }
            catch(Exception ex)
            {
                return 0;
                throw ex;
            }
        }

        public int Borrar(string storeProcedure, SqlParameter[] parametros)
        {
            try
            {
                SqlConnection cn = this.GetConnection();
                this.Open();
                SqlCommand cmd = new SqlCommand(storeProcedure, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parametros);
                cmd.ExecuteNonQuery();
                this.Close();

                return 1;

            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }

        public int Update(string storeProcedure, SqlParameter[] parametros)
        {
            return 1;
        }

        public DataSet Leer(string StoreProcedure)
        {
            DataSet oDataSet = new DataSet();
            return oDataSet;
        }

        public DataTable TraerDataTable(string storeProcedure, SqlParameter[] parametros)
        {
            DataTable odt = new DataTable();
            SqlConnection cn = this.GetConnection();
            cn.Open();

            SqlCommand cmd = new SqlCommand(storeProcedure,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(parametros);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            dataAdapter.Fill(odt);

            return odt;
        }



    }
}
