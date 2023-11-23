using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generala
{
    public class PARTIDA
    {
        public PARTIDA()
        {
            Turno = true;
            CantidadLanzadasRestantes = 3;
        }

        private PERSONA persona1;
        public PERSONA Persona1
        {
            get { return persona1; }
            set { persona1 = value; }
        }

        private TABLADEPUNTAJES tablaDePuntajesPersona1;
        public TABLADEPUNTAJES TablaDePuntajesPersona1
        {
            get { return tablaDePuntajesPersona1; }
            set { tablaDePuntajesPersona1 = value; }
        }

        private PERSONA persona2;
        public PERSONA Persona2
        {
            get { return persona2; }
            set { persona2 = value; }
        }

        private TABLADEPUNTAJES tablaDePuntajesPersona2;
        public TABLADEPUNTAJES TablaDePuntajesPersona2
        {
            get { return tablaDePuntajesPersona2; }
            set { tablaDePuntajesPersona2 = value; }
        }

        private CUBILETE cubilete;
        public CUBILETE Cubilete
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

        public void DefinirGanador()
        {
            if (TablaDePuntajesPersona1.PuntosTotales > TablaDePuntajesPersona2.PuntosTotales)
            {
                MessageBox.Show("El ganador es: " + Persona1.Nombre);
            }
            else if (TablaDePuntajesPersona1.PuntosTotales < TablaDePuntajesPersona2.PuntosTotales)
            {
                MessageBox.Show("El ganador es: " + Persona2.Nombre);
            }
            else
            {
                MessageBox.Show("Empate");
            }
        }
    }
}