using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Canasta<T> where T : ReinoVegetal, IVegetales
    {
        private List<T> plantas;
        private short capacidad;
        
        private Canasta ()
        {
            this.plantas = new List<T>();
        }
        public Canasta(short capacidad): this()
        {
            this.capacidad = capacidad;
        }

        public static Canasta<T> operator +(Canasta<T> c, ReinoVegetal reinoVegetal)
        {
            if (reinoVegetal is T)
            {
                if (c.plantas.Count < c.capacidad)
                {
                    //... aux = (...)Convert.ChangeType(reinoVegetal, typeof(T));
                    T aux = (T)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add(aux);

                    return c;
                }
                else
                {
                    throw new NoAgregaException("Capacidad excedida");
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                }
            }
            else
            {
                string cadena;
                string auxiliar = "";
                if (reinoVegetal is Fruta )
                {
                    cadena = "Fruta";
                    auxiliar = string.Format("El elemento es del tipo {0}. Se esperaba {1}. ", cadena,c.ToString());//mmm
                }
                else if (reinoVegetal is Verdura )
                {
                    cadena = "Verdura";
                    auxiliar = string.Format("El elemento es del tipo {0}. Se esperaba {1}. ", cadena,c.ToString());
                }
                else
                {
                    cadena = "Carnibora";
                    auxiliar = string.Format("El elemento es del tipo {0}. Se esperaba {1}. ", cadena,c.ToString());
                }

                throw new NoAgregaException(auxiliar);
            }
        }
        /* Lógica operador +
            if (reinoVegetal is ...)
            {
                if (c.plantas.Count < c.capacidad)
                {
                    ... aux = (...)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add(aux);

                    return c;
                }
                else
                {
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                }
            }
            else
            {
                // Lanzar excepción con el mensaje "El elemento es del tipo {0}. Se esperaba {1}."
            }
        */

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
