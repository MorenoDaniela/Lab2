using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660, CS0661//desacctivar warnings
    public class Dolar
    {
        private double cantidad;
        static private double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
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


        public static implicit operator Dolar(double d)
        {
            Dolar nuevo = new Dolar(d);
            return nuevo;
        }

        public static explicit operator Euro(Dolar d)
        {
            //return new Euro(d.cantidad / cotizRespectoDolar);
            return new Euro(d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {

            return new Peso(d.GetCantidad() * Peso.GetCotizacion());//
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

            if (d == e)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            bool retorno = false;

            if (d == (Dolar)p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            bool retorno = false;

            if (!(d == p))
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (d1 == d2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (!(d1 == d2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return retorno;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return retorno;
        }
    }
}
