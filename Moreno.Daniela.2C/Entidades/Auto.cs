using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        private string transmision;

        /// <summary>
        /// Constructor de la clase Auto, reutiliza al constructor de la clase padre Vehiculo
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="dueño"></param>
        /// <param name="dniDueño"></param>
        /// <param name="transmision"></param>
        /// <param name="color"></param>
        public Auto(string patente,string dueño, int dniDueño, string transmision, string color) : base (patente,dueño,dniDueño,color)
        {
            this.transmision = transmision;
        }

        /// <summary>
        /// Sobreescritura del metodo abstractor seguridad de la clase Auto, retorna las medidas de seguridad.
        /// </summary>
        /// <returns></returns>
        public override string Seguridad()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Estimado cliente: Recuerde utilizar el cinturòn de seguridad, encender las luces bajas al entrar y salir del garage");
            switch (this.transmision)
            {
                case "Manual":
                    cadena.AppendLine("Dentro del garage, solo puede circular en primera marcha");
                    break;
                case "AT":
                    cadena.Append("");
                    break;
            }
            return cadena.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString  de la clase Vehiculo, retorna los datos de un auto, reutiliza al metodo ToString de la clase padre.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.ToString());
            cadena.AppendFormat("Tipo de transmision: {0} \n", this.transmision);
            cadena.Append(this.Seguridad());
            return cadena.ToString();
        }
    }
}
