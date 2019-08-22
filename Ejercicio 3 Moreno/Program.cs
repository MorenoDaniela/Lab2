using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Moreno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3" ;

            Console.WriteLine("Ingrese un numero: ");
            string aux = Console.ReadLine();
            int numero;

            if (int.TryParse(aux,out numero))
            {
                int i=0;

                for (int j=2; j<=numero; j++)
                {
                    for (i=2; i<j; i++)
                }
                
            }

            Console.ReadKey();
        }

    }
}
