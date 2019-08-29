using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            double area;
            Console.WriteLine("Ingrese opcion para calcular area: 1 cuadrado, 2 triangulo, 3 circulo: ");
            string aux = Console.ReadLine();
            int opcion;

            if (int.TryParse(aux, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        
                        Console.WriteLine("Ingrese lado en cm: ");
                        string ladoText = Console.ReadLine();
                        double ladoCuadrado;
                        if (double.TryParse(ladoText, out ladoCuadrado))
                        {
                            area = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                            Console.WriteLine("El area del cuadrado es: {0}", area);
                        }
                    break;

                    case 2:
                       
                        Console.WriteLine("Ingrese base del triangulo en cm: ");
                        string baseTriangulo = Console.ReadLine();
                        double baseT;

                        Console.WriteLine("Ingrese altura del triangulo en cm: ");
                        string alturaTriangulo = Console.ReadLine();
                        double altura;

                        if (double.TryParse(baseTriangulo, out baseT) && double.TryParse(alturaTriangulo, out altura))
                        {
                            area = CalculoDeArea.CalcularTriangulo(baseT, altura);
                            Console.WriteLine("El area del triangulo es: {0}", area);

                        }
                    break;

                    case 3:
                        
                        Console.WriteLine("Ingrese radio en cm: ");
                        string radio = Console.ReadLine();
                        double radioN;
                        if (double.TryParse(radio, out radioN))
                        {
                            area = CalculoDeArea.CalcularCirculo(radioN);
                            Console.WriteLine("El area del circulo es: {0}", area);
                        }
                    break;
                }
            }
        Console.ReadKey();
        }
       
    }
}
