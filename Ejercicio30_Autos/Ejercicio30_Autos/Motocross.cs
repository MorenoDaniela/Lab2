using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30_Autos
{
    public class Motocross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public Motocross(short numero, string escuderia)
            : base (numero,escuderia)
        {

        }
        public Motocross(short numero, string escuderia,short cilindrada)
            : this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Motocross a1, Motocross a2)
        {
            bool retorno = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1 == a2 && a1.cilindrada == a2.cilindrada)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Motocross a1, Motocross a2)
        {
            return !(a1 == a2);
        }

        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}", base.MostrarDatos());
            cadena.AppendFormat("Cilindrada: {0} \n", this.cilindrada);
            return cadena.ToString();
        }

    }
}
