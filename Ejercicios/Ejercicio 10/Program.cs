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
            Console.Title = "Ejercicio 10";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese cantidad de pisos de la piramide: ");
            string pisos = Console.ReadLine();
            int cantPisos;

            if (int.TryParse(pisos, out cantPisos))
            {
                if (cantPisos >= 1)
                {
                    int i;
                    string aux = "*";
                    //aux  = CentrarCadena.PadAmbos(aux, cantPisos);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(CentrarCadena.PadAmbos(aux,cantPisos*2));
                    for (i = 1; i < cantPisos; i++)
                    {
                        aux = "**" + aux;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //aux =  CentrarCadena.PadAmbos(aux, cantPisos);
                        Console.WriteLine(CentrarCadena.PadAmbos(aux,cantPisos*2));
                    }
                }
            }

            Console.ReadKey();









            /*
            int i;
            int espacios = 21;
            int inicio = 2;

            string cadena = "                    *********";
            Console.WriteLine("", cadena);
            for (i=1;i<6;i++)
            {
                int numero;
                numero = inicio+2;
                int largo= espacios+2;
                string resultado = cadena.Substring(numero, largo);
                //resultado = resultado + "**";
                Console.WriteLine("", resultado);
            }

            Console.ReadKey();
            */

        }
    }
}
