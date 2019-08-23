using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public static class  Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string retorno = "FALSE";
            string aux="";
            
            while (numero>0)
            {
                if (numero%2==0)
                {
                    aux = "0" + aux;
                }else
                {
                    aux = "1" + aux;
                }

                numero = numero / 2;
                retorno = aux;
            }
            return retorno;
        }


        public static double BinarioDecimal(string cadena)
        {
            double retorno = 0;

            retorno = Convert.ToInt64(cadena, 2).ToString();

            return retorno;

        }
    }
}
