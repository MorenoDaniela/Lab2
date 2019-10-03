using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;

        public Figura(int stock, double precio, double altura)
            : this("Figura " + altura.ToString()+" cm",stock,precio,altura)
        {
            
        }

        public Figura (string descripcion,int stock, double precio, double altura)
            : base (descripcion,stock,precio)
        {
            this.altura = altura;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.ToString());
            cadena.AppendFormat("Altura: {0}", this.altura);
            return cadena.ToString();

        }
    }
}
