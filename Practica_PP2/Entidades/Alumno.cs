using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        public string AnioDivision
        {
            get
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("{0}°{1}\n", this.anio, this.division.ToString());
                return cadena.ToString();
            }
        }

        public Alumno (string nombre, string apellido, string documento, short anio, Divisiones division) : base (nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}",base.ExponerDatos());
            cadena.AppendFormat("{0} \n", this.AnioDivision);
            return cadena.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            
            if (doc.Length==9)
            {
                /*
                doc.ToArray();
                for(int i=0;i<=9;i++)
                {
                    if (doc[3]=='-' && doc[8]=='-')
                    {
                        if (doc[0]==')
                        retorno = true;
                    }
                }*/

                foreach (char c in doc)
                {
                    if (Char.IsNumber(c))// && Char.IsPunctuation(c))
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
            
        }
    }
}
