using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_PARTIDA
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public BE_PARTIDA()
        {
            Turno = true;
            CantidadLanzadasRestantes = 3;
        }

        private BE_PERSONA persona1;
        public BE_PERSONA Persona1
        {
            get { return persona1; }
            set { persona1 = value; }
        }

        private BE_TABLADEPUNTAJES tablaDePuntajesPersona1;
        public BE_TABLADEPUNTAJES TablaDePuntajesPersona1
        {
            get { return tablaDePuntajesPersona1; }
            set { tablaDePuntajesPersona1 = value; }
        }

        private BE_PERSONA persona2;
        public BE_PERSONA Persona2
        {
            get { return persona2; }
            set { persona2 = value; }
        }

        private BE_TABLADEPUNTAJES tablaDePuntajesPersona2;
        public BE_TABLADEPUNTAJES TablaDePuntajesPersona2
        {
            get { return tablaDePuntajesPersona2; }
            set { tablaDePuntajesPersona2 = value; }
        }

        private BE_CUBILETE cubilete;
        public BE_CUBILETE Cubilete
        {
            get { return cubilete; }
            set { cubilete = value; }
        }

        private bool turno;
        public bool Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        private int cantLanzadasRestantes;
        public int CantidadLanzadasRestantes
        {
            get { return cantLanzadasRestantes; }
            set { cantLanzadasRestantes = value; }
        }

        private int ganador;
        public int Ganador
        {
            get { return ganador; }
            set { ganador = value; }
        }

        private int puntosGanador;
        public int PuntosGanador
        {
            get { return puntosGanador; }
            set { puntosGanador = value; }
        }
    }
}