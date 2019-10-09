using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SistemaSolar
    {
        private List<Astro> planetas = new List<Astro>();

        public List<Astro> Planetas
        {
            get { return planetas; }
        }

        static SistemaSolar()
        {

        }

        public string MostrarInformacionAstros()
        {
            StringBuilder cadena = new StringBuilder();
            
            foreach (Planeta plat in Planetas)
            {
                cadena.AppendLine("PLANETA");
                cadena.AppendLine(plat.ToString());
                //cadena.AppendLine(plat.Rotar());
                //cadena.AppendLine(plat.Orbitar());
                foreach (Satelite sat in plat.Satelites)
                {
                    cadena.AppendLine("SATELITE");
                    cadena.AppendLine(sat.ToString());
                    cadena.AppendLine(sat.Orbitar());
                }
            }
            //cadena.AppendLine(astro.ToString());
            //cadena.AppendLine(astro.Rotar());
            return cadena.ToString();
        }
    }
}
