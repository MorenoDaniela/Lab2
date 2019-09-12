using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
#pragma warning disable CS0660, CS0661//desacctivar warnings
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 2;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
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

        public static implicit operator Euro(double d)
        {

            Euro nuevo = new Euro(d);
            return nuevo;
            //return d;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() / Dolar.GetCotizacion());
            //return (Dolar)(p.GetCantidad() / Dolar.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.GetCantidad() / GetCotizacion());
            //return (Euro)(p.GetCantidad() / Euro.GetCotizacion());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (e1 == e2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (!(e1 == e2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            bool retorno = false;
            if (p == e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            bool retorno = false;
            if (p != e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if (d == e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool retorno = false;
            if (d != e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }


    }
}
