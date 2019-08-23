using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            string aux = Console.ReadLine();
            int numero;
            int i;
            int j;

            if (int.TryParse(aux,out numero))
            {
                for (i=1;i<numero;i++)
                {
                    for (j=1;j<numero;j++)
                    {
                        
                    }
                }
            }
        }
    }
}
