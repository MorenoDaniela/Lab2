using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador (int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }
       

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar (string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static long operator +(Sumador sum1, Sumador sum2)
        {
            return sum1.cantidadSumas + sum2.cantidadSumas;
        }

        public static bool operator |(Sumador sum1, Sumador sum2)
        {
            bool retorno = false;

            if (sum1.cantidadSumas==sum2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
