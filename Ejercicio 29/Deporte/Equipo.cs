using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deporte
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        public Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad,string nombre)
            : this ()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            if (!(e is null) && !(j is null))
            {
                if (e.jugadores.Count < e.cantidadDeJugadores)
                {
                    e.jugadores.Add(j);
                    retorno = true;
                }          
            }
            return retorno;
        }
    }
}
