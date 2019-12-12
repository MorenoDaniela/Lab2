using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                return this.fechaIngreso.CompareTo(DateTime.Now);
            }
        }

        public Profesor(string nombre, string apellido, string documento) : this(nombre,apellido,documento, DateTime.Now)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base (nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}",base.ExponerDatos());
            cadena.AppendFormat("Fecha ingreso: {0}", this.fechaIngreso);
            return cadena.ToString();
        }

        protected override bool ValidarDocumentacion(string docu)
        {
            bool retorno = false;
            if (docu.Length==8)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
