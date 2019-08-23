using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int valorMax = int.MinValue;//0
            int valorMin = int.MaxValue;//100
            int acumulador = 0;
            int promedio;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string aux = Console.ReadLine();
                int numero;

                if (int.TryParse(aux, out numero))
                {
                    if (numero>valorMax)
                    {
                        valorMax = numero;
                    }

                    if (numero<valorMin)
                    {
                        valorMin = numero;
                    }
                    acumulador = acumulador + numero;
                }else
                {
                    i--;
                }
            }

            promedio = acumulador / i;

            Console.WriteLine("Valor maximo= {0} Valor minimo= {1} Promedio= {2} .", valorMax, valorMin, promedio);
            Console.ReadKey();

        }
    }
}
