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
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Patente {0}", this.Patente);
            return cadena.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (!(v1 is null) && !(v2 is null))
            {

            }
        }
    }
}
