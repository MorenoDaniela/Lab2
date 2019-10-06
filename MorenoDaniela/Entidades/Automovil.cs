using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        static Automovil()
        {
            valorHora=50;
        }
        
        public Automovil (string patente, ConsoleColor color)
            : base (patente)
        {
            this.color = color;
        }

        public Automovil (string patente, ConsoleColor color, int valorHor)
            : this(patente,color)
        {
            valorHora = valorHor;
        }

        public override string ConsultarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.ToString());
            cadena.AppendFormat("Color: {0} Valor hora: {1}", this.color, valorHora);
            return cadena.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder cadena = new StringBuilder();
            DateTime dia = DateTime.Now;
            TimeSpan aux = this.ingreso.Subtract(dia);
            cadena.AppendLine(base.ImprimirTicket());
            float auxiliar = (float)aux.TotalHours * valorHora;
            cadena.AppendFormat("Costo de estadia: {0} \n", auxiliar);
            return cadena.ToString();
        }

        public override bool Equals(Object ob)
        {
            bool retorno = false;

            if (!(ob is null))
            {
                if (ob is Automovil)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


    }
}
