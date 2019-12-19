using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fruta : ReinoVegetal ,IVegetales
    {
        private ConsoleColor color;

        public Fruta(float valor, Gusto gusto, ConsoleColor color)
            :base(valor, gusto)
        {
            this.color = color;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }

        /// <summary>
        /// Muestra todos los datos de la fruta
        /// </summary>
        /// <returns>devuelve un string conteniendo toda la informacion e la fruta</returns>
        public string MostrarDatos()
        {
            StringBuilder message = new StringBuilder();

            message.Append(base.ToString());
            message.AppendFormat("COLOR: {0}\n", this.Color);

            return message.ToString();
        }

        /// <summary>
        /// Llama a la funcion MostrarDatos()
        /// </summary>
        /// <returns>devuelve un string conteniendo toda la informacion e la fruta</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }


        /// <summary>
        /// Llama al metodo de extencion hecho especialmente para esta clase
        /// </summary>
        /// <returns></returns>
        public string MostrarElemento()
        {
            return Metodo_de_Extencion.GuardarElemento(this, Encoding.ASCII);
        }
    }
}
