﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta = 'S';
            while (respuesta == 'S')
            {
                int acumulador = 0;
                Console.WriteLine("Ingrese un numero: ");
                string aux = Console.ReadLine();
                int numero;

                Console.WriteLine("Desea continuar? S o N");
                //respuesta = Console.ReadLine();

               // Console.ReadKey();
                ConsoleKeyInfo j = Console.ReadKey();
                respuesta = j.KeyChar;

                ValidarRespuesta.ValidaS_N(respuesta);

                if (int.TryParse(aux, out numero))
                {
                    acumulador = acumulador + numero;
                }
            }
            Console.ReadKey();
        }
    }
}
