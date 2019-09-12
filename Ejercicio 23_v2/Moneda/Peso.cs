using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660, CS0661//desacctivar warnings
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            cotizRespectoDolar = 0.50;
            //cotizRespectoDolar = 0.0260;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
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
            Peso nuevo = new Peso(d);
            return nuevo;
            //return d;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() * Peso.GetCotizacion());
            //return (Dolar)(p.GetCantidad() / Dolar.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro(p.GetCantidad() / Euro.GetCotizacion());
            //return (Euro)(p.GetCantidad() / Euro.GetCotizacion());
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            bool retorno = false;

            if (d == p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            bool retorno = false;
            if (d != p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            bool retorno = false;
            if ((Euro)p == e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            bool retorno = false;
            if (!(p == e))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool retorno = false;
            if (p1 == p2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            bool retorno = false;
            if (!(p1 == p2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }

    }
}
