using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PARTIDA
    {
        DAL.DAL_MAPPER_PARTIDA mpp = new DAL.DAL_MAPPER_PARTIDA();

        public void LanzarDados(BE.BE_PARTIDA bE_PARTIDA, BLL_CUBILETE bLL_CUBILETE)
        {
            bLL_CUBILETE.LanzarDados(bE_PARTIDA.Cubilete);
        }

        public void DefinirGanador(BE.BE_PARTIDA partida)
        {
            if (partida.TablaDePuntajesPersona1.PuntosTotales > partida.TablaDePuntajesPersona2.PuntosTotales)
            {
                partida.Ganador= partida.Persona1.ID;
                partida.PuntosGanador = partida.TablaDePuntajesPersona1.PuntosTotales;
            }
            else if (partida.TablaDePuntajesPersona1.PuntosTotales < partida.TablaDePuntajesPersona2.PuntosTotales)
            {
                partida.Ganador = partida.Persona2.ID;
                partida.PuntosGanador = partida.TablaDePuntajesPersona2.PuntosTotales;
            }
            else
            {
                //MessageBox.Show("Empate");
            }
        }

        public void GuardarPartida(BE.BE_PARTIDA partida)
        {
            mpp.Insertar(partida);
        }

        public void BorrarPartida(BE.BE_PARTIDA partida)
        {
            mpp.Borrar(partida);
        }

        public List<BE.BE_PARTIDA> ListarPartidas()
        {   
            return mpp.TraerTodos();
        }
    }
}