using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        int ubicacionEstante;
        Producto [] productos;

        private Estante (int capacidad)
        {
            this.productos = new Producto[capacidad];//hasta aca hay espacio

            //Producto nuevo = new Producto[capacidad];//ESTO NO
        }

        public Estante (int capacidad, int ubicacion) : this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto [] GetProductos()
        {
            return this.productos;
        }

        public string MostrarEstante (Estante e)
        {
            String.Format("Ubicacion estante: {0} ", e.ubicacionEstante);
            string aux = "";
            int i;

            for (i=0;i<e.GetProductos().Length;i++)
            {
                aux = aux + e.productos[i].MostrarProducto();

                String.Format("Producto: {0}", aux);
            }

            //String.Format("Productos: {0}", e.GetProductos);

        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

            if (!(e is null && p is null))
            {
                for (int i = 0;i<e.GetProductos().Length;i++)
                {
                    if (productos)
                }
                retorno = true;
            }
            return retorno;
        }
    }
}
