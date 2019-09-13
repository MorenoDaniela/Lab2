using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deporte
{
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





    }
}
