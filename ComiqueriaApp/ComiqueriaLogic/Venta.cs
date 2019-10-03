using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha//internal es como public SOLO PARA EL PROYECTO, PARA LOS DEMAS ES PRIVADO, la solucion no ve
        {
            get { return fecha; }
            //set { fecha = value; }
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Fecha: {0} - Descripcion {1} - Precio Final: {2:#.##} ", this.Fecha, this.producto.Descripcion, this.precioFinal);
            return cadena.ToString();
        }

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        private void Vender(int cantidad)//de instancia no es statico
        {

            producto.Stock = producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);

        }


        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double totalIva = (precioUnidad * cantidad) * (porcentajeIva / 100);
            double retorno = totalIva + (precioUnidad * cantidad);
            return retorno;
        }

    }
}
