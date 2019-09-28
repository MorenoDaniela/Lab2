using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661, CS0659
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        //: base (llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            //.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        //: this (miFranja,new Llamada(duracion,destino,origen))
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            double costo;
            if (this.franjaHoraria == Franja.Franja_1)
            {
                costo = duracion * 0.99;
            }
            else if (this.franjaHoraria == Franja.Franja_2)
            {
                costo = duracion * 1.25;// 1.25f == (float)
            }
            else
            {
                costo = duracion * 0.66;
            }
            return Convert.ToSingle(costo);
        }

        protected new string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Costo llamada: " + CostoLlamada);
            cadena.AppendLine("Franja: " + this.franjaHoraria);
            return cadena.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (!(obj is null))
            {
                if (obj is Provincial)
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
