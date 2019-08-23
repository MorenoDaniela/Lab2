using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            string aux = Console.ReadLine();
            int numero;

            int i;

            if (int.TryParse(aux, out numero))
            {
                for (int j=2;j<=numero;j++)
                {
                    for (i=2;i<j;i++)
                    {
                        if (j%i==0)
                        {
                            break;
                        }
                    }

                    if (i==j)
                    {
                        Console.WriteLine("Primo: {0}", j);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
