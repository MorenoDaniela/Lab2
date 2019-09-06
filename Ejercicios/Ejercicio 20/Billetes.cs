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
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 0.86;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro (double cantidad, double cotizacion) : this (cantidad)
        {
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

        public static implicit operator Euro(double d)
        {
            return d;
        }
    }

    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso ()
        {
            cotizRespectoDolar = 38.33;
        }

        public Peso (double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso (double cantidad, double cotizacion) : this (cantidad)
        {
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

        public static implicit operator Peso(double d)
        {
            return d;
            //return (Peso)d;
        }

        public static explicit operator Dolar(Peso p)
        {
            return (p.GetCantidad() / Dolar.GetCotizacion());
            //return (Dolar)(p.GetCantidad() / Dolar.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (p.GetCantidad() / Euro.GetCotizacion());
            //return (Euro)(p.GetCantidad() / Euro.GetCotizacion());
        }

    }

    public class Dolar
    {
        private double cantidad;
        static private double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;

        }

        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar (double cantidad, double cotizacion) : this (cantidad)
        {
            //this.cantidad = cantidad;
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

        
        public static implicit operator Dolar (double d)
        {
            return d;
        }

        public static explicit operator Euro (Dolar d)
        {
            return (d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso (Dolar d)
        {
            return (d.GetCantidad() * GetCotizacion());
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;

            if ((Euro)d == e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool retorno = true;

            if (d==e)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
