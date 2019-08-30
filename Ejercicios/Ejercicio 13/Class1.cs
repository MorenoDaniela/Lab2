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
            int numAux = (int)numero;
             
            string retorno = "FALSE";
            string aux="";
            
            if (numAux > 0)
            {
                while (numAux > 1)
                {
                    
                    if (numAux % 2 == 0)
                    {
                        aux = "0" + aux;
                        numAux = numAux / 2;

                    }
                    else
                    {
                        aux = "1" + aux;
                        numAux = numAux / 2;

                    }




                }
                
                if (numAux == 1)
                {
                    aux = "1" + aux;
                }
                retorno = aux;
            }
            
            return retorno;
        }

        /*
        public static double BinarioDecimal(string cadena)
        {
            int retorno = 0;
            int pos = cadena.Length;
            int potencia = cadena.Length;

            if (pos<8)
            {
                /*ConsoleKeyInfo j = Console.ReadKey();
                respuesta = j.KeyChar;
                if (cadena[pos]=="0")
                {

                }
            }
        
            
        }*/
    }
}
