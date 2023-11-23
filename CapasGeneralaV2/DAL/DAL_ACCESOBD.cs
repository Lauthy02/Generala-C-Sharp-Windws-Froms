using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    internal class DAL_ACCESOBD
    {
        private SqlConnection conexion;
        
        public void AbrirConexion()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GENERALA;Integrated Security=True");
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> args = null)
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            if (args != null)
            {
                cmd.Parameters.AddRange(args.ToArray());    
            }
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public DataTable Leer(string sql, List<SqlParameter> args = null)
        {
            DataTable tabla = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(CrearComando(sql, args))) 
            {
                da.Fill(tabla);
                da.Dispose();
            }
            return tabla;
        }

        public int Escribir(string sql, List<SqlParameter> args = null)
        {
            SqlCommand cmd = CrearComando(sql, args);
            int filAfec = 0;
            try
            {
                filAfec = cmd.ExecuteNonQuery();
            }
            catch
            {
                filAfec = -1;
            }
            return filAfec;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter param = new SqlParameter(nombre,valor);
            param.DbType = DbType.String;
            return param;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter param = new SqlParameter(nombre, valor);
            param.DbType = DbType.Int32;
            return param;
        }
    }
}
