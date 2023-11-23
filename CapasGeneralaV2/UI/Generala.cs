using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Generala : Form
    {
        public Generala()
        {
            InitializeComponent();
        }

        BE.BE_JUEGO BEJuego = new BE.BE_JUEGO();

        BE.BE_PARTIDA BEPartida = new BE.BE_PARTIDA();
        BE.BE_PARTIDA BEPartidaTemp = new BE.BE_PARTIDA();
        BLL_PARTIDA BLLPartida = new BLL_PARTIDA();

        BE.BE_TABLADEPUNTAJES BETablaDePuntajesP1 = new BE.BE_TABLADEPUNTAJES();
        BLL_TABLADEPUNTAJES BLLTablaDePuntajesP1 = new BLL_TABLADEPUNTAJES();

        BE.BE_TABLADEPUNTAJES BETablaDePuntajesP2 = new BE.BE_TABLADEPUNTAJES();
        BLL_TABLADEPUNTAJES BLLTablaDePuntajesP2 = new BLL_TABLADEPUNTAJES();

        BE.BE_CUBILETE BECubilete = new BE.BE_CUBILETE();
        BLL_CUBILETE BLLCubilete = new BLL_CUBILETE();

        BE_PERSONA BEPersonaP1 = new BE.BE_PERSONA();
        BE_PERSONA BEPersonaP2 = new BE.BE_PERSONA();
        BE_PERSONA BEPersonaTemp;
        BLL_PERSONA BLLPersonaGestor = new BLL_PERSONA();

        private void Juego_Load(object sender, EventArgs e)
        {
            LlenarDataGrid(dataGridView_Jugador1);        
            LlenarDataGrid(dataGridView_Jugador2);
           
            Enlazar();
            EnlazarDGPartida();
        }

        #region Botones
        private void button_IniciarPartida_Click(object sender, EventArgs e)
        {
            BEPartida.Cubilete = BECubilete;

            BEPartida.TablaDePuntajesPersona1 = BETablaDePuntajesP1;
            BEPartida.Persona1 = BEPersonaP1;

            BEPartida.TablaDePuntajesPersona2 = BETablaDePuntajesP2;
            BEPartida.Persona2 = BEPersonaP2;

            groupBox_Jugador1.Enabled = true;
            groupBox_Jugador2.Enabled = true;
            groupBox_Dados.Enabled = true;

            button_IniciarPartida.Enabled = false;
            button_FinalizarPartida.Enabled = true;

            label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();
            groupBox_Jugador2.Enabled = false;
        }

        private void button_FinalizarPartida_Click(object sender, EventArgs e)
        {
            button_FinalizarPartida.Enabled = false;
            groupBox_Jugador1.Enabled = false;
            groupBox_Jugador2.Enabled = false;
            groupBox_Dados.Enabled = false;
            //Definir ganador
            BLLPartida.DefinirGanador(BEPartida);
            MessageBox.Show($"El usuario: {BEPartida.Ganador} ganó la partida");
            //Guardar en bd
            BLLPartida.GuardarPartida(BEPartida);
        }

        private void button_LanzarDados_Click(object sender, EventArgs e)
        {
            if (BEPartida.CantidadLanzadasRestantes <= 3 && BEPartida.CantidadLanzadasRestantes > 0)
            {
                if (BEPartida.Turno) //Turno de Jugador 1 = Ture
                {
                    BLLPartida.LanzarDados(BEPartida,BLLCubilete);

                    BEPartida.CantidadLanzadasRestantes--;
                    label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();
                    
                    MostrarImagenes(BEJuego.ListaDeDados[0], checkBox_Dado1);
                    MostrarImagenes(BEJuego.ListaDeDados[1], checkBox_Dado2);
                    MostrarImagenes(BEJuego.ListaDeDados[2], checkBox_Dado3);
                    MostrarImagenes(BEJuego.ListaDeDados[3], checkBox_Dado4);
                    MostrarImagenes(BEJuego.ListaDeDados[4], checkBox_Dado5);

                    ReiniciarTabla(dataGridView_Jugador1);

                    PonerSumaDe1(BLLTablaDePuntajesP1,BETablaDePuntajesP1,BEJuego.ListaDeDados,dataGridView_Jugador1);
                    PonerSumaDe2(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerSumaDe3(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerSumaDe4(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerSumaDe5(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerSumaDe6(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerEscalera(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerFull(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerPoker(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                    PonerGenerala(BLLTablaDePuntajesP1, BETablaDePuntajesP1, BEJuego.ListaDeDados, dataGridView_Jugador1);
                }
                else //Turno de Jugador 2 = False
                {
                    BLLPartida.LanzarDados(BEPartida, BLLCubilete);

                    BEPartida.CantidadLanzadasRestantes--;
                    label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                    MostrarImagenes(BEJuego.ListaDeDados[0], checkBox_Dado1);
                    MostrarImagenes(BEJuego.ListaDeDados[1], checkBox_Dado2);
                    MostrarImagenes(BEJuego.ListaDeDados[2], checkBox_Dado3);
                    MostrarImagenes(BEJuego.ListaDeDados[3], checkBox_Dado4);
                    MostrarImagenes(BEJuego.ListaDeDados[4], checkBox_Dado5);

                    ReiniciarTabla(dataGridView_Jugador2);

                    PonerSumaDe1(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerSumaDe2(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerSumaDe3(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerSumaDe4(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerSumaDe5(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerSumaDe6(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerEscalera(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerFull(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerPoker(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
                    PonerGenerala(BLLTablaDePuntajesP2, BETablaDePuntajesP2, BEJuego.ListaDeDados, dataGridView_Jugador2);
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
                        BEPartida.TablaDePuntajesPersona1.PuntosNro1 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[0].ReadOnly = true;
                        dataGridView_Jugador1.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosNro2 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[1].ReadOnly = true;
                        dataGridView_Jugador1.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosNro3 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[2].ReadOnly = true;
                        dataGridView_Jugador1.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosNro4 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[3].ReadOnly = true;
                        dataGridView_Jugador1.Rows[3].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosNro5 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[4].ReadOnly = true;
                        dataGridView_Jugador1.Rows[4].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosNro6 = ValorAGuardar;
                        dataGridView_Jugador1.Rows[5].ReadOnly = true;
                        dataGridView_Jugador1.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosEscalera = ValorAGuardar;
                        dataGridView_Jugador1.Rows[6].ReadOnly = true;
                        dataGridView_Jugador1.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosFull = ValorAGuardar;
                        dataGridView_Jugador1.Rows[7].ReadOnly = true;
                        dataGridView_Jugador1.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosPoker = ValorAGuardar;
                        dataGridView_Jugador1.Rows[8].ReadOnly = true;
                        dataGridView_Jugador1.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
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
                        BEPartida.TablaDePuntajesPersona1.PuntosGenerala = ValorAGuardar;
                        dataGridView_Jugador1.Rows[9].ReadOnly = true;
                        dataGridView_Jugador1.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = false;
                        groupBox_Jugador1.Enabled = false;
                        groupBox_Jugador2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                default:
                    MessageBox.Show("Seleccione otra fila");
                    break;
            }
            PonerSumaDePuntos(BLLTablaDePuntajesP1, BETablaDePuntajesP1, dataGridView_Jugador1);
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
                        BEPartida.TablaDePuntajesPersona2.PuntosNro1 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[0].ReadOnly = true;
                        dataGridView_Jugador2.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosNro2 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[1].ReadOnly = true;
                        dataGridView_Jugador2.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosNro3 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[2].ReadOnly = true;
                        dataGridView_Jugador2.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosNro4 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[3].ReadOnly = true;
                        dataGridView_Jugador2.Rows[3].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosNro5 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[4].ReadOnly = true;
                        dataGridView_Jugador2.Rows[4].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosNro6 = ValorAGuardar;
                        dataGridView_Jugador2.Rows[5].ReadOnly = true;
                        dataGridView_Jugador2.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosEscalera = ValorAGuardar;
                        dataGridView_Jugador2.Rows[6].ReadOnly = true;
                        dataGridView_Jugador2.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosFull = ValorAGuardar;
                        dataGridView_Jugador2.Rows[7].ReadOnly = true;
                        dataGridView_Jugador2.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosPoker = ValorAGuardar;
                        dataGridView_Jugador2.Rows[8].ReadOnly = true;
                        dataGridView_Jugador2.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
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
                        BEPartida.TablaDePuntajesPersona2.PuntosGenerala = ValorAGuardar;
                        dataGridView_Jugador2.Rows[9].ReadOnly = true;
                        dataGridView_Jugador2.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
                        MessageBox.Show($"Se guardaron {ValorAGuardar}pts al {Desc}");

                        BEPartida.CantidadLanzadasRestantes = 3;
                        label_LanzadasRest.Text = "Lanz rest: " + BEPartida.CantidadLanzadasRestantes.ToString();

                        BEPartida.Turno = true;
                        groupBox_Jugador1.Enabled = true;
                        groupBox_Jugador2.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Esta combinación ya tiene puntos asignados");
                    }
                    break;
                default:
                    MessageBox.Show("Seleccione otra fila");
                    break;
            }
            PonerSumaDePuntos(BLLTablaDePuntajesP2, BETablaDePuntajesP2, dataGridView_Jugador2);
        }

        private void button_Nuevo_Click(object sender, EventArgs e)
        {
            BEPersonaTemp = new BE_PERSONA();
            groupBox_ABMPersonas.Enabled = true;
        }

        private void button_Grabar_Click(object sender, EventArgs e)
        {
            BEPersonaTemp.Nombre = textBox_Persona_Nom.Text;
            BEPersonaTemp.Password = textBox_Persona_Passw.Text;
            BLLPersonaGestor.GuardarPersona(BEPersonaTemp);
            BEPersonaTemp = null;
            textBox_Persona_Nom.Text = "";
            textBox_Persona_Passw.Text = "";
            Enlazar();
        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            if (BEPersonaTemp != null)
            {
                BLLPersonaGestor.BorrarPersona(BEPersonaTemp);
                textBox_Persona_Nom.Text = "";
                textBox_Persona_Passw.Text = "";
                Enlazar();
            }
        }

        private void button_NuevoPartida_Click(object sender, EventArgs e)
        {
            BEPartidaTemp = new BE_PARTIDA();
        }

        private void button_BorrarPartida_Click(object sender, EventArgs e)
        {
            if (BEPersonaTemp != null)
            {
                BLLPartida.BorrarPartida(BEPartidaTemp);
                EnlazarDGPartida();
            }
        }

        private void button_IngP1_Click(object sender, EventArgs e)
        {
            BE_PERSONA BEPersonaTemp = new BE_PERSONA();
            BEPersonaTemp.Nombre = textBox_NomP1.Text;
            BEPersonaTemp.Password = textBox_PassP1.Text;
            List<BE_PERSONA> lp = BLLPersonaGestor.BuscarPersona(BEPersonaTemp);

            if (lp.Count != 0)
            {
                BEPersonaP1 = lp[0];
                MessageBox.Show($"Bienvenido {BEPersonaP1.Nombre}");
                groupBox_Jugador1.Text = "Jugador 1 - " + BEPersonaP1.Nombre;
                groupBox_LogIn1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void button_IngP2_Click(object sender, EventArgs e)
        {
            BE_PERSONA BEPersonaTemp = new BE_PERSONA();
            BEPersonaTemp.Nombre = textBox_NomP2.Text;
            BEPersonaTemp.Password = textBox_PassP2.Text;
            List<BE_PERSONA> lp = BLLPersonaGestor.BuscarPersona(BEPersonaTemp);

            if (lp.Count != 0)
            {
                BEPersonaP2 = lp[0];
                MessageBox.Show($"Bienvenido {BEPersonaP2.Nombre}");
                groupBox_Jugador2.Text = "Jugador 2 - " + BEPersonaP2.Nombre;
                groupBox_LogIn2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
        #endregion

        #region Funciones
        public void LlenarDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Add("Dado 1", "Suma de 1", 0);
            dataGrid.Rows.Add("Dado 2", "Suma de 2", 0);
            dataGrid.Rows.Add("Dado 3", "Suma de 3", 0);
            dataGrid.Rows.Add("Dado 4", "Suma de 4", 0);
            dataGrid.Rows.Add("Dado 5", "Suma de 5", 0);
            dataGrid.Rows.Add("Dado 6", "Suma de 6", 0);
            dataGrid.Rows.Add("Escalera", "Simple: 10pts", 0);
            dataGrid.Rows.Add("Full", "Simple: 30pts", 0);
            dataGrid.Rows.Add("Poker", "Simple: 40pts", 0);
            dataGrid.Rows.Add("Generala", "Simple: 50pts", 0);
            dataGrid.Rows.Add("TOTAL", "Total de puntos", 0);
            /*
             * Escalera: Normal=10pts Servida=15pts
             * Full: Normal=30pts Servida=35pts
             * Poker: Normal=40pts Servida=45pts
             * Generala: Normal=50pts Doble=100pts
             */
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

        public void MostrarImagenes(BE.BE_DADO dado, CheckBox CB)
        {
            switch (dado.Valor)
            {
                case 1:
                    CB.Image = UI.Properties.Resources._64px_dado1;
                    break;
                case 2:
                    CB.Image = UI.Properties.Resources._64px_dado2;
                    break;
                case 3:
                    CB.Image = UI.Properties.Resources._64px_dado3;
                    break;
                case 4:
                    CB.Image = UI.Properties.Resources._64px_dado4;
                    break;
                case 5:
                    CB.Image = UI.Properties.Resources._64px_dado5;
                    break;
                case 6:
                    CB.Image = UI.Properties.Resources._64px_dado6;
                    break;
                default:
                    break;
            }
        }

        void Enlazar()
        {
            dataGridView_ABMPersonas.DataSource = null;
            dataGridView_ABMPersonas.DataSource = BLLPersonaGestor.ListarPersonas();
        }

        void EnlazarDGPartida() 
        { 
            dataGridView_ABMPartidas.DataSource = null;
            dataGridView_ABMPartidas.DataSource = BLLPartida.ListarPartidas();
        }

        public void PonerSumaDe1(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES tdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularSumaDe1(ld);

            if (numero != 0)
            {
                if (dg.Rows[0].ReadOnly == true)
                {
                    dg[2, 0].Value = tdp.PuntosNro1;
                    dg.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 0].Value = numero;
                    dg.Rows[0].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerSumaDe2(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES tdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularSumaDe2(ld);

            if (numero != 0)
            {
                if (dg.Rows[1].ReadOnly == true)
                {
                    dg[2, 1].Value = tdp.PuntosNro2;
                    dg.Rows[1].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 1].Value = numero;
                    dg.Rows[1].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerSumaDe3(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularSumaDe3(ld);
            if (numero != 0)
            {
                if (dg.Rows[2].ReadOnly == true)
                {
                    dg[2, 2].Value = BEtdp.PuntosNro3;
                    dg.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 2].Value = numero;
                    dg.Rows[2].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerSumaDe4(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularSumaDe4(ld);
            if (numero != 0)
            {
                if (dg.Rows[3].ReadOnly == true)
                {
                    dg[2, 3].Value = BEtdp.PuntosNro4;
                    dg.Rows[3].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 3].Value = numero;
                    dg.Rows[3].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        
        public void PonerSumaDe5(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularSumaDe5(ld);
            if (numero != 0)
            {
                if (dg.Rows[4].ReadOnly == true)
                {
                    dg[2, 4].Value = BEtdp.PuntosNro5;
                    dg.Rows[4].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 4].Value = numero;
                    dg.Rows[4].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        
        public void PonerSumaDe6(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularSumaDe6(ld);
            if (numero != 0)
            {
                if (dg.Rows[5].ReadOnly == true)
                {
                    dg[2, 5].Value = BEtdp.PuntosNro6;
                    dg.Rows[5].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 5].Value = numero;
                    dg.Rows[5].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        
        public void PonerEscalera(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularEscalera(ld);
            if (numero != 0)
            {
                if (dg.Rows[6].ReadOnly == true)
                {
                    dg[2, 6].Value = BEtdp.PuntosEscalera;
                    dg.Rows[6].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 6].Value = numero;
                    dg.Rows[6].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerFull(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularFull(ld);
            if (numero != 0)
            {
                if (dg.Rows[7].ReadOnly == true)
                {
                    dg[2, 7].Value = BEtdp.PuntosFull;
                    dg.Rows[7].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 7].Value = numero;
                    dg.Rows[7].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerPoker(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularPoker(ld);
            if (numero != 0)
            {
                if (dg.Rows[8].ReadOnly == true)
                {
                    dg[2, 8].Value = BEtdp.PuntosPoker;
                    dg.Rows[8].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 8].Value = numero;
                    dg.Rows[8].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerGenerala(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, List<BE.BE_DADO> ld, DataGridView dg)
        {
            int numero = BLLtdp.CalcularGenerala(ld);
            if (numero != 0)
            {
                if (dg.Rows[9].ReadOnly == true)
                {
                    dg[2, 9].Value = BEtdp.PuntosGenerala;
                    dg.Rows[9].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dg[2, 9].Value = numero;
                    dg.Rows[9].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public void PonerSumaDePuntos(BLL_TABLADEPUNTAJES BLLtdp, BE.BE_TABLADEPUNTAJES BEtdp, DataGridView dg)
        {
            BLLtdp.CalcularSumaDePuntos(BEtdp);
            dg[2, 10].Value = BEtdp.PuntosTotales;
            dg.Rows[10].DefaultCellStyle.BackColor = Color.LightGreen;
        }
        #endregion

        #region Eventos
        private void checkBox_Dado1_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado1.Checked)
            {
                BECubilete.ListaDeDados.Add(BEJuego.ListaDeDados[0]);
                checkBox_Dado1.BackColor = Color.PaleGreen;
            }
            else
            {
                BECubilete.ListaDeDados.Remove(BEJuego.ListaDeDados[0]);
                checkBox_Dado1.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado2_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado2.Checked)
            {
                BECubilete.ListaDeDados.Add(BEJuego.ListaDeDados[1]);
                checkBox_Dado2.BackColor = Color.PaleGreen;
            }
            else
            {
                BECubilete.ListaDeDados.Remove(BEJuego.ListaDeDados[1]);
                checkBox_Dado2.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado3_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado3.Checked)
            {
                BECubilete.ListaDeDados.Add(BEJuego.ListaDeDados[2]);
                checkBox_Dado3.BackColor = Color.PaleGreen;
            }
            else
            {
                BECubilete.ListaDeDados.Remove(BEJuego.ListaDeDados[2]);
                checkBox_Dado3.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado4_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado4.Checked)
            {
                BECubilete.ListaDeDados.Add(BEJuego.ListaDeDados[3]);
                checkBox_Dado4.BackColor = Color.PaleGreen;
            }
            else
            {
                BECubilete.ListaDeDados.Remove(BEJuego.ListaDeDados[3]);
                checkBox_Dado4.BackColor = Color.Tomato;
            }
        }

        private void checkBox_Dado5_Click(object sender, EventArgs e)
        {
            if (checkBox_Dado5.Checked)
            {
                BECubilete.ListaDeDados.Add(BEJuego.ListaDeDados[4]);
                checkBox_Dado5.BackColor = Color.PaleGreen;
            }
            else
            {
                BECubilete.ListaDeDados.Remove(BEJuego.ListaDeDados[4]);
                checkBox_Dado5.BackColor = Color.Tomato;
            }
        }

        private void dataGridView_ABMPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BEPersonaTemp = dataGridView_ABMPersonas.CurrentRow.DataBoundItem as BE_PERSONA;
            textBox_Persona_Nom.Text = BEPersonaTemp.Nombre;
            textBox_Persona_Passw.Text = BEPersonaTemp.Password;
        }

        private void dataGridView_ABMPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BEPartidaTemp = dataGridView_ABMPartidas.CurrentRow.DataBoundItem as BE_PARTIDA;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBox_LogIn1.Enabled == false && groupBox_LogIn2.Enabled == false)
            {
                button_IniciarPartida.Enabled = true;
            }
        }
        #endregion
    }
}