using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
   public abstract class Producto
   {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get { return descripcion; }
            //set { descripcion = value; }
        }

        public double Precio
        {
            get { return precio; }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set {
                    if (value>=0)
                    {
                        stock = value;
                    }
                }
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        protected Producto (string descripcion, int stock,double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }


        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Codigo: {0} \n", (Guid)this);
            cadena.AppendFormat("Stock: {0} \n", this.Stock);
            cadena.AppendFormat("Precio: ${0} \n", this.Precio);
            cadena.AppendFormat("Descripcion: {0} \n", this.Descripcion);
            return cadena.ToString();
        }



    }
}
