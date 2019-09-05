using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        static private double cotizRespectoDolar=0.86;

        private Euro()
        {

        }
    }

    public class Peso
    {
        private double cantidad;
        static private double cotizRespectoDolar=38.33;

        private Peso ()
        {
            
        }
    }

    public class Dolar
    {
        private double cantidad;
        static private double cotizRespectoDolar=1;

        private Dolar()
        {
            this.cantidad = 0;
            cotizRespectoDolar = 1;

        }

        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar (double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
    }
}
