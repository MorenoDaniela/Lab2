using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto nuevo = new Producto("Sony", "012", 15);
            Producto viejo = new Producto("DELL", "012", 50);
             if (nuevo==viejo)
            {
                Console.WriteLine("Funciona");
            }else
                Console.WriteLine("NO Funciona");
            Console.ReadKey();
        }
    }
    //Object.ReferenceEquals(p1,p2);// para comparar un objeto y saber si es nulo. en p2 deberia poner null
    //p1 is null// devuelve booleano sirve para lo mismo
}
