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
                using (SqlConnection cn = this.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(storeProcedure, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parametros);

                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        return resultado;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }

        }

        public int RUD(string storeProcedure, SqlParameter[] parametros)
        {

            try
            {
                using (SqlConnection cn = this.GetConnection()) 
                {
                    cn.Open();

                    using(SqlCommand cmd = new SqlCommand(storeProcedure, cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parametros);
                        
                        return cmd.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                return 0;
                throw ex.InnerException;
            }
        }

        public DataTable Leer(string storeProcedure, SqlParameter[] parametros)
        {
            try
            {
                DataTable odt = new DataTable();
                using (SqlConnection cn = this.GetConnection())
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(storeProcedure, cn))
                    {
            
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parametros);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                        dataAdapter.Fill(odt);

                        return odt;

                    }
                };

            }catch(Exception ex)
            {
                return null;
            }

        }



    }
}
