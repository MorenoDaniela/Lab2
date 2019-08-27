using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double retorno = 0;
            if (lado>0)
            {
                retorno = lado * lado;
            }
            

            return retorno;
        }

        public static double CalcularTriangulo(double base1, double altura)
        {
            double retorno = 0;
            if (base1>0 && altura>0)
            {
                retorno = (base1 * altura)/2;
            }
            return retorno;
        }


        public static double CalcularCirculo(double radio)
        {
            double retorno = 0;
            if (radio>0)
            {
                retorno=3.14 * radio * radio;
            }
            return retorno;
        }

    }
}
