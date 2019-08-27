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
            
            if (numero>0)
            {
                while (numero>1)
                {
                    
                    if (numero % 2 == 0)
                    {
                        aux = "0" + aux;
                        //aux = aux+ "0";
                        //aux = string.Concat("0", numero);
                        numero = numero / 2;

                    }
                    else
                    {
                        aux = "1" + aux;
                        //aux = aux + "1";

                        //aux = string.Concat("1", numero);
                        numero = numero / 2;

                    }




                }
                
                if (numero == 1)
                {
                    //aux = string.Concat("1", numero);
                    aux = "1" + aux;
                }
                retorno = aux;
            }
            
            return retorno;
        }


        public static double BinarioDecimal(string cadena)
        {
            long numero;


            numero = Convert.ToInt64(cadena, 2);
            double retorno = BitConverter.Int64BitsToDouble(numero);

            return retorno;

        }
    }
}
