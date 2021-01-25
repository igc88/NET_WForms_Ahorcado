using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TresEnRayas
{
    public partial class Form1 : Form
    {
        int Turno = 1;
        int[,] Tablero;
        bool Ganador;
        bool Jugando = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarJuego()
        {
            j1Nombre.Enabled = false;
            j2Nombre.Enabled = false;
            j2Humano.Enabled = false;
            j2Cpu.Enabled = false;
            lblTurno.Visible = true;
            label1.Visible = true;
            lblTurno.Text = j1Nombre.Text;
            button1.Text = "Cancelar partida";
            //Inicio
            Turno = 1;
            Tablero = new int[3, 3];
            Ganador = false;
            ControlTablero.Controls.Clear();

            //Bucle
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox
                    {
                        Image = Properties.Resources.f_0,
                        Name = string.Format("{0}", i + "_" + j),
                        Dock = DockStyle.Fill,
                        Cursor = Cursors.Hand,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    FichaJuego.Click += Jugar;
                    ControlTablero.Controls.Add(FichaJuego, j, i);
                    Tablero[i, j] = 0;

                }
            }

            Jugando = true;

        }

        public void FinalizarJuego()
        {
            j1Nombre.Enabled = true;
            j2Nombre.Enabled = true;
            j2Humano.Enabled = true;
            j2Cpu.Enabled = true;
            button1.Text = "Iniciar partida";
            Jugando = false;
            foreach(PictureBox p in ControlTablero.Controls)
            {
                p.Click -= Jugar;
                p.Cursor = Cursors.Default;
            }
            lblTurno.Visible = false;
            label1.Visible = false;
        }

        private void Jugar(object sender, EventArgs e)
        {
            var FichaSeleccionada = (PictureBox)sender;
            FichaSeleccionada.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"f_{Turno}");
            FichaSeleccionada.Click -= Jugar;
            FichaSeleccionada.Cursor = Cursors.Default;
            string[] Posicion = FichaSeleccionada.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            Tablero[Fila, Columna] = Turno;
            VerificarJuego(Fila, Columna);
            Turno = (Turno == 1) ? 2 : 1;
            if (Turno == 1) lblTurno.Text = j1Nombre.Text;
            else lblTurno.Text = j2Nombre.Text;
            if (Turno == 2 && j2Cpu.Checked && Jugando) JugarCpu();
        }

        private void JugarCpu()
        {
            Random r = new Random();
            int fila, columna = 0;
            do
            {
                fila = r.Next(0, Tablero.GetLength(0));
                columna = r.Next(0, Tablero.GetLength(1));
            } while (Tablero[fila, columna] != 0);
            Jugar(ControlTablero.GetControlFromPosition(columna, fila), EventArgs.Empty);
        }

        public void VerificarJuego(int Fila, int Columna)
        {
            //contadores
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamanoTablero = 3;

            for (int i = 0; i < TamanoTablero; i++)
            {
                for (int j = 0; j < TamanoTablero; j++)
                {
                    if (i == Fila)
                    {
                        if (Tablero[i, j] == Turno)
                        {
                            GanoFilas++;
                        }
                    }
                    if (j == Columna)
                    {
                        if (Tablero[i, j] == Turno)
                        {
                            GanoColumnas++;
                        }
                    }
                    // diagonal principal
                    if (i == j) 
                    {
                        if (Tablero[i, j] == Turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }

                    //diagonal inversa
                    if ((i+j) == (TamanoTablero - 1))
                    {
                        if (Tablero[i, j] == Turno)
                        {
                            DiagonalInversa++;
                        }
                    }

                }
            }

            if ((GanoFilas == TamanoTablero) || (GanoColumnas == TamanoTablero) || (DiagonalPrincipal == TamanoTablero) || (DiagonalInversa == TamanoTablero))
            {
                Ganador = true;
            }
            object f_0 = Properties.Resources.ResourceManager.GetObject("f_0");
            if (Ganador)
            {
                picGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject($"f_{Turno}");
                if (Turno == 1)
                {
                    MessageBox.Show("Ya hay ganador: Jugador 1");
                }
                else
                {
                    MessageBox.Show("Ya hay ganador: Jugador 2");
                }
                FinalizarJuego();
                Jugando = false;
            } else if (!Tablero.Cast<int>().Any(x => x == 0))
            {
                MessageBox.Show("No hay ganador");
                FinalizarJuego();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Jugando) IniciarJuego();
            else FinalizarJuego();
        }

    }
}
