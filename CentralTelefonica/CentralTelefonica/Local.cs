using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        
        protected float costo;
        //private int myVar;

        public float CostoLlamada
        {
            get { return costo; }
            //set { myVar = value; }
        }

        private float CalcularCosto()
        {
            return costo;
        }

        public string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.Append(CostoLlamada.ToString());
            return llamada.ToString();
        }

        public Local(Llamada llamada, float costo) 
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)//float duracion, string nroDestino, string nroOrigen
        {
            
            this.costo = costo;//tengo que crear una llamada es pregunta, no no se heredan los constructores
        }

        public Local(string origen, float duracion, string destino, float costo)
        {
            numeroOrigen = origen;
            numeroDestino = destino;
            Duracion = duracion;
        }
    }
}
