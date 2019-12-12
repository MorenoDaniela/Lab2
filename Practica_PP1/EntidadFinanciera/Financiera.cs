using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
#pragma warning disable CS0660, CS0661
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        public float InteresesEnDolares
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return this.CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoDePrestamo)
        {
            float retorno = 0;

            foreach (Prestamo p in this.listaDePrestamos)
            {
                if (tipoDePrestamo == TipoDePrestamo.Dolares && p is PrestamoDolar)
                {
                    PrestamoDolar presDolar = (PrestamoDolar)p;
                    retorno += presDolar.Interes;
                }else if (tipoDePrestamo == TipoDePrestamo.Pesos && p is PrestamoPesos)
                {
                    PrestamoPesos presPeso = (PrestamoPesos)p;
                    retorno += presPeso.Interes;
                }else if (tipoDePrestamo == TipoDePrestamo.Todos)
                {
                    if (p is PrestamoDolar)
                    {
                        PrestamoDolar presDolar = (PrestamoDolar)p;
                        retorno += presDolar.Interes;
                    }else if (p is PrestamoPesos)
                    {
                        PrestamoPesos presPeso = (PrestamoPesos)p;
                        retorno += presPeso.Interes;
                    }
                }
            }

            return retorno;
        }

        public static explicit operator string (Financiera financiera)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Razon social: {0}\n", financiera.razonSocial);
            cadena.AppendFormat("Intereses totales: {0} Intereses Dolar: {1} Intereses Pesos: {2} \n", financiera.InteresesEnDolares, financiera.InteresesEnPesos, financiera.InteresesTotales);
            foreach (Prestamo p in financiera.listaDePrestamos)
            {
                cadena.AppendFormat("{0}", p.Mostrar());
            }
            return cadena.ToString();
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            bool retorno = false;
            if (!(financiera is null) && !(prestamo is null))
            {
                foreach (Prestamo p in financiera.listaDePrestamos)
                {
                    if (p == prestamo)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
            

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator + (Financiera financiera, Prestamo prestamoNuevo)
        {
            if (!(financiera is null) && !(prestamoNuevo is null))
            {
                if (financiera!=prestamoNuevo)
                {
                    financiera.listaDePrestamos.Add(prestamoNuevo);
                }
                
            }
            return financiera;
        }
    }
}
