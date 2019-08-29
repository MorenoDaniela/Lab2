using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alum1 = new Alumno("Daniela","Moreno",1);
            Alumno alum2 = new Alumno("Pepe", "Grillo", 2);
            Alumno alum3 = new Alumno("Roma", "Ibañez", 3);

            alum1.Estudiar(8, 6);
            alum2.Estudiar(2, 1);
            alum3.Estudiar(10, 9);

            alum1.CalcularFinal();
            alum2.CalcularFinal();
            alum3.CalcularFinal();

            alum1.Mostrar();
            alum2.Mostrar();
            alum3.Mostrar();

            Console.ReadKey();
        }
    }
}
