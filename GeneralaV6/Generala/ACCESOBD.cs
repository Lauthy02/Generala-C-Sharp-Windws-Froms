using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Generala
{
    public class ACCESOBD
    {
        private SqlConnection _conexion;

        public void AbrirConexion()
        {
            _conexion = new SqlConnection();
            _conexion.ConnectionString = "Initial Catalog=GENERALA;Data Source=.\\SQLEXPRESS;Integrated Security=SSPI;";
            _conexion.Open();
        }

        public void CerrarConexion()
        {
            _conexion.Close();
            _conexion = null;
            GC.Collect();
        }

        public int Escribir(string Query)
        {
            int FilasAfectadas;
            SqlCommand comando = CrearComando(Query);
            try
            {
                FilasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                FilasAfectadas = -1;
            }
            return FilasAfectadas;
        }

        public SqlDataReader Leer(string Query)
        {
            SqlCommand comando = CrearComando(Query);
            SqlDataReader lector = comando.ExecuteReader();

            return lector;
        }

        private SqlCommand CrearComando(string Query)
        {
            //Crea el comando para no repetir estas 4 líneas de código en la lectura y escritura
            //Entonnces al inestanciar comandno le paso esta función y ya lo crea con todos los parámetros necesarios
            SqlCommand comando = new SqlCommand();
            comando.Connection = _conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = Query;

            return comando;
        }

        public int ObtenerSigueinteValorDeRegistro(string Query)
        {
            int ValorSiguiente;
            SqlCommand comando = CrearComando(Query);

            //Esto devuelve el valor max de la columna q le hayamos pasado en la query
            //Para saber cual va a ser el valor del poróximo registro a insertar

            ValorSiguiente = int.Parse(comando.ExecuteScalar().ToString());
            return ValorSiguiente;
        }
    }
}