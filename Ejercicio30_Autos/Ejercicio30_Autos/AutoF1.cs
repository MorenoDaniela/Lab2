using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30_Autos
{
#pragma warning disable CS0660, CS0661
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;
        
        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { caballosDeFuerza = value; }
        }
        
        public AutoF1(short numero, string escuderia)
            : base (numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1 == a2 && a1.caballosDeFuerza == a2.caballosDeFuerza)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}", base.MostrarDatos());
            cadena.AppendFormat("Caballos de fuerza: {0} \n", this.caballosDeFuerza);
            return cadena.ToString();
        }
    }
}
