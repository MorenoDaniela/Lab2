using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected string color;
        protected int dniDueño;
        protected string nombreDueño;
        protected string patente;

        /// <summary>
        /// Constructor de la clase vehiculo, setea los atributos tipo string vacios.
        /// </summary>
        private Vehiculo() 
        {
            this.color = string.Empty;
            this.nombreDueño = string.Empty;
            this.patente = string.Empty;
        }

        /// <summary>
        /// Constructor de la clase vehiculo, reutiliza al constructor de arriba, setea los atributos.
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="dueño"></param>
        /// <param name="dni"></param>
        /// <param name="color"></param>
        public Vehiculo(string patente, string dueño, int dni, string color) : this()
        {
            this.patente = patente;
            this.nombreDueño = dueño;
            this.dniDueño = dni;
            this.color = color;
        }

        /// <summary>
        /// Metodo Abstracto, su implementacion se definira en las clases deribadas.
        /// </summary>
        /// <returns></returns>
        public abstract string Seguridad();
        
        /// <summary>
        /// Sobreescitura del metodo ToString retorna los datos de un vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre del cliente: {0} \nDNI: {1} \nColor: {2} \nPatente: {3}", this.nombreDueño, this.dniDueño, this.color.ToString(), this.patente);
            
            return cadena.ToString();//agregar tipo de vehiculo dsps

        }



    }

    public enum eTransmision
    {
        Seleccionar,
        AT,
        Manual
    }

    public enum eColores
    {
        Seleccionar,
        Azul,
        Rojo,
        Blanco,
        Negro
    }
}
