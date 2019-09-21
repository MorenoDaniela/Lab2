using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deporte;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador player1 = new Jugador(12345, "Pepe",5,2);
            Jugador player2 = new Jugador(11111, "Coco",10,3);
            Jugador player3 = new Jugador(22222, "Lulu",4,5);
            Jugador player4 = new Jugador(12345, "Axel",3,2);

            Equipo eq1 = new Equipo(2, "Boke");
            Equipo eq2 = new Equipo(3, "Riber");

            if (eq1 + player1)
            {
                Console.WriteLine("Agregado Pepe al 1");
                player1.MostrarDatos();
            }
            if (eq1 + player2)
            {
                Console.WriteLine("Agregado Coco al 1");
                player1.MostrarDatos();
            }
            if (eq1 + player3)
            {
                Console.WriteLine("Agregado Lulu al 1");//esta no se agrega pues este equipo esta lleno
                player1.MostrarDatos();
            }
            if (eq2 + player4)
            {
                Console.WriteLine("Agregado Axel al 2");
                player1.MostrarDatos();
            }

            Console.ReadKey();


        }
    }
}
