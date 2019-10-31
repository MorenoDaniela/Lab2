using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciccio_47
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public static bool operator ==(Equipo uno, Equipo dos)
        {
            bool retorno = false;

            if (!(uno is null) && !(dos is null))
            {
                if (uno.fechaCreacion == dos.fechaCreacion && uno.nombre == dos.nombre)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo uno, Equipo dos)
        {
            return !(uno == dos);
        }

        public string Ficha()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0} fundado el {1} \n", this.nombre, this.fechaCreacion.ToString());
            return cadena.ToString();
        }
    }
}
