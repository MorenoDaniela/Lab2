using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class ReinoVegetal
    {
        // Tipos del enumerado Dulce, Salado, Toxica

        private static Random calcularValor;
        protected float valor;
        protected Gusto gusto;

        public ReinoVegetal()
        {

        }
        static ReinoVegetal()
        {
            calcularValor = new Random();
        }
        public ReinoVegetal(Gusto gusto) : this(calcularValor.Next(1, 100), gusto)
        {
            
        }

        public ReinoVegetal(float valor, Gusto gusto) 
        {
            this.valor = valor;
            this.gusto = gusto;
        }

        public static bool operator ==(ReinoVegetal v1, ReinoVegetal v2)
        {
            bool retorno = false;

            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.gusto == v2.gusto && v1.Equals(v2))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(ReinoVegetal v1, ReinoVegetal v2)
        {
            return !(v1 == v2);
        }

        public enum Gusto
        {
            Dulce,
            Salado,
            Toxica
        }
    }

    
}
