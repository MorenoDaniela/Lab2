﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";

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

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0}", aux);
                    for (i = 1; i < cantPisos; i++)
                    {
                        aux = "**" + aux;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("{0}", aux);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
