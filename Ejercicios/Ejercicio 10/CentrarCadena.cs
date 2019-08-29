using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    public static class CentrarCadena
    {
        public static string PadAmbos(this string cadena, int largo)
        {
            /*
            int espacios = largo - cadena.Length;
            int padIzquierda = espacios / 2 +cadena.Length;
            return cadena.PadLeft(padIzquierda).PadRight(largo);
            */

            if (cadena.Length >= largo)
            {
                return cadena;
            }
            int firstpad = (cadena.Length + largo) / 2;
            return cadena.PadLeft(firstpad).PadRight(largo);
        }
    }
}
