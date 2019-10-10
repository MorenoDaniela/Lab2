using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace practica
{
    class Program
    {
        static void Main(string[] args)

        {
            SistemaSolar sistema = new SistemaSolar();
            SistemaSolar sistema2 = new SistemaSolar();

            Planeta planet = new Planeta(22, 10, "Tierra",7,ETipo.Gaseoso);
            Planeta p2 = new Planeta(100, 10, "Saturno", 8, ETipo.Rocoso);
            Satelite s1 = new Satelite(4, 1, "Anillos");
            Satelite s2 = new Satelite(6, 2, "Tito");
            Satelite satelit = new Satelite(1, 2, "Luna");
            Satelite sat = new Satelite(2, 1, "Sol");
            sistema.Planetas.Add(planet);
            sistema2.Planetas.Add(p2);

            if (planet + satelit && planet + sat && p2 + s1 && p2 + s2)
            {
                Console.WriteLine(sistema.MostrarInformacionAstros());
                Console.WriteLine(sistema2.MostrarInformacionAstros());
                //Console.WriteLine(planet.ToString());

            }
            
                

            Console.ReadKey();
        }
    }
}
