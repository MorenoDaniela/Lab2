using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int espacios = 21;
            int inicio = 2;

            string cadena = "                    *********";
            Console.WriteLine("", cadena);
            for (i=1;i<6;i++)
            {
                string resultado = cadena.Substring(inicio+2, espacios+2);
                resultado = resultado + "**";
                Console.WriteLine("", resultado);
            }

            Console.ReadKey();
            
        }
    }
}
