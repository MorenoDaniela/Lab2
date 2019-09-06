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
            Dolar d = new Dolar(100);
            Peso p = new Peso(90);
            Euro e = new Euro(5);
            
            Dolar resultado = d + p;
            Euro res = e+p;
            Console.WriteLine("DOLAR RESULT {0}", resultado.GetCantidad());
            Console.WriteLine("EURO RESULT {0}", res.GetCantidad());
            Console.ReadKey();
        }
    }
}
