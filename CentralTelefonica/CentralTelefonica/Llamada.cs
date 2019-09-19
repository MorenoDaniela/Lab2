using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Llamada
    {
        protected float duracion;
        protected string numeroDestino;
        protected string numeroOrigen;

        public float Duracion
        {
            get { return duracion; }
        }

        public string NroDestino
        {
            get { return numeroDestino; }
        }

        public string NroOrigen
        {
            get { return numeroOrigen; }
        }

        public Llamada (float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.numeroDestino = nroDestino;
            this.numeroOrigen = nroOrigen;
        }

    }
}
