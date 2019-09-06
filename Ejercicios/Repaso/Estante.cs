using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Producto;

namespace Repaso
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto [] productos;

        private Estante (int capacidad)
        {
            this.productos = new Producto[capacidad];//hasta aca hay espacio

            //Producto nuevo = new Producto[capacidad];//ESTO NO
        }

        public Estante (int capacidad, int ubicacion) 
            : this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto [] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante (Estante e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Ubicacion del estante: {0} \n", e.ubicacionEstante);
            cadena.AppendFormat("Capacidad: {0} \n", e.productos.Length);
            /*
            String.Format("Ubicacion estante: {0} ", e.ubicacionEstante);
            String.Format("Capacidad: {0}", e.productos.Length);
            String.Format("PRODUCTOS: ");*/
            //string aux = "";
            
            if (!(e is null))
            {
                foreach (Producto p in e.productos)
                {
                    cadena.AppendLine(Producto.MostrarProducto(p));
                    //aux = aux + "\n" + Producto.MostrarProducto(p);
                }
            }
            return cadena.ToString();
            //return aux;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

           foreach (Producto pro in e.productos)
           {
                if (!(pro is null))
                //if (!object.ReferenceEquals(pro,null))
                {
                    if (p==pro)
                    {
                        retorno = true;
                    } 
                }
           }
           return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = true;

            if (e==p)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator +(Estante e, Producto p)
        {
            int i;
            if (e!=p)
            {
                for (i=0;i<e.GetProductos().Length;i++)
                {
                    if ((e.productos[i] is null))
                    //if (object.ReferenceEquals(e.productos[i],null))
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i;

            for (i=0;i<e.GetProductos().Length;i++)
            {
                if (!(e.productos[i] is null))
                //if (!object.ReferenceEquals(e.productos[i],null))
                {
                    if (p==e.productos[i])
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;

        }
    }
}
