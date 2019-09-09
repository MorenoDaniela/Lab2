using Billetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar d = new Dolar(1);
            Peso p = new Peso(100);
            Euro e = new Euro(5);

            Peso res2 = p + d;
            Dolar resultado = d + p;
            Euro res = e+p;
            Console.WriteLine("DOLAR RESULT {0}", resultado.GetCantidad());
            Console.WriteLine("EURO RESULT {0}", res.GetCantidad());
            Console.WriteLine("PESO RESULT {0}", res2.GetCantidad());
            Console.ReadKey();
        }
    }
}
