using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Cerveza hereda de clase base Botella.
    /// </summary>
    public class Cerveza : Botella
    {
        #region "Atributos"
        private const int MEDIDA = 330;
        public Tipo tipo;
        #endregion

        #region "Constructores"
        /// <summary>
        /// Crea un objeto de tipo Cerveza con sus atributos, reutiliza al constructor de la clase padre.
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Invoca al constructor de esta clase, define el atributo tipo de botella como Vidrio.
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, int contenidoML)
            : this (capacidadML, marca, Tipo.Vidrio,contenidoML)
        {
            
        }
        #endregion

        #region "Metodos"
        public override float PorcentajeContenido()
        {
            //get
            //{
                return (contenidoML * 90) / capacidadML;
            //}
        }
        /// <summary>
        /// Implementacion del método de la clase padre ServirMedida.
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            int retorno;
            if (MEDIDA <= this.contenidoML)
            {
                retorno = (int)(MEDIDA * 0.80);

            }
            else 
            {
                retorno = this.contenidoML;
            }
            this.contenidoML = this.contenidoML - retorno;
            return retorno;
        }
        

        /// <summary>
        /// Sobreescribe el metodo de la clase base GenerarInforme.
        /// </summary>
        /// <returns></returns>
        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}", base.GenerarInforme());
            cadena.AppendFormat("Tipo: {0} \n", this.tipo);
            cadena.AppendFormat("Medida {0}", MEDIDA);
            return cadena.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Recibe una cerveza y devuelve el tipo de botella de esta.
        /// </summary>
        /// <param name="cerveza"></param>
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        #endregion

    }
}
