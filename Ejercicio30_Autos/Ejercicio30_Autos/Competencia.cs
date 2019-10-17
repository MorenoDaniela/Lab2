using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30_Autos
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List <AutoF1>();
        }

        public Competencia(short vuelta, short competidores)
            : this()
        {
            this.cantidadVueltas = vuelta;
            this.cantidadCompetidores = competidores;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                foreach (AutoF1 auto in c.competidores)
                {
                    if (auto == a)
                    {
                        retorno = true;
                    }
                }
            }
            
            return retorno;
        }
        
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                if (c.cantidadCompetidores>c.competidores.Count && c!=a)
                {
                    c.competidores.Add(a);
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
