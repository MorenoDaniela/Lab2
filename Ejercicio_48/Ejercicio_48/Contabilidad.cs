using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if (!(c is null) && !(egreso is null))
            {
                c.egresos.Add(egreso);
            }
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (!(c is null) && !(ingreso is null))
            {
                c.ingresos.Add(ingreso);
            }
            return c;
        }

    }
}