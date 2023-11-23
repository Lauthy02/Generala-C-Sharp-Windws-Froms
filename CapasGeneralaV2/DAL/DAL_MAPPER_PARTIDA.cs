using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_MAPPER_PARTIDA : DAL_MAPPER<BE.BE_PARTIDA>
    {
        public DAL_MAPPER_PARTIDA()
        {
            acceso.AbrirConexion();
        }

        ~DAL_MAPPER_PARTIDA()
        {
            acceso.CerrarConexion();
        }

        public override int Borrar(BE_PARTIDA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.ID);
            parametros.Add(p);

            int res = acceso.Escribir("PARTIDA_BORRAR", parametros);
            return res;
        }

        public override int Editar(BE_PARTIDA entidad)
        {
            int res = 0;
            return res;
        }

        public override int Insertar(BE_PARTIDA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@idganador", entidad.Ganador);
            parametros.Add(p);
            p = acceso.CrearParametro("@puntos", entidad.PuntosGanador);
            parametros.Add(p);

            int res = acceso.Escribir("PARTIDA_INSERTAR", parametros);
            return res;
        }

        public override List<BE_PARTIDA> TraerTodos()
        {
            List<BE_PARTIDA> partidas = new List<BE_PARTIDA>();
            DataTable tabla = acceso.Leer("PARTIDA_LISTAR", null);
            foreach (DataRow dr in tabla.Rows)
            {
                partidas.Add(Convertir(dr));
            }
            return partidas;
        }

        internal override BE_PARTIDA Convertir(DataRow registro)
        {
            BE_PARTIDA partida = new BE_PARTIDA();
            partida.ID = int.Parse(registro["ID"].ToString());
            partida.Ganador = int.Parse(registro["ID_GANADOR"].ToString());
            partida.PuntosGanador = int.Parse(registro["PUNTOS"].ToString());
            return partida;
        }
    }
}