using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carnibora : ReinoVegetal, IVegetales
    {
        public enum Captura { Pinzas, Pelos, Caída, Mecánicas, Combinada }

        private Captura tipo;
        private int tamanio;
        
        public Carnibora(float valor, Gusto gusto, Captura tipo)
            :base(valor, gusto)
        {
            this.tipo = tipo;
        }

        public Carnibora(float valor, Gusto gusto, Captura tipo, int tamanio)
            : this(valor, gusto, tipo)
        {
            this.tamanio = tamanio;
        }
        
        public Captura Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }


        /// <summary>
        /// Mue
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder message = new StringBuilder();

            message.Append(base.ToString());
            message.AppendFormat("TIPO: {0}\nTAMANIO: {1}\n", this.Tipo, this.Tamanio);

            return message.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
