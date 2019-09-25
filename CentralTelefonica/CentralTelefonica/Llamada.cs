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
            this.numeroDestino = nroDestino;
            this.numeroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            //Llamada llamada = new Llamada(this.duracion,this.numeroDestino,this.numeroOrigen);
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Duracion : " + Duracion.ToString());
            cadena.AppendLine("Numero destino: " + NroDestino.ToString());
            cadena.AppendLine("Numero de origen: " + NroOrigen.ToString());
            //cadena.Append(Duracion.ToString()).Append(" ").Append(NroDestino).Append(" ").Append(NroOrigen);
            return cadena.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion == llamada2.Duracion)
            {
                retorno=0;
            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno=1;
            }
            else
            {
                retorno=-1;
            }
            return retorno;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
