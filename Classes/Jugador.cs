using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_TresEnRaya.Classes {
    class Jugador {
        private string _nombre;
        private TipoJugador _tipo;
        private int _puntos;
        private int _casillasOcupadas;
        public string Nombre {
            get => _nombre;
            set { _nombre = value; }
        }
        public TipoJugador Tipo {
            get => _tipo;
            set { _tipo = value; }
        }
        public int Puntos {
            get => _puntos;
            set { _puntos = value; }
        }
        public int CasillasOcupadas {
            get => _casillasOcupadas;
            set { _casillasOcupadas = value; }
        }
        public Jugador (string nombre, TipoJugador tipo) {
            Nombre = nombre;
            Tipo = tipo;
            Puntos = 0;
            CasillasOcupadas = 0;
        }
    }
}
