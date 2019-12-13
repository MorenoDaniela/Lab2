using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        /// <summary>
        /// Constructor de la clase Moto, retuliza al constructor de la clase Vehiculo
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="dueño"></param>
        /// <param name="dni"></param>
        /// <param name="cilindrada"></param>
        /// <param name="color"></param>
        public Moto(string patente, string dueño, int dni, int cilindrada, string color) : base (patente,dueño,dni, color)
        {
            this.cilindrada = cilindrada;
        }

        /// <summary>
        /// Sobreescitura del metodo abstracto Seguridad de la clase Vehiculo, retorna las medidas de seguridad.
        /// </summary>
        /// <returns></returns>
        public override string Seguridad()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Estimado cliente: Recuerde utilizar casco y mantener las luces encendidas al circular por el garage");
            return cadena.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString retorna los datos de la moto, reutiliza al metodo ToString de la clase padre.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.ToString());
            cadena.AppendFormat("Cilindrada: {0} \n", this.cilindrada);
            cadena.Append(this.Seguridad());
            return cadena.ToString();
        }
    }
}
