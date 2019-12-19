using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class ReinoVegetal
    {
        public enum Gusto{ Dulce, Salado, Toxica }

        private static Random calcularValor;
        protected float valor;
        protected Gusto gusto;

        public ReinoVegetal(Gusto gusto): this(calcularValor.Next(1, 100), gusto)
        {
            //this.valor = ;
        }

        public ReinoVegetal(float valor, Gusto gusto)
        {
            this.valor = valor;
            this.gusto = gusto;
        }

        static ReinoVegetal()
        {
            calcularValor = new Random();
        }
        /// <summary>
        /// Muestra todos los datos genericos de reino vegetal
        /// </summary>
        /// <returns>devuelve un string conteniendo toda la informacion e la fruta</returns>
        public string MostrarDatos()
        {
            StringBuilder message = new StringBuilder();

            message.AppendFormat("\nVALOR: {0}\nGUSTO: {1}\n", this.valor, this.gusto);

            return message.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos(); 
        }

        public static bool operator ==(ReinoVegetal r1, ReinoVegetal r2)
        {
            if (r1 is Verdura)
            {
                if (r2 is Verdura)
                    return true;
            }
            else if (r1 is Fruta)
            {
                if (r2 is Fruta)
                    return true;
            }
            else if (r1 is Carnibora)
            {
                if (r2 is Carnibora)
                    return true;
            }

            return false;
        }

        public static bool operator !=(ReinoVegetal r1, ReinoVegetal r2)
        {
            return !(r1 == r2);
        }

    }
}
