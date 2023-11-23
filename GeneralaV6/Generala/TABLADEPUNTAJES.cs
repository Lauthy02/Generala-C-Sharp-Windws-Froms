using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generala
{
    public class TABLADEPUNTAJES
    {
        public TABLADEPUNTAJES()
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
            get { return puntosTotales = HacerSumaDePuntos();}
            set { puntosTotales = value; }
        }

        public void LlenarDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Add("Dado 1", "Suma de 1", PuntosNro1);
            dataGrid.Rows.Add("Dado 2", "Suma de 2", PuntosNro2);
            dataGrid.Rows.Add("Dado 3", "Suma de 3", PuntosNro3);
            dataGrid.Rows.Add("Dado 4", "Suma de 4", PuntosNro4);
            dataGrid.Rows.Add("Dado 5", "Suma de 5", PuntosNro5);
            dataGrid.Rows.Add("Dado 6", "Suma de 6", PuntosNro6);
            dataGrid.Rows.Add("Escalera", "Simple: 10pts", PuntosEscalera);
            dataGrid.Rows.Add("Full", "Simple: 30pts", PuntosFull);
            dataGrid.Rows.Add("Poker", "Simple: 40pts", PuntosPoker);
            dataGrid.Rows.Add("Generala", "Simple: 50pts", PuntosGenerala);
            dataGrid.Rows.Add("TOTAL", "Total de puntos", PuntosTotales);
            /*
             * Escalera: Normal=10pts Servida=15pts
             * Full: Normal=30pts Servida=35pts
             * Poker: Normal=40pts Servida=45pts
             * Generala: Normal=50pts Doble=100pts
             */
        }

        private int HacerSumaDePuntos()
        {
            int PtsTot = PuntosNro1 + PuntosNro2 + PuntosNro3 + PuntosNro4 + PuntosNro5 + PuntosNro6 + PuntosEscalera + PuntosFull + PuntosPoker + PuntosGenerala;
            return PtsTot;
        }

        public void CalcularSumaDe1(List<DADO> ld, DataGridView dg)
        {
            int[] numeros = CalcularArray(ld);
            if (numeros[1] != 0)
            {
                if (dg.Rows[0].ReadOnly == true)
                {
                    dg[2, 0].Value = PuntosNro1;
                    dg.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 0].Value = numeros[1];
                    dg.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void CalcularSumaDe2(List<DADO> ld, DataGridView dg)
        {
            int[] numeros = CalcularArray(ld);
            if (numeros[2] * 2 != 0)
            {
                if (dg.Rows[1].ReadOnly == true)
                {
                    dg[2, 1].Value = PuntosNro2;
                    dg.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 1].Value = numeros[2] * 2;
                    dg.Rows[1].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void CalcularSumaDe3(List<DADO> ld, DataGridView dg)
        {
            int[] numeros = CalcularArray(ld);
            if (numeros[3] * 3 != 0)
            {
                if (dg.Rows[2].ReadOnly == true)
                {
                    dg[2, 2].Value = PuntosNro3;
                    dg.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 2].Value = numeros[3] * 3;
                    dg.Rows[2].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void CalcularSumaDe4(List<DADO> ld, DataGridView dg)
        {
            int[] numeros = CalcularArray(ld);
            if (numeros[4] * 4 != 0)
            {
                if (dg.Rows[3].ReadOnly == true)
                {
                    dg[2, 3].Value = PuntosNro4;
                    dg.Rows[3].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 3].Value = numeros[4] * 4;
                    dg.Rows[3].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void CalcularSumaDe5(List<DADO> ld, DataGridView dg)
        {
            int[] numeros = CalcularArray(ld);
            if (numeros[5] * 5 != 0)
            {
                if (dg.Rows[4].ReadOnly == true)
                {
                    dg[2, 4].Value = PuntosNro5;
                    dg.Rows[4].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 4].Value = numeros[5] * 5;
                    dg.Rows[4].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void CalcularSumaDe6(List<DADO> ld, DataGridView dg)
        {
            int[] numeros = CalcularArray(ld);
            if (numeros[6] * 6 != 0)
            {
                if (dg.Rows[5].ReadOnly == true)
                {
                    dg[2, 5].Value = PuntosNro6;
                    dg.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 5].Value = numeros[6] * 6;
                    dg.Rows[5].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void CalcularEscalera(List<DADO> ld, DataGridView dg)
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
                if (dg.Rows[6].ReadOnly == true)
                {
                    dg[2, 6].Value = PuntosEscalera;
                    dg.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg.Rows[6].DefaultCellStyle.ForeColor = Color.Red;
                    dg[2, 6].Value = 10;
                    MessageBox.Show("Hiciste Escalera");
                }
            }
        }

        public void CalcularFull(List<DADO> ld, DataGridView dg)
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
                if (dg.Rows[7].ReadOnly == true)
                {
                    dg[2, 7].Value = PuntosFull;
                    dg.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg.Rows[7].DefaultCellStyle.ForeColor = Color.Red;
                    dg[2, 7].Value = 30;
                    MessageBox.Show("Hiciste Full");
                }
            }
        }

        public void CalcularPoker(List<DADO> ld, DataGridView dg)
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
                if (dg.Rows[8].ReadOnly == true)
                {
                    dg[2, 8].Value = PuntosPoker;
                    dg.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg.Rows[8].DefaultCellStyle.ForeColor = Color.Red;
                    dg[2, 8].Value = 40;
                    MessageBox.Show("Hiciste Poker");
                }
            }
        }

        public void CalcularGenerala(List<DADO> ld, DataGridView dg)
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
                if (dg.Rows[9].ReadOnly == true)
                {
                    dg[2, 9].Value = PuntosGenerala;
                    dg.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg.Rows[9].DefaultCellStyle.ForeColor = Color.Red;
                    dg[2, 9].Value = 50;
                    MessageBox.Show("Hiciste Generala");
                }
            }
        }

        public void ReiniciarTabla(DataGridView dg)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (dg.Rows[i].ReadOnly != true)
                {
                    dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dg[2, i].Value = 0;
                }
            }
        }

        private int[] CalcularArray(List<DADO> ld)
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