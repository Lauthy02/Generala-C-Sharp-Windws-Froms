using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_MAPPER_PERSONA : DAL_MAPPER<BE.BE_PERSONA>
    {
        public DAL_MAPPER_PERSONA()
        {
            acceso.AbrirConexion();
        }

        ~DAL_MAPPER_PERSONA()
        {
            acceso.CerrarConexion();
        }

        public List<BE_PERSONA> Buscar(BE.BE_PERSONA entidad)
        {
            List<BE.BE_PERSONA> personas = new List<BE.BE_PERSONA>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@password", entidad.Password);
            parametros.Add(p);

            DataTable tabla = acceso.Leer("PERSONA_BUSCAR", parametros);
            foreach (DataRow dr in tabla.Rows)
            {
                personas.Add(Convertir(dr));
            }
            return personas;
        }

        public override int Insertar(BE.BE_PERSONA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);
            p = acceso.CrearParametro("@password", entidad.Password);
            parametros.Add(p);

            int res = acceso.Escribir("PERSONA_INSERTAR", parametros);
            return res;
        }

        public override int Borrar(BE.BE_PERSONA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.ID);
            parametros.Add(p);

            int res = acceso.Escribir("PERSONA_BORRAR", parametros);
            return res;
        }

        public override int Editar(BE.BE_PERSONA entidad)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter p = acceso.CrearParametro("@id", entidad.ID);
            parametros.Add(p);
            p = acceso.CrearParametro("@nombre", entidad.Nombre);
            parametros.Add(p);

            int res = acceso.Escribir("PERSONA_EDITAR", parametros);
            return res;
        }

        public override List<BE.BE_PERSONA> TraerTodos()
        {
            List<BE.BE_PERSONA> personas = new List<BE.BE_PERSONA>();
            DataTable tabla = acceso.Leer("PERSONA_LISTAR", null);
            foreach (DataRow dr in tabla.Rows)
            {
                personas.Add(Convertir(dr));
            }
            return personas;
        }

        internal override BE.BE_PERSONA Convertir(DataRow registro)
        {
            BE_PERSONA persona = new BE_PERSONA();
            persona.ID = int.Parse(registro["ID"].ToString());
            persona.Nombre = registro["NOMBRE"].ToString();
            persona.Password = registro["PASSWORD"].ToString();
            return persona;
        }
    }
}