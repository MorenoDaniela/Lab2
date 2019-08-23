using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1000;
            int i;
            int cantidad = 0;
            int perfecto = 0;

            while (cantidad <= 4)
            {
                for (i = 1; i < numero; i++)
                {
                    int resultado = numero % i;

                    if (resultado == 0)
                    {
                        perfecto = perfecto + i;
                        cantidad++;
                        if (perfecto == i)
                        {
                            Console.WriteLine("Perfecto: {0}", i);
                        }
                    }


                }
            }
            Console.ReadKey();
        }
    }
}
