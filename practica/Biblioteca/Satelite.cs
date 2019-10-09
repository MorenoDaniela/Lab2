using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Satelite : Astro
    {

        public string Nombre
        {
            get { return nombre; }
        }
        
        public Satelite(int duraOrbita, int duraRota,string nombre)
            : base (duraOrbita,duraRota,nombre)
        {

        }
        public override string Orbitar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Orbitar el satelite: {0} \n", this.Nombre);
            return cadena.ToString();
        }


        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat(base.Mostrar());
            return cadena.ToString();
        }


    }
}
