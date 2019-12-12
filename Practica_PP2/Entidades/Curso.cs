using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("{0}°{1}\n", this.anio, this.division);
                return cadena.ToString();
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Año: {0} Division: {1} Profesor: {2} \n", c.anio, c.division, c.profesor);
            foreach (Alumno a in c.alumnos)
            {
                cadena.AppendFormat("{0}",a.ExponerDatos());
            }
            return cadena.ToString();
        }

        
        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                if (c.AnioDivision == a.AnioDivision)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator + (Curso c, Alumno a)
        {
            if (!(c is null) && !(a is null))
            {
                if (c==a)
                {
                    c.alumnos.Add(a);
                }
            }
            return c;
        }
    }
}
