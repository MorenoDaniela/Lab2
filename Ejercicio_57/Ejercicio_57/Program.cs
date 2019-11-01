using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Daniela", "Moreno");
            Persona pp = new Persona();
            try
            {
                Persona.Guardar(p);
            }catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                pp = Persona.Leer(AppDomain.CurrentDomain.BaseDirectory + "prueba.xml");
                Console.WriteLine(pp.ToString());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            Console.ReadKey();

        }
    }
}
