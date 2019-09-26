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

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public new string Mostrar() 
        {
            StringBuilder llamada = new StringBuilder();
            llamada.AppendLine(base.Mostrar());
            llamada.AppendLine("Costo llamada: " + CostoLlamada.ToString());
            //llamada.AppendLine(base.Mostrar()).AppendLine(CostoLlamada.ToString());
            return llamada.ToString();
        }

        public Local(Llamada llamada, float costo) 
            : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {            
            this.costo = costo;
        }


        public Local(string origen, float duracion, string destino, float costo) : this (new Llamada(duracion, destino,origen),costo)
        {

        }
    }
}
