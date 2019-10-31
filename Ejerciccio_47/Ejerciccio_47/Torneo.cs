using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciccio_47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public static bool operator ==(Torneo t, Equipo e)//preguntar
        {
            bool retorno = false;

            if (!(t is null) && !(e is null))
            {
                foreach (Equipo aux in t.equipos)
                {
                    if (aux==e)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo t, Equipo e)
        {
            return !(t == e);
        }

        public static Torneo operator +(Torneo t, Equipo e)
        {
            if (!(t is null) && !(e is null))
            {
                if (t!=e)
                {
                    t.equipos.Add(e);
                }
            }
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("torneo {0}", this.nombre);
            foreach (Equipo equipo in equipos)
            {
                cadena.Append(equipo.Ficha());
            }
            return cadena.ToString();
        }

        private string CalcularPartido<T>(T uno, T dos)
        {

        }
    }
}
