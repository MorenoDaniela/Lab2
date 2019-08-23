using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese año de inicio: ");
            string inicio = Console.ReadLine();
            int init;

            Console.WriteLine("Ingrese año de fin: ");
            string fin = Console.ReadLine();
            int end;

            if (int.TryParse(inicio, out init) && int.TryParse(fin, out end))
            {
                for (;init<=end;init++)
                {
                    if ((init%4==0) || (init%400==0))
                    {
                        Console.WriteLine("Bisiesto: {0}", init);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
