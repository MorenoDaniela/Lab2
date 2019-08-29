using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            Console.WriteLine("Opcion 1 para convertir de decimal a binario, 2 para convertir de binario a decimal : ");
            string aux = Console.ReadLine();
            int opcion;

            string respuestaAux;
            double respuestaNum;

            if (int.TryParse(aux, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el numero: ");
                        respuestaAux = Console.ReadLine();
                        //
                        double.TryParse(respuestaAux, out respuestaNum);
                        respuestaAux = Conversor.DecimalBinario(respuestaNum);
                        Console.WriteLine("El numero binario es: {0}", respuestaAux);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el numero: ");
                        respuestaAux = Console.ReadLine();
                        //if (double.TryParse(respuestaAux, out respuestaNum))
                        //{
                            respuestaNum = Conversor.BinarioDecimal(respuestaAux);
                            Console.WriteLine("El numero decimal es: {0}", respuestaNum);
                        //}
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
