using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            Boligrafo boli1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boli2 = new Boligrafo(10, ConsoleColor.Red);
            string aux = "";
            boli2.Pintar(7, out aux);
            Console.WriteLine(aux);

            Console.ReadKey();
        }
    }
}
