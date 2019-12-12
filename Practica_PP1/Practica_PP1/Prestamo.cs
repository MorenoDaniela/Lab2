using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public Prestamo (float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if (value> DateTime.Now)
                {
                    this.vencimiento = value;
                }else
                {
                    this.vencimiento = DateTime.Now;
                }
                
            }
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Monto: {0} - Vencimiento: {1} \n", this.monto, this.vencimiento.ToString());
            return cadena.ToString();
        }

        public static int OrdenarPorFecha (Prestamo p1, Prestamo p2)
        {
            int retorno = 0;
            if (!(p1 is null) && !(p2 is null))
            {
                if (p1.vencimiento > p2.vencimiento)
                {
                    retorno = -1;
                }else if (p2.vencimiento > p1.vencimiento)
                {
                    retorno = 1;
                }
            }
            return retorno;
        }


    }
    public enum PeriodicidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral
    }

    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos
    }
}
