using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public abstract class DAL_MAPPER<T>
    {
        internal DAL_ACCESOBD acceso = new DAL_ACCESOBD();

        public abstract int Insertar(T entidad);
        public abstract int Borrar(T entidad);
        public abstract int Editar(T entidad);
        public abstract List<T> TraerTodos();

        internal abstract T Convertir(DataRow registro);
    }
}