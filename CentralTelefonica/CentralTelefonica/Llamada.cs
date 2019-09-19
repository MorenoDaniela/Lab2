using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Llamada
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
            numeroDestino = nroDestino;
            numeroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            //Llamada llamada = new Llamada(this.duracion,this.numeroDestino,this.numeroOrigen);
            StringBuilder cadena = new StringBuilder();
            cadena.Append(Duracion.ToString()).Append(" ").Append(NroDestino).Append(" ").Append(NroOrigen);
            return cadena.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            if (llamada1.Duracion == llamada2.Duracion)
            {
                return 0;
            }else if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }else
            {
                return -1;
            }
        }

    }
}
