using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            string nombre;
            int cantHora;
            int anio;

            Console.WriteLine("Ingrese nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese valor por hora:");
            string horaText = Console.ReadLine();

            Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
            string cantHorasText = Console.ReadLine();

            Console.WriteLine("Ingrese cantidad de años trabajados: ");
            string aniosText = Console.ReadLine();

            if (int.TryParse(horaText,out hora) &&
                int.TryParse(cantHorasText,out cantHora) &&
                int.TryParse(aniosText, out anios))
            {

            }

        }
    }
}
