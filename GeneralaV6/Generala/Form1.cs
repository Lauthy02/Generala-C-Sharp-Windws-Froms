using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        JUEGO Juego = new JUEGO();
        PARTIDA Partida = new PARTIDA();
        CUBILETE Cubilete = new CUBILETE();
        PERSONA PAux1 = new PERSONA();
        PERSONA PAux2 = new PERSONA();
        TABLADEPUNTAJES TdPJug1 = new TABLADEPUNTAJES();
        TABLADEPUNTAJES TdPJug2 = new TABLADEPUNTAJES();

        private void Form1_Load(object sender, EventArgs e)
        {
            TdPJug1.LlenarDataGrid(dataGridView_Jugador1);
            TdPJug2.LlenarDataGrid(dataGridView_Jugador2);

            PAux1.Nombre = "Sebastian Vettel";
            PAux2.Nombre = "Max Verstappen";

            groupBox_Jugador1.Text = "Jugador 1 - " + PAux1.Nombre;
            groupBox_Jugador2.Text = "Jugador 2 - " + PAux2.Nombre;
        }

        #region Botones
        
        private void button_IniciarPartida_Click(object sender, EventArgs e)
        {
            TABLADEPUNTAJES T1 = new TABLADEPUNTAJES();
            TABLADEPUNTAJES T2 = new TABLADEPUNTAJES();
            Partida.Persona1 = PAux1;
            Partida.TablaDePuntajesPersona1 = T1;
            Partida.Persona2 = PAux2;
            Partida.TablaDePuntajesPersona2 = T2;
            Partida.Cubilete = Cubilete;

            groupBox_Jugador1.Enabled = true;
            groupBox_Jugador2.Enabled = true;
            groupBox_Dados.Enabled = true;

            label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();
            groupBox_Jugador2.Enabled = false;
        }

        private void button_FinalizarPartida_Click(object sender, EventArgs e)
        {
            //Definir ganador y escribir en bd
            Partida.DefinirGanador();
        }

        private void button_LanzarDados_Click(object sender, EventArgs e)
        {
            if (Partida.CantidadLanzadasRestantes <= 3 && Partida.CantidadLanzadasRestantes > 0)
            {
                if (Partida.Turno) // Turno de Jugador 1 = Ture
                {
                    List<DADO> ListaDeDadosLanzados = Partida.Cubilete.LanzarDados();
                    Partida.CantidadLanzadasRestantes--;
                    label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                    MostrarImagenes(Juego.ListaDeDados[0], checkBox_Dado1);
                    MostrarImagenes(Juego.ListaDeDados[1], checkBox_Dado2);
                    MostrarImagenes(Juego.ListaDeDados[2], checkBox_Dado3);
                    MostrarImagenes(Juego.ListaDeDados[3], checkBox_Dado4);
                    MostrarImagenes(Juego.ListaDeDados[4], checkBox_Dado5);

                    Partida.TablaDePuntajesPersona1.ReiniciarTabla(dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularSumaDe1(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularSumaDe2(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularSumaDe3(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularSumaDe4(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularSumaDe5(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularSumaDe6(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularEscalera(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularFull(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularPoker(Juego.ListaDeDados, dataGridView_Jugador1);
                    Partida.TablaDePuntajesPersona1.CalcularGenerala(Juego.ListaDeDados, dataGridView_Jugador1);
                }
                else // Turno de Jugador 2 = False
                {
                    List<DADO> ListaDeDadosLanzados = Partida.Cubilete.LanzarDados();
                    Partida.CantidadLanzadasRestantes--;
                    label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                    MostrarImagenes(Juego.ListaDeDados[0], checkBox_Dado1);
                    MostrarImagenes(Juego.ListaDeDados[1], checkBox_Dado2);
                    MostrarImagenes(Juego.ListaDeDados[2], checkBox_Dado3);
                    MostrarImagenes(Juego.ListaDeDados[3], checkBox_Dado4);
                    MostrarImagenes(Juego.ListaDeDados[4], checkBox_Dado5);

                    Partida.TablaDePuntajesPersona2.ReiniciarTabla(dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularSumaDe1(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularSumaDe2(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularSumaDe3(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularSumaDe4(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularSumaDe5(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularSumaDe6(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularEscalera(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularFull(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularPoker(Juego.ListaDeDados, dataGridView_Jugador2);
                    Partida.TablaDePuntajesPersona2.CalcularGenerala(Juego.ListaDeDados, dataGridView_Jugador2);
                }
            }
            else
            {
                MessageBox.Show("No le quedan lanzadas, seleccione donde quiere poner los puntos");
            }
        }

        private void button_AplicarPuntosJug1_Click(object sender, EventArgs e)
        {
            string Desc = dataGridView_Jugador1.CurrentRow.Cells[0].Value.ToString();
            int ValorAGuardar = int.Parse(dataGridView_Jugador1.CurrentRow.Cells[2].Value.ToString());

            switch (Desc)
            {
                case "Dado 1":
                    if (dataGridView_Jugador1.Rows[0].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosNro1 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[0].ReadOnly = true;
                        dataGridView_Jugador1.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 2":
                    if (dataGridView_Jugador1.Rows[1].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosNro2 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[1].ReadOnly = true;
                        dataGridView_Jugador1.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 3":
                    if (dataGridView_Jugador1.Rows[2].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosNro3 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[2].ReadOnly = true;
                        dataGridView_Jugador1.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 4":
                    if (dataGridView_Jugador1.Rows[3].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosNro4 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[3].ReadOnly = true;
                        dataGridView_Jugador1.Rows[3].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 5":
                    if (dataGridView_Jugador1.Rows[4].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosNro5 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[4].ReadOnly = true;
                        dataGridView_Jugador1.Rows[4].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 6":
                    if (dataGridView_Jugador1.Rows[5].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosNro6 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[5].ReadOnly = true;
                        dataGridView_Jugador1.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Escalera":
                    if (dataGridView_Jugador1.Rows[6].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosEscalera = ValorAGuardar;
                        dataGridView_Jugador1.Rows[6].ReadOnly = true;
                        dataGridView_Jugador1.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Full":
                    if (dataGridView_Jugador1.Rows[7].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosFull = ValorAGuardar;
                        dataGridView_Jugador1.Rows[7].ReadOnly = true;
                        dataGridView_Jugador1.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Poker":
                    if (dataGridView_Jugador1.Rows[8].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosPoker = ValorAGuardar;
                        dataGridView_Jugador1.Rows[8].ReadOnly = true;
                        dataGridView_Jugador1.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Generala":
                    if (dataGridView_Jugador1.Rows[9].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona1.PuntosGenerala = ValorAGuardar;
                        dataGridView_Jugador1.Rows[9].ReadOnly = true;
                        dataGridView_Jugador1.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
            dataGridView_Jugador1.Rows[10].Cells[2].Value = Partida.TablaDePuntajesPersona1.PuntosTotales;
        }

        private void button_AplicarPuntosJug2_Click(object sender, EventArgs e)
        {
            string Desc = dataGridView_Jugador2.CurrentRow.Cells[0].Value.ToString();
            int ValorAGuardar = int.Parse(dataGridView_Jugador2.CurrentRow.Cells[2].Value.ToString());

            switch (Desc)
            {
                case "Dado 1":
                    if (dataGridView_Jugador2.Rows[0].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosNro1 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[0].ReadOnly = true;
                        dataGridView_Jugador2.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 2":
                    if (dataGridView_Jugador2.Rows[1].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosNro2 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[1].ReadOnly = true;
                        dataGridView_Jugador2.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 3":
                    if (dataGridView_Jugador2.Rows[2].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosNro3 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[2].ReadOnly = true;
                        dataGridView_Jugador2.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 4":
                    if (dataGridView_Jugador2.Rows[3].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosNro4 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[3].ReadOnly = true;
                        dataGridView_Jugador2.Rows[3].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 5":
                    if (dataGridView_Jugador2.Rows[4].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosNro5 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[4].ReadOnly = true;
                        dataGridView_Jugador2.Rows[4].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Este dado ya tiene puntos asignados");
                    }
                    break;
                case "Dado 6":
                    if (dataGridView_Jugador2.Rows[5].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosNro6 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[5].ReadOnly = true;
                        dataGridView_Jugador2.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Escalera":
                    if (dataGridView_Jugador2.Rows[6].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosEscalera = ValorAGuardar;
                        dataGridView_Jugador2.Rows[6].ReadOnly = true;
                        dataGridView_Jugador2.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Full":
                    if (dataGridView_Jugador2.Rows[7].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosFull = ValorAGuardar;
                        dataGridView_Jugador2.Rows[7].ReadOnly = true;
                        dataGridView_Jugador2.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Poker":
                    if (dataGridView_Jugador2.Rows[8].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosPoker = ValorAGuardar;
                        dataGridView_Jugador2.Rows[8].ReadOnly = true;
                        dataGridView_Jugador2.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                case "Generala":
                    if (dataGridView_Jugador2.Rows[9].ReadOnly != true)
                    {
                        Partida.TablaDePuntajesPersona2.PuntosGenerala = ValorAGuardar;
                        dataGridView_Jugador2.Rows[9].ReadOnly = true;
                        dataGridView_Jugador2.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        Partida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + Partida.CantidadLanzadasRestantes.ToString();

                        Partida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
            dataGridView_Jugador2.Rows[10].Cells[2].Value = Partida.TablaDePuntajesPersona1.PuntosTotales;
        }
        #endregion

        #region Eventos

        private void checkBox_Dado1_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado1.Checked)
            {
                Cubilete.ListaDeDados.Add(Juego.ListaDeDados[0]);
                checkBox_Dado1.BackColor = Color.PaleGreen;
            }
            else
            {
                Cubilete.ListaDeDados.Remove(Juego.ListaDeDados[0]);
                checkBox_Dado1.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado2_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado2.Checked)
            {
                Cubilete.ListaDeDados.Add(Juego.ListaDeDados[1]);
                checkBox_Dado2.BackColor = Color.PaleGreen;
            }
            else
            {
                Cubilete.ListaDeDados.Remove(Juego.ListaDeDados[1]);
                checkBox_Dado2.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado3_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado3.Checked)
            {
                Cubilete.ListaDeDados.Add(Juego.ListaDeDados[2]);
                checkBox_Dado3.BackColor = Color.PaleGreen;
            }
            else
            {
                Cubilete.ListaDeDados.Remove(Juego.ListaDeDados[2]);
                checkBox_Dado3.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado4_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado4.Checked)
            {
                Cubilete.ListaDeDados.Add(Juego.ListaDeDados[3]);
                checkBox_Dado4.BackColor = Color.PaleGreen;
            }
            else
            {
                Cubilete.ListaDeDados.Remove(Juego.ListaDeDados[3]);
                checkBox_Dado4.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado5_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado5.Checked)
            {
                Cubilete.ListaDeDados.Add(Juego.ListaDeDados[4]);
                checkBox_Dado5.BackColor = Color.PaleGreen;
            }
            else
            {
                Cubilete.ListaDeDados.Remove(Juego.ListaDeDados[4]);
                checkBox_Dado5.BackColor = Color.Tomato;
            }
        }

        #endregion

        #region Funciones
        void MostrarImagenes(DADO dado, CheckBox CB)
        {
            switch (dado.Valor)
            {
                case 1:
                    CB.Image = Generala.Properties.Resources._64px_dado1;
                    break;
                case 2:
                    CB.Image = Generala.Properties.Resources._64px_dado2;
                    break;
                case 3:
                    CB.Image = Generala.Properties.Resources._64px_dado3;
                    break;
                case 4:
                    CB.Image = Generala.Properties.Resources._64px_dado4;
                    break;
                case 5:
                    CB.Image = Generala.Properties.Resources._64px_dado5;
                    break;
                case 6:
                    CB.Image = Generala.Properties.Resources._64px_dado6;
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
