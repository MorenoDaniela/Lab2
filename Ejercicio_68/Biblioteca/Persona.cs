using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.EventoString.Invoke("Apellido cambiado");
                apellido = value;
            }
        }

        public Persona()
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.EventoString.Invoke("Nombre cambiado");
                nombre = value;
            }
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre: {0} Apellido: {1}\r\n", this.nombre, this.apellido);
            return cadena.ToString();
        }

        
    }
}
