using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private const int capacidad = 5;
        private static Estacionamiento estacionamiento_singleton;
        private string nombre;
        private int precioAuto;
        private int precioMoto;
        private List<Vehiculo> vehiculos;

        /// <summary>
        /// Propiedad que retorna el nombre del estacionamiento.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Constructor privado que instancia la lista de vehiculos de un Estacionamiento
        /// </summary>
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor privado que reutiliza al constructor de arriba y setea los atributos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precioMoto"></param>
        /// <param name="precioAuto"></param>
        private Estacionamiento(string nombre, int precioMoto, int precioAuto) : this()
        {
            this.nombre = nombre;
            this.precioAuto = precioAuto;
            this.precioMoto = precioMoto;
        }

        /// <summary>
        /// Conversion implicita, retorna los espacios ocupados de un estacionamiento
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator int (Estacionamiento e)
        {
            int retorno = 0;
            if (!(e is null))
            {
                retorno = e.vehiculos.Count();
            }
            return retorno;
        }

        /// <summary>
        /// Operador +, reutiliza la conversion implicita de esta clase para saber si hay espacios disponibles en el estacionamiento y agregar un vehiculo a la lista.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;
            if (!(e is null) && !(v is null))
            {
                if ((int)e < capacidad)
                {
                    e.vehiculos.Add(v);
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Reutliza los metodos ToString de Auto o Moto dependiendo del tipo de vehiculo, retorna tambien los datos del estacionamiento
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre: {1} Capacidad: {0} \nPrecio Moto: {2} Precio Auto: {3} \n", capacidad, this.nombre, this.precioMoto, this.precioAuto);
            foreach (Vehiculo v in this.vehiculos)
            {
                cadena.Append(v.ToString());
                /*
                if (v is Moto)
                {
                    cadena.Append(v.ToString()); //fijarse si dejar que se de cuenta solo de a cual llamar creo que si
                }else if (v is Auto)
                {
                    cadena.Append(v.ToString());
                }*/
            }

            return cadena.ToString();
        }

        /// <summary>
        /// Instancia el estacionamiento, reutiliza el constructor de esta clase.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precioMoto"></param>
        /// <param name="precioAuto"></param>
        /// <returns></returns>
        public static Estacionamiento InstanciarEstacionamiento(string nombre, int precioMoto, int precioAuto)
        {
            if (estacionamiento_singleton is null)
            {
                estacionamiento_singleton = new Estacionamiento(nombre, precioMoto, precioAuto);
            }
            return estacionamiento_singleton;
        }


    }
}
