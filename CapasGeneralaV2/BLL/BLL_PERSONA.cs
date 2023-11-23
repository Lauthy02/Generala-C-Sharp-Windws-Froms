using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PERSONA
    {
        DAL.DAL_MAPPER_PERSONA mpp = new DAL.DAL_MAPPER_PERSONA();
        
        public void GuardarPersona(BE.BE_PERSONA persona)
        {
            if (persona.ID == 0)
            {
                mpp.Insertar(persona);
            }
            else
            {
                mpp.Editar(persona);
            }
        }   

        public void BorrarPersona(BE.BE_PERSONA persona)
        {
            mpp.Borrar(persona);
        }

        public List<BE_PERSONA> BuscarPersona(BE.BE_PERSONA persona) 
        {
            return mpp.Buscar(persona);
        }

        public List<BE.BE_PERSONA> ListarPersonas()
        {
            return mpp.TraerTodos();
        }
    }
}