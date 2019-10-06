using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base (patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHor)
            : this (patente,modelo)
        {
            valorHora = valorHor;
        }

        public override string ConsultarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.ToString());
            cadena.AppendFormat("Modelo: {0} Valor hora: {1}", this.modelo, valorHora);
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
                if (ob is PickUp)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

    }
}
