using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";


            int numero;
            int i;
            int valorMin = int.MaxValue;//100
            int valorMax = int.MinValue;//0
            int acumulador = 0;
            float promedio = 0;

            for (i=0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100.");
                string aux = Console.ReadLine();

                if (int.TryParse(aux, out numero))
                {
                    if (Validacion.Validar(numero,-100,100))
                    {
                        acumulador = acumulador + numero;
                        if (numero<valorMin)
                        {
                            valorMin = numero;
                        }

                        if (numero>valorMax)
                        {
                            valorMax = numero;
                        }
                    }
                }
            }

            promedio = acumulador / 10;

            Console.WriteLine("El promedio es {0} el valor minimo {1} y el maximo {2}", promedio, valorMin, valorMax);

            Console.ReadKey();
            

        }
    }
}
