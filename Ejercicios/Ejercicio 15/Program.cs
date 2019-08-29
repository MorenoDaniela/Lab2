using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            int num1;
            int num2;
            char op;
            char seguir = 's';
            float resultado;

            do
            {
                Console.WriteLine("Ingrese 1er operando: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 12do operando: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese operacion: ");
                op = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(num1, num2, op);

                Console.WriteLine("El resultado es: {0}", resultado);

                Console.WriteLine("Desea seguir operando? S o N");
                seguir = char.Parse(Console.ReadLine());

            } while (seguir == 's' || seguir == 'S');

            Console.ReadKey();
        }
    }
}
