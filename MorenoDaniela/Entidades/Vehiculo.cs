using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    patente = value;
                }
                
            }
        }

        public abstract string ConsultarDatos();
        
        public Vehiculo (string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(3);
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("\nPatente {0} ", this.Patente);
            return cadena.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.patente == v2.patente)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}",this.ToString());
            cadena.AppendFormat("Fecha y hora de ingreso: {0} ", this.ingreso.ToString());
            return cadena.ToString();
        }

        
    }
}
