using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        static int valorHora;

        
        static Moto()
        {
            valorHora = 30;
            //Moto.valorHora = 30;
        }
        public Moto(string patente, int cilindrada)
           : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto (string patente, int cilindrada, short ruedas)
            : this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto (string patente, int cilindrada, short ruedas,int valorHor)
            : this (patente,cilindrada,ruedas)
        {
            valorHora = valorHor;
        }

        public override string ConsultarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.ToString());
            cadena.AppendFormat("Cilindrada: {0} Ruedas: {1} Valor hora: {2}", this.cilindrada, this.ruedas, valorHora);
            return cadena.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder cadena = new StringBuilder();
            DateTime dia = DateTime.Now;
            DateTime ing = this.ingreso;
            TimeSpan aux = ing.Subtract(dia);
            cadena.AppendLine(base.ImprimirTicket());
            float auxiliar = (float)aux.TotalHours * valorHora;
            cadena.AppendFormat("Costo de estadia: {0} \n", auxiliar);
            return cadena.ToString();
        }

        public override bool Equals (Object ob)
        {
            bool retorno = false;

            if (!(ob is null))
            {
                if (ob is Moto)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


    }
}
