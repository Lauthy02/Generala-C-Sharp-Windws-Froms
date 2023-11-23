using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TABLADEPUNTAJES
    {
        public void CalcularSumaDePuntos(BE.BE_TABLADEPUNTAJES tdp)
        {
            int PtsTot = tdp.PuntosNro1 + tdp.PuntosNro2 + tdp.PuntosNro3 + tdp.PuntosNro4 + tdp.PuntosNro5 + tdp.PuntosNro6 + tdp.PuntosEscalera + tdp.PuntosFull + tdp.PuntosPoker + tdp.PuntosGenerala;
            tdp.PuntosTotales = PtsTot;
        }

        public int CalcularSumaDe1(List<BE.BE_DADO> ld)
        {
            int[] numeros = CalcularArray(ld);
            return numeros[1];
        }

        public int CalcularSumaDe2(List<BE.BE_DADO> ld)
        {
            int[] numeros = CalcularArray(ld);
            return numeros[2] * 2;
        }

        public int CalcularSumaDe3(List<BE.BE_DADO> ld)
        {
            int[] numeros = CalcularArray(ld);
            return numeros[3] * 3;
        }

        public int CalcularSumaDe4(List<BE.BE_DADO> ld)
        {
            int[] numeros = CalcularArray(ld);
            return numeros[4] * 4;
        }

        public int CalcularSumaDe5(List<BE.BE_DADO> ld)
        {
            int[] numeros = CalcularArray(ld);
            return numeros[5] * 5;
        }

        public int CalcularSumaDe6(List<BE.BE_DADO> ld)
        {
            int[] numeros = CalcularArray(ld);
            return numeros[6] * 6;
        }

        public int CalcularEscalera(List<BE.BE_DADO> ld)
        {
            bool Escalera = false;
            int[] numeros = CalcularArray(ld);

            if (numeros[1] == 1 && numeros[2] == 1 && numeros[3] == 1 && numeros[4] == 1 && numeros[5] == 1)
            {
                Escalera = true;
            }

            if (numeros[2] == 1 && numeros[3] == 1 && numeros[4] == 1 && numeros[5] == 1 && numeros[6] == 1)
            {
                Escalera = true;
            }

            if (Escalera)
            {
                return 10;
            }
            else 
            { 
                return 0; 
            }
        }

        public int CalcularFull(List<BE.BE_DADO> ld) 
        {
            bool Full;
            int[] numeros = CalcularArray(ld); //Necesito que sea de 7 porque es de 0 a 6 y 0 no lo uso
            bool numerocon3 = false;
            bool numerocon2 = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                /*
                 * Si en algna posiciòn del array hay un valor 3 quiere decir 
                 * que ese ese valor de dado estuvo 3 veces en la tirada
                */
                if (numeros[i] == 3)
                {
                    numerocon3 = true;
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                /*
                 * Si en algna posiciòn del array hay un valor 2 quiere decir 
                 * que ese ese valor de dado estuvo 2 veces en la tirada
                */
                if (numeros[i] == 2)
                {
                    numerocon2 = true;
                }
            }

            if (numerocon3 && numerocon2)
            {
                /*
                 * Si numeros con 2 y numeros con 3 son true entonces full
                */
                Full = true;
            }
            else
            {
                Full = false;
            }

            if (Full)
            {
                return 30;
            }
            else 
            {
                return 0;
            }
        }

        public int CalcularPoker(List<BE.BE_DADO> ld)
        {
            bool Poker = false;
            int[] numeros = CalcularArray(ld);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 4)
                {
                    Poker = true;
                }
            }

            if (Poker)
            {
                return 40;
            }
            else
            {
                return 0;
            }
        }

        public int CalcularGenerala(List<BE.BE_DADO> ld)
        {
            bool Generala = false;
            int[] numeros = CalcularArray(ld);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 5)
                {
                    Generala = true;
                }
            }

            if (Generala)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        private int[] CalcularArray(List<BE.BE_DADO> ld)
        {
            int[] numeros = new int[7];
            for (int i = 0; i < ld.Count; i++)
            {
                /*
                 * Esto lo que hace es en un array ir sumando la cantidad de veces q apareció x valor en la tirada
                */
                if (ld[i].Valor == 1)
                {
                    numeros[1]++;
                }
                if (ld[i].Valor == 2)
                {
                    numeros[2]++;
                }
                if (ld[i].Valor == 3)
                {
                    numeros[3]++;
                }
                if (ld[i].Valor == 4)
                {
                    numeros[4]++;
                }
                if (ld[i].Valor == 5)
                {
                    numeros[5]++;
                }
                if (ld[i].Valor == 6)
                {
                    numeros[6]++;
                }
            }
            return numeros;
        }
    }
}