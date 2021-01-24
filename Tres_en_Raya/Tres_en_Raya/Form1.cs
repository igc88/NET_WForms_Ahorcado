using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Tres_en_Raya
{
    public partial class Form1 : Form
    {
        static string X = "X";
        static string O = "O";

        bool pulsado = true;
        int contador = 0;
        bool contraCPU = false;

        public Form1()
        {
            InitializeComponent();
        }

        //  QUE HACER AL PULSAR BOTON
        private void press(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (pulsado)            
                b.Text = X;
            else
                b.Text = O;

                pulsado = !pulsado;
            b.Enabled = false;
            contador++;

            winner();

            //  JUEGA LA CPU
            if ((!pulsado) && (contraCPU))
                cpuMueveAsync();
        }

        //  DAMOS INDICACIONES A LA CPU PARA HACER MOVIMIENTOS        
        private async Task cpuMueveAsync()
        {
            Button mueve = null;
            mueve = ganaObloquea(X);
            if (mueve == null)
            {
                mueve = ganaObloquea(X);
                if (mueve == null)
                {
                    mueve = buscaEsquina();
                    if (mueve == null)
                    {
                        mueve = buscaEspacio();
                    }
                }
            }
            try
            {
                mueve.PerformClick();
            }
            catch { }
        }
        private Button ganaObloquea(string a)
        {
            //  COMBINACIONES HORIZONTALES
            // PRIMERA FILA
            if ((button1.Text == a) && (button2.Text == a) && (button3.Text == ""))
                return button3;
            if ((button2.Text == a) && (button3.Text == a) && (button1.Text == ""))
                return button1;
            if ((button1.Text == a) && (button3.Text == a) && (button2.Text == ""))
                return button2;
            // SEGUNDA FILA
            if ((button4.Text == a) && (button5.Text == a) && (button6.Text == ""))
                return button6;
            if ((button5.Text == a) && (button6.Text == a) && (button4.Text == ""))
                return button4;
            if ((button4.Text == a) && (button6.Text == a) && (button5.Text == ""))
                return button5;
            // TERCERA FILA
            if ((button7.Text == a) && (button8.Text == a) && (button9.Text == ""))
                return button9;
            if ((button8.Text == a) && (button9.Text == a) && (button7.Text == ""))
                return button7;
            if ((button7.Text == a) && (button9.Text == a) && (button8.Text == ""))
                return button8;

            //  COMBINACIONES VERTICALES
            // PRIMERA COLUMNA
            if ((button1.Text == a) && (button4.Text == a) && (button7.Text == ""))
                return button7;
            if ((button4.Text == a) && (button7.Text == a) && (button1.Text == ""))
                return button1;
            if ((button1.Text == a) && (button7.Text == a) && (button4.Text == ""))
                return button4;
            // SEGUNDA COLUMNA
            if ((button2.Text == a) && (button5.Text == a) && (button8.Text == ""))
                return button8;
            if ((button5.Text == a) && (button8.Text == a) && (button2.Text == ""))
                return button2;
            if ((button2.Text == a) && (button8.Text == a) && (button5.Text == ""))
                return button5;
            // TERCERA COLUMNA
            if ((button3.Text == a) && (button6.Text == a) && (button9.Text == ""))
                return button9;
            if ((button6.Text == a) && (button9.Text == a) && (button3.Text == ""))
                return button3;
            if ((button3.Text == a) && (button9.Text == a) && (button6.Text == ""))
                return button6;

            //  COMBINACIONES DIAGONALES
            if ((button1.Text == a) && (button5.Text == a) && (button9.Text == ""))
                return button9;
            if ((button5.Text == a) && (button9.Text == a) && (button1.Text == ""))
                return button1;
            if ((button1.Text == a) && (button9.Text == a) && (button5.Text == ""))
                return button5;

            if ((button7.Text == a) && (button5.Text == a) && (button3.Text == ""))
                return button3;
            if ((button5.Text == a) && (button3.Text == a) && (button7.Text == ""))
                return button7;
            if ((button7.Text == a) && (button3.Text == a) && (button5.Text == ""))
                return button5;

            return null;
        }
        private Button buscaEsquina()
        {

            if (button1.Text == O)
            {
                if (button3.Text == "")
                    return button3;
                if (button9.Text == "")
                    return button9;
                if (button7.Text == "")
                    return button7;
            }
            if (button3.Text == O)
            {
                if (button1.Text == "")
                    return button1;
                if (button9.Text == "")
                    return button9;
                if (button7.Text == "")
                    return button7;
            }
            if (button9.Text == O)
            {
                if (button1.Text == "")
                    return button3;
                if (button3.Text == "")
                    return button3;
                if (button7.Text == "")
                    return button7;
            }
            if (button7.Text == O)
            {
                if (button1.Text == "")
                    return button3;
                if (button3.Text == "")
                    return button3;
                if (button9.Text == "")
                    return button9;
            }
            if (button1.Text == "")
                return button1;
            if (button3.Text == "")
                return button3;
            if (button7.Text == "")
                return button7;
            if (button9.Text == "")
                return button9;

            return null;
        }
        private Button buscaEspacio()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        //  SELECCIONAR GANADOR
        private void winner()
        {
            bool ganador = false;
            //  COMBINACIONES DE IZQ A DER
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                ganador = true;
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                ganador = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                ganador = true;

            //  COMBINACIONES DE ARRIBA A ABAJO
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                ganador = true;
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                ganador = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                ganador = true;

            //  COMBINACIONES DIAGONALES
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                ganador = true;
            if ((button7.Text == button5.Text) && (button5.Text == button3.Text) && (!button7.Enabled))
                ganador = true;


            if (ganador)
            {
                disableButtons();              
                string win = "";
                if (pulsado)
                {
                    win = nombreJ2.Text;
                }
                else
                {
                    win = nombreJ1.Text;
                }
                MessageBox.Show(win + " es el ganador");
            }

        }

        //  BLOQUEO DE TECLAS 
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
           
        }

        //  NUEVA PARTIDA
        private void newgame_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        //  MUESTRA CURSOR EN BOTON Y NOMBRE DE QUIEN LE TOCA
        private void bEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (pulsado)
                {
                    b.Text = X;
                    label2.Text = nombreJ1.Text;
                }
                else
                {
                    b.Text = O;
                    label2.Text = nombreJ2.Text;
                }
            }
        }
       private void bLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        } 

        //  SELECCIONAR JUGAR CONTRA CPU
        private void cpu(object sender, EventArgs e)
        {
            if (cpuJ2.Checked)
            {
                contraCPU = true;
                nombreJ2.Text = "Maquina";
            }
            else contraCPU = false;
        }

    }
}
