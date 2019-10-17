using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    /// <summary>
    /// Clase abstracta Botella.
    /// </summary>
    public abstract class Botella
    {
        #region "Atributos"
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion}

        #region "Enumerados"
        /// <summary>
        /// Tipo de botella.
        /// </summary>
        public enum Tipo
        {
            Plastico,
            Vidrio
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Crea un objeto de tipo Botella. 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if (contenidoML <= capacidadML)
            {
                this.contenidoML = contenidoML;
            }
            else if (capacidadML <= contenidoML)
            {
                this.contenidoML = capacidadML;
            }

        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Devuelve la capacidad de una botella en litros.
        /// </summary>
        public int CapacidadLitros
        {
            get { return capacidadML / 1000; }
        }

        /// <summary>
        /// Contenido de una botella.
        /// </summary>
        public int Contenido
        {
            get
            {
                return contenidoML;
            }
            set
            {
                contenidoML = value;
            }
        }

        /// <summary>
        /// Devuelve el porcentaje contenido de una botella.
        /// </summary>
        public float PorcentajeContenido
        {
            get
            {
                return (contenidoML*100)/ capacidadML;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo abstracto, no tiene implementacion, si la tendra en sus clases hijas.
        /// </summary>
        /// <returns></returns>
        public abstract int ServirMedida();

        /// <summary>
        /// Muestra todos los atributos de una botella.
        /// </summary>
        /// <returns></returns>
        protected virtual string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Marca: {0} \n Contenido: {1} ml\n Capacidad: {2} ml \n Porcentaje contenido: {3}% \n", this.marca, this.contenidoML, this.capacidadML,this.PorcentajeContenido);
            return cadena.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString, invoca al metodo GenerarInforme.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GenerarInforme();
        }

        #endregion

    }
}
