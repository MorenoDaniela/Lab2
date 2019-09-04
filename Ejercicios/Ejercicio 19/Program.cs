using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Sumador;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sumador resultado = new Sumador(2);
            Sumador resultado2 = new Sumador();

            string cadena;
            long numero;

            //resultado.Sumador(20);
            //resultado2.Sumador(5);

            numero=resultado.Sumar(10,12);
            cadena = resultado.Sumar("Hola ", "Daniela");
            

            Console.WriteLine("{0} // {1}", numero, cadena);
            Console.WriteLine("{0} // ",resultado + resultado2);
            Console.WriteLine("{0} //", resultado | resultado2);
            //Console.WriteLine(resultado.cantidadSumas);
            //Console.WriteLine(resultado2.cantidadSumas);



            Console.ReadKey();
        }
    }
}
