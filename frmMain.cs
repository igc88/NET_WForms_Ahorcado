using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Net_TresEnRaya.Classes;

namespace Net_TresEnRaya {
    public partial class frmMain : Form {
        private int turno;
        private int[,] tablero;
        private Jugador[] jugadores { get; set; }
        private Jugador jActivo;

        public frmMain() {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e) {
            NuevaPartida();
        }
        private void NuevaPartida() {
            // Inicializar variables partida
            turno = 1;
            tablero = new int[3, 3];

            // Inicializar jugadores
            jugadores = new Jugador[2] {
                new Jugador(txtNombreJ1.Text, rbHumano1.Checked ? TipoJugador.Humano : TipoJugador.CPU),
                new Jugador(txtNombreJ2.Text, rbHumano2.Checked ? TipoJugador.Humano : TipoJugador.CPU)
            };

            GestionTurno(true);
        }
        private void Jugar(object sender, EventArgs e) {
            if (turno == 0) return;

            Label Casilla = (Label)(sender);

            PintarCasilla(Casilla);
        }
        private void ComprobarTablero(int fila, int columna) {
            int numFichasHorizontal = 0;
            int numFichasVertical = 0;
            int numFichasDiagonal = 0;
            int numFichasDiagonalInversa = 0;

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (i == fila) {
                        if (tablero[i, j] == turno) {
                            numFichasHorizontal++;
                        }
                    }

                    if (j == columna) {
                        if (tablero[i, j] == turno) {
                            numFichasVertical++;
                        }
                    }

                    if (i == j) {
                        if (tablero[i, j] == turno) {
                            numFichasDiagonal++;
                        }
                    }

                    if ((i + j) == 2) {
                        if (tablero[i, j] == turno) {
                            numFichasDiagonalInversa++;
                        }
                    }
                }
            }

            if (numFichasHorizontal == 3 || numFichasVertical == 3 || numFichasDiagonal == 3 || numFichasDiagonalInversa == 3) {
                MessageBox.Show("Gana " + jActivo.Nombre);

                Application.Restart();
            }
        }

        private void GestionTurno(bool primerTurno = false) {
            if (!primerTurno) {
                turno = turno == 1 ? 2 : 1;
            }

            jActivo = jugadores[turno - 1];

            lblMensaje.Text = "Turno " + jActivo.Nombre;

            if (jActivo.Tipo == TipoJugador.CPU) {
                JugarCPU();
            }
        }
        private void JugarCPU() {
            Random rnd = new Random();

            Label Casilla = null;

            if (jActivo.CasillasOcupadas < 3) {
                do {
                    int fila = rnd.Next(3);
                    int columna = rnd.Next(3);

                    Casilla = (Label)panelTablero.GetControlFromPosition(columna, fila);
                } while (Casilla.Text != string.Empty);

                PintarCasilla(Casilla);
            } else {
                do {
                    int fila = rnd.Next(3);
                    int columna = rnd.Next(3);

                    Casilla = (Label)panelTablero.GetControlFromPosition(columna, fila);
                } while (Casilla.Text != ((turno == 1) ? "X" : "O"));

                PintarCasilla(Casilla);
            }
        }
        private void PintarCasilla(Label Casilla) {
            int fila = panelTablero.GetCellPosition(Casilla).Row;
            int columna = panelTablero.GetCellPosition(Casilla).Column;

            if (jActivo.CasillasOcupadas < 3) {
                if (Casilla.Text == string.Empty) {
                    if (turno == 1) {
                        Casilla.Text = "X";
                        jActivo.CasillasOcupadas++;
                    } else {
                        Casilla.Text = "O";
                        jActivo.CasillasOcupadas++;
                    }

                    tablero[fila, columna] = turno;

                    ComprobarTablero(fila, columna);
                    GestionTurno();
                } else {
                    return;
                }
            } else {
                if (Casilla.Text == string.Empty) {
                    return;
                } else {
                    if (turno == 1) {
                        if (Casilla.Text == "X") {
                            Casilla.Text = string.Empty;
                            jActivo.CasillasOcupadas--;
                        }
                    } else {
                        if (Casilla.Text == "O") {
                            Casilla.Text = string.Empty;
                            jActivo.CasillasOcupadas--;
                        }
                    }

                    tablero[fila, columna] = 0;

                    if (jActivo.Tipo == TipoJugador.CPU) {
                        JugarCPU();
                    }
                }
            }
        }
    }
}

