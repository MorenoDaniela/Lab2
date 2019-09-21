using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deporte
{
#pragma warning disable CS0660, CS0661//desacctivar warnings

    public class Jugador
    {
        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int partidosJugados;

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                partidosJugados = value;
            }
        }

        private float promedioGoles;

        public float PromedioGoles
        {
            get { return promedioGoles; }//solo lectura
                                         // set { promedioGoles = value; }//este lo borro este
        }

        private int totalGoles;

        public int TotalGoles
        {
            get { return totalGoles; }
            set { totalGoles = value; }
        }

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            return totalGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Nombre: " + Nombre);
            cadena.AppendLine("Total goles " + TotalGoles);
            cadena.AppendLine("Dni: " + Dni);
            cadena.AppendLine("Partidos jugados: " + PartidosJugados);
            cadena.AppendLine("Promedio goles: " + GetPromedioGoles());
            return cadena.ToString();

        }

        public static bool operator ==(Jugador player1, Jugador player2)
        {
            bool retorno = false;
            if (player1.dni == player2.dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Jugador player1, Jugador player2)
        {
            bool retorno = true;

            if (player1==player2)
            {
                retorno = false;
            }
            return retorno;
        }



    }
}
