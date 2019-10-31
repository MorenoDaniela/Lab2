using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> lista = new Contabilidad<Factura, Recibo>();
            Recibo recibo = new Recibo(10);
            Factura factura = new Factura(5);
            
            lista += recibo;
            lista += factura;

        }
    }
}
