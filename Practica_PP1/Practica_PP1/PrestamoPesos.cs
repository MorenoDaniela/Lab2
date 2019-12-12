using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base (monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres) : this(prestamo.Monto,prestamo.Vencimiento,porcentajeInteres)
        {

        }

        private float CalcularInteres()
        {
            return (porcentajeInteres * this.monto) / 100;
            //return this. monto + ((porcentajeInteres * this.monto) / 100);

        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            int dias = this.vencimiento.CompareTo(nuevoVencimiento);
            this.porcentajeInteres += (float)(dias * 0.25);
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.Mostrar());
            cadena.AppendFormat("Porcentaje interes: {0} - Interes: {1} \n", this.porcentajeInteres, this.CalcularInteres());
            return cadena.ToString();
        }

    }
}
