using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero: 1";
          
            Console.WriteLine("Ingrese un numero: ");
            string aux1 = Console.ReadLine();
            //intTryParse(aux1, out a) ;
            int A = int.Parse(aux1);

            Console.WriteLine("Ingrese un numero: ");
            string aux2 = Console.ReadLine();
            //intTryParse(aux1, out a) ;
            int B = int.Parse(aux2);

            Console.WriteLine("Ingrese un numero: ");
            string aux3 = Console.ReadLine();
            //intTryParse(aux1, out a) ;
            int C = int.Parse(aux3);

            Console.WriteLine("Ingrese un numero: ");
            string aux4 = Console.ReadLine();
            //intTryParse(aux1, out a) ;
            int D = int.Parse(aux4);

            Console.WriteLine("Ingrese un numero: ");
            string aux5 = Console.ReadLine();
            //intTryParse(aux1, out a) ;
            int E= int.Parse(aux5);


            int valorMax=int.MinValue;//0
            int valorMin=int.MaxValue;//100
            int acumulador;
            float promedio;

            acumulador = A + B + C + D + E;
            promedio = (float)acumulador / 5;


            
            if (A>valorMax)
            {
                valorMax = A;
                if (B > valorMax)
                {
                    valorMax = B;
                    if (C > valorMax)
                    {
                        valorMax = C;
                        if (D > valorMax)
                        {
                            valorMax = D;
                            if (E > valorMax)
                            {
                                valorMax = E;

                            }
                        }

                    }
                }

            }

            if ( A < valorMin)
            {
                valorMin = A;
                if (B < valorMin)
                {
                    valorMin = B;
                    if (C < valorMin)
                    {
                        valorMin = C;
                        if (D < valorMin)
                        {
                            valorMin = D;
                            if (valorMin < E)
                            {
                                valorMin = E;
                            }
                        }
                    }
                }
            }
            
            
             
            

            Console.WriteLine("Promedio: {0} ", promedio);
            Console.WriteLine("Valor Maximo: {0} ", valorMax);
            Console.WriteLine("Valor minimo: {0} ", valorMin);


            Console.ReadKey();
        }
    }
}
