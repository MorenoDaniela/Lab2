using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Sumador;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 10;
            long b = 20;
            //string uno = "hola";
            //string dos = "Daniela";

            
            Sumador resultado = new Sumador();
            //Sumador cadena = new Sumador();

            resultado.Sumar(a, b);
            //cadena.Sumar(uno, dos);

            Console.WriteLine("{0}", resultado);
            //Console.WriteLine("Suma num: {0} Concatena {1}", resultado, cadena);

            Console.ReadKey();
        }
    }
}
