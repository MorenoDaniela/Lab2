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
            Console.Title = "Ejercicio Nro 2";

            Console.WriteLine("Ingrese un numero:");
            string aux = Console.ReadLine();
            double numero;

            

            if (double.TryParse(aux, out numero))
            {
               double elevado =  Math.Pow(numero,2);
                double elevado2 = Math.Pow(numero, 3);

                Console.WriteLine("El numero elevado al cuadrado es: {0} y al cubo: {1}", elevado,elevado2);
            }

            if (numero<=0)
            {
                Console.WriteLine("Error, el numero ingresado no puede ser 0.");
            }

            Console.ReadKey();
        }
    }
}
