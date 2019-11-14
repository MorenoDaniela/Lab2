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
                if (this.apellido!=value)
                {
                    
                    apellido = value;
                    this.EventoString.Invoke(this.Mostrar());//preguntar cual es el fin de esto
                }
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
                if (this.nombre!=value)
                {
                    nombre = value;
                    this.EventoString.Invoke(this.Mostrar());
                }  
            }
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre: {0} Apellido: {1}\r\n", this.Nombre, this.Apellido);
            return cadena.ToString();
        }

        
    }
}
