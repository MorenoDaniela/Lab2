using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        int cantidadSumas;

        public Sumador (int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
        {
            new Sumador(0);

        }

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
    }
}
