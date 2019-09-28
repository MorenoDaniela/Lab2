using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661, CS0659
    public class Local : Llamada
    {

        protected float costo;

        public override float CostoLlamada
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

        protected new string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();
            llamada.AppendLine(base.Mostrar());
            llamada.AppendLine("Costo llamada: " + CostoLlamada.ToString());
            //llamada.AppendLine(base.Mostrar()).AppendLine(CostoLlamada.ToString());
            return llamada.ToString();
        }

        public Local(string origen, float duracion, string destino, float costo)
           : base(duracion, destino, origen)//: this (new Llamada(duracion, destino,origen),costo)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
           // : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
           : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }




        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null))
            {
                if (obj is Local)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();

        }
    }
}
