using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
            : this ()
        {
            this.espacioDisponible = espacioDisponible;
            this.nombre = nombre;
        }

        public static explicit operator string (Estacionamiento e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("\n Nombre del estacionamiento: {0} \n", e.nombre);
            cadena.AppendFormat("Espacio disponible: {0} \n", e.espacioDisponible-e.vehiculos.Count);
            if (!(e is null))
            {
                foreach (Vehiculo v in e.vehiculos)
                {
                    if (v is Automovil)
                    {
                        cadena.AppendLine(((Automovil)v).ConsultarDatos());
                    }else if (v is Moto)
                    {
                        cadena.AppendLine(((Moto)v).ConsultarDatos());
                    }else if (v is PickUp)
                    {
                        cadena.AppendLine(((PickUp)v).ConsultarDatos());
                    }
                }
            }

            return cadena.ToString();
        }

        public static bool operator == (Estacionamiento e, Vehiculo v)
        {
            bool retorno = false;
            if (!(e is null) && !(v is null))
            {
                foreach (Vehiculo transporte in e.vehiculos)
                {
                    if (transporte == v)
                    {
                        retorno = true;
                    }
                }
            }  
            return retorno;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (!(e is null) && !(v is null))
            {
                if (e.espacioDisponible>e.vehiculos.Count)
                {
                    if (e==v)
                    {
                        return e;
                    }
                    e.vehiculos.Add(v);
                    
                }
            }
            return e;
        }

        public static Estacionamiento operator -(Estacionamiento e, Vehiculo v)
        {
            if (!(e is null) && !(v is null) && e == v)
            {
                if (e==v)
                {
                    Console.WriteLine(v.ImprimirTicket());
                    e.vehiculos.Remove(v);
                    return e;
                }            
            }
            Console.WriteLine("El vehiculo no esta en el estacionamiento");
            return e;
        }

    }
}
