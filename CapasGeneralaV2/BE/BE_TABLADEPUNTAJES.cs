using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_TABLADEPUNTAJES
    {
        public BE_TABLADEPUNTAJES()
        {
            PuntosNro1 = 0;
            PuntosNro2 = 0;
            PuntosNro3 = 0;
            PuntosNro4 = 0;
            PuntosNro5 = 0;
            PuntosNro6 = 0;
            PuntosEscalera = 0;
            PuntosFull = 0;
            PuntosPoker = 0;
            PuntosGenerala = 0;
        }
        private int puntosNro1;
        public int PuntosNro1
        {
            get { return puntosNro1; }
            set { puntosNro1 = value; }
        }

        private int puntosNro2;
        public int PuntosNro2
        {
            get { return puntosNro2; }
            set { puntosNro2 = value; }
        }

        private int puntosNro3;
        public int PuntosNro3
        {
            get { return puntosNro3; }
            set { puntosNro3 = value; }
        }

        private int puntosNro4;
        public int PuntosNro4
        {
            get { return puntosNro4; }
            set { puntosNro4 = value; }
        }

        private int puntosNro5;
        public int PuntosNro5
        {
            get { return puntosNro5; }
            set { puntosNro5 = value; }
        }

        private int puntosNro6;
        public int PuntosNro6
        {
            get { return puntosNro6; }
            set { puntosNro6 = value; }
        }

        private int puntosEscalera;
        public int PuntosEscalera
        {
            get { return puntosEscalera; }
            set { puntosEscalera = value; }
        }

        private int puntosFull;
        public int PuntosFull
        {
            get { return puntosFull; }
            set { puntosFull = value; }
        }

        private int puntosPoker;
        public int PuntosPoker
        {
            get { return puntosPoker; }
            set { puntosPoker = value; }
        }

        private int puntosGenerala;
        public int PuntosGenerala
        {
            get { return puntosGenerala; }
            set { puntosGenerala = value; }
        }

        private int puntosTotales;
        public int PuntosTotales
        {
            get { return puntosTotales; }
            set { puntosTotales = value; }
        }
    }
}