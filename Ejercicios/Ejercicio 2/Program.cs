using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";


            Console.WriteLine("Ingrese un numero: ");
            string aux = Console.ReadLine();
            double numero;

            if (double.TryParse(aux,out numero) && numero!=0)
            {
                double cuadrado = Math.Pow(numero, 2);
                double cubo = Math.Pow(numero, 3);
                Console.WriteLine("El numero elevado al cuadrado es: {0} y al cubo: {1}", cuadrado, cubo);
            }
            else
            {
                Console.WriteLine("Error, reingrese numero.");
            }

            Console.ReadKey();
        }
    }
}
