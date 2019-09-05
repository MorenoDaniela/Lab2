using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);
            //Console.WriteLine(Estante.MostrarEstante(estante));
            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
            //Console.WriteLine("ALALALA");
            //Producto.MostrarProducto(p4);
            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
            //String.Format("ESTANTE {0}", Estante.MostrarEstante(estante));
            //Console.WriteLine(estante.MostrarEstante);
            Console.ReadKey();







            /*
            Producto nuevo = new Producto("Sony", "012", 15);
            Producto viejo = new Producto("DELL", "012", 50);
             if (nuevo==viejo)
            {
                Console.WriteLine("Funciona");
            }else
                Console.WriteLine("NO Funciona");
            Console.ReadKey();
            */
        }
    }
    //Object.ReferenceEquals(p1,p2);// para comparar un objeto y saber si es nulo. en p2 deberia poner null
    //p1 is null// devuelve booleano sirve para lo mismo
}
