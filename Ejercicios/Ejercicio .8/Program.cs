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
            Console.Title = "Ejercicio 8";

            int hora;
            string nombre;
            int cantHora;
            int anio;
            double total;
            double descuento;
            double final;

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
                int.TryParse(aniosText, out anio))
            {
                total = (hora * cantHora) + (anio * 150);
                descuento = (total * 0.13);
                final = total - descuento;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nombre: {0} \n Antiguedad: {1} \nValor hora: {2} \n" +
                    "Total bruto: {3:N4}\nTotal descuento: {4:N4} \n Total neto: {5:N4}", nombre, anio, hora, total, descuento, final);
            }
            Console.ReadKey();
        }
    }
}
