using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometria.Punto punto1 = new Geometria.Punto();
            Geometria.Punto punto3 = new Geometria.Punto();
            punto1.UnPunto(1, 1);
            punto3.UnPunto(5, 5);

            Geometria.Rectangulo prueba = new Geometria.Rectangulo();
            prueba.UnRectangulo(punto1, punto3);

            Console.WriteLine("Area {0}", prueba.Area());
            Console.WriteLine("Perimetro {0}", prueba.Perimetro());

            Console.ReadKey();
        }
    }
}


