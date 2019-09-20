using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja,Llamada llamada) 
            : base (llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : this (miFranja,new Llamada(duracion,destino,origen))
        {

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

    }
}
