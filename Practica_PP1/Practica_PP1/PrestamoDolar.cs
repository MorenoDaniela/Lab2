using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePagos Perioricidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad) : base (monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad) : this(prestamo.Monto,prestamo.Vencimiento,periodicidad)
        {
            
        }

        private float CalcularInteres()
        {
            float retorno = 0;
            switch (this.periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    retorno = (float)(this.monto * 0.25);
                    //retorno = this.monto + (float)(this.monto * 0.25);
                    break;
                case PeriodicidadDePagos.Bimestral:
                    retorno = (float)(this.monto * 0.35);
                    //retorno = this.monto + (float)(this.monto * 0.35);
                    break;
                case PeriodicidadDePagos.Trimestral:
                    retorno = (float)(this.monto * 0.40);
                    //retorno = this.monto + (float)(this.monto * 0.40);
                    break;
            }
            return retorno;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = this.vencimiento.CompareTo(nuevoVencimiento);
            this.monto += (float)(2.5 * dias);
            this.vencimiento = nuevoVencimiento;
        }


        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.Mostrar());
            cadena.AppendFormat("Perioricidad: {0} - Interes: {1} \n", this.periodicidad.ToString(), this.Interes) ;
            return cadena.ToString();
        }


    }
}
