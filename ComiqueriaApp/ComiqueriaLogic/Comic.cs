using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public enum TipoComic
        {
            Occidental,
            Oriental
        }

        public Comic(string descripcion,int stock, double precio,string autor,TipoComic tipoComic)
            : base (descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.ToString());
            cadena.AppendFormat("Autor: ", this.autor);
            cadena.AppendFormat("Tipo comic: ", this.tipoComic);
            return cadena.ToString();
        }

    }
}
