using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Agua hereda de la clase base Botella.
    /// </summary>
    public class Agua : Botella
    {
        #region "Atributos"
        private const int MEDIDA = 400;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Crea un objeto de tipo Agua con sus atributos reutilizando el constructor de la clase base.
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Agua (int capacidadML,string marca, int contenidoML)
            :base (marca,capacidadML,contenidoML)
        {

        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Reutiliza el metodo ServirMedida que recibe un int.
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {

            return ServirMedida(MEDIDA);

        }

        /// <summary>
        /// Implementacion del metodo ServirMedida de la clase base.
        /// </summary>
        /// <param name="medida"></param>
        /// <returns></returns>
        public int ServirMedida(int medida)
        {
            int retorno;
            if (medida <= this.contenidoML)
            {
                this.contenidoML = this.contenidoML - medida;
                retorno = medida;

            }
            else
            {
                this.contenidoML = this.contenidoML - this.contenidoML;
                retorno = this.contenidoML;

            }
            return retorno;   
        }

        /// <summary>
        /// Sobreescritura del metodo GenerarInforme de la clase base.
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}", base.GenerarInforme());
            cadena.AppendFormat("{0}", MEDIDA);
            return cadena.ToString();
        }
        #endregion
    }
}
