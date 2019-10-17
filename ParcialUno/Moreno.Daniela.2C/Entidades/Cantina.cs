using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Cantina.
    /// </summary>
    public class Cantina
    {
        #region "Atributos"
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;
        #endregion

        #region Propiedades"
        /// <summary>
        /// Devuelva la lista de botellas.
        /// </summary>
        public List<Botella> Botellas
        {
            get { return botellas; }
           // set { myVar = value; }
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Crea un objeto de tipo Cantina.
        /// </summary>
        /// <param name="espacio"></param>
        private Cantina(int espacio)
        {
            botellas = new List<Botella>();
            this.espaciosTotales = espacio;
        }
        #endregion

        #region "Singleton"
        /// <summary>
        /// Patron singleton, logra que el objeto Cantina sea instanciado una sola vez, si no existe lo instancia, si existe modifica su atributo espaciosTotales.
        /// </summary>
        /// <param name="espacios"></param>
        /// <returns></returns>
        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);
                
            }else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Operador +, Agrega una Botella a la lista de botellas de la Cantina.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator +(Cantina c, Botella b)
        {
            bool retorno = false;
            if (!(c is null) && !(b is null))
            {
                if (c.espaciosTotales > c.botellas.Count)
                {
                    c.botellas.Add(b);
                    retorno = true;
                }
            }
            return retorno;

        }
        #endregion
    }
}
