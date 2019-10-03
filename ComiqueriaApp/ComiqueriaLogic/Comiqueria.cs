using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto product in productos)
                {
                    if ((Guid)product == codigo)
                    {
                        return product;
                    }
                }
                return null;
            }
        }

        public Comiqueria()
        {
           this.ventas = new List<Venta>();
            this.productos = new List<Producto>();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto product)
        {
            bool retorno = false;
            if (!(comiqueria is null) && !(product is null))
            {
                foreach (Producto p in comiqueria.productos)
                {
                    if (p.Descripcion == product.Descripcion)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto product)
        {
            return !(comiqueria == product);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto product)
        {
            if (!(comiqueria is null) && !(product is null))
            {
                if (comiqueria != product)
                {
                    comiqueria.productos.Add(product);
                }
            }
            return comiqueria;
        }

        public void Vender(Producto product)
        {
            Vender(product, 1);
        }

        public void Vender(Producto product, int cantidad)
        {
            Venta nueva = new Venta(product, cantidad);
            this.ventas.Add(nueva);
        }

        public string ListarVentas()
        {
            StringBuilder cadena = new StringBuilder();
            ventas.Sort(OrdenarFecha);
            foreach (Venta v in ventas)
            {
                cadena.AppendLine(v.ObtenerDescripcionBreve());
            }
            return cadena.ToString();
        }

        public int OrdenarFecha(Venta v1, Venta v2)
        {
            int retorno = 0;
            if (v1.Fecha < v2.Fecha)
            {
                retorno = -1;
            }else if (v1.Fecha > v2.Fecha)
            {
                retorno = 1;
            }
            return retorno;
        }

        public Dictionary <Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();

            foreach (Producto product in productos)
            {
                retorno.Add((Guid)product, product.Descripcion);
            }
            return retorno;
        }

    }
}