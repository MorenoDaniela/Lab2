using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Canasta<T> where T : ReinoVegetal
    {
        private List<T> plantas;
        private short capacidad;


        private Canasta()
        {
            this.plantas = new List<T>();
        }

        public Canasta(short capacidad): this()
        {
            this.capacidad = capacidad;
        }

        /// <summary>
        /// Agrega un tipo especifico del Reino vegetal, tirando excepcion si no son del mismo tipo y tambien si no posee capasidad en la canasta
        /// </summary>
        /// <param name="c">canasta</param>
        /// <param name="reinoVegetal">reino vegetal</param>
        /// <returns>Si sale todo como corresponde devuelve la canasta con el tipo de reino vegetal agregado a la misma</returns>

        public static Canasta<T> operator +(Canasta<T> c, ReinoVegetal reinoVegetal)
        {
            if (reinoVegetal is T)
            {
                if (c.plantas.Count < c.capacidad)
                {
                    T aux = (T)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add(aux);

                    return c;
                }
                else
                {
                    throw new NoAgregaException("Capacidad excedida.");
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                }
            }
            else
            {
                throw new NoAgregaException(string.Format("El elemento es del tipo {0}. Se esperaba {1}.", reinoVegetal.GetType(), c.GetType()));
                // Lanzar excepción con el mensaje "El elemento es del tipo {0}. Se esperaba {1}."
            }
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad: " + this.capacidad);
            foreach (T reinoVegetal in this.plantas)
            {
               sb.AppendLine(reinoVegetal.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}
