using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        public Astro (int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;

        }

        protected string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre: {0} \n", this.nombre);
            cadena.AppendFormat("Rotacion: {0} \n", this.duracionRotacion);
            cadena.AppendFormat("Orbita: {0} ", this.duracionOrbita);
            return cadena.ToString();
        }

        public abstract string Orbitar();

        public virtual string Rotar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Rotando tiempo estimado: {0} \n", this.duracionRotacion);
            return cadena.ToString();
        }

        public static explicit operator string(Astro astro)
        {
            return astro.nombre;
            /*
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre: {0} \n", astro.nombre);
            return cadena.ToString();*/
        }
    }
}
