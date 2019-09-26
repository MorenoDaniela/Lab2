using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;

namespace Ejercicio_31_Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(12, "daniel");
            Negocio negocio = new Negocio("Carlitos");
            if (negocio + cliente)
            {
                Console.WriteLine("Si se pudo");
            }
            else
                Console.WriteLine("no se pudo");

            Console.ReadKey();
        }


    }
}
