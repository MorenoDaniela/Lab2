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
            cotizRespectoDolar = 2;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro (double cantidad, double cotizacion) 
            : this (cantidad)
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

        public static bool operator ==(Euro e1,Euro e2)
        {
            bool retorno = false;
            if (e1==e2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool retorno = false;
            if (!(e1==e2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            bool retorno = false;
            if (p==e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e, Peso p)
        {
            bool retorno = false;
            if (p!=e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            if (d==e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool retorno = false;
            if (d!=e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }

        public static Euro operator - (Euro e, Dolar d)
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

            if (d==p)
            {
            retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            bool retorno = false;
            if (d!=p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            bool retorno = false;
            if ((Euro)p==e)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            bool retorno = false;
            if (!(p==e))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            bool retorno = false;
            if (p1==p2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            bool retorno = false;
            if (!(p1==p2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }

        public static Peso operator - (Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static Peso operator + (Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }

        public static Peso operator - (Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
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
             
            return new Peso(d.GetCantidad() / Peso.GetCotizacion());//
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

            if (d==(Dolar)p)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            bool retorno = false;

            if (!(d ==p))
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno =false;
            if (d1==d2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool retorno = false;
            if (!(d1==d2))
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

        public static Dolar operator + (Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return retorno;
        }

        public static Dolar operator - (Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return retorno;
        }
    }
}
