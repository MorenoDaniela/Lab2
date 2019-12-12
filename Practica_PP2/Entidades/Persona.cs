using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private string documento;

        public Persona (string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        public string Apelido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }set
            {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        public virtual string ExponerDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Nombre: {0} Apellido {1} Documento: {2} \n", this.nombre, this.apellido, this.documento);
            return cadena.ToString();
        }

        protected abstract bool ValidarDocumentacion(string docu);

    }

    public enum Divisiones
    {
        A,
        B,
        C,
        D,
        E
    }

}
