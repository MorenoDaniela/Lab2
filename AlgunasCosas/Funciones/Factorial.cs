using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Factorial
    {
        public static int CalcularFactorial(string mensaje)
        {
            int retorno = 1;

            Console.WriteLine(mensaje);
            if (int.TryParse(Console.ReadLine(),out int numero))
            {
                for (int i = 1; i <= numero; i++)
                {
                    retorno = retorno * i;
                }
            }
            return retorno;
        }
    }
}
