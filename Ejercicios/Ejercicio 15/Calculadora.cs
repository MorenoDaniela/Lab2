using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public static class Calculadora
    {
        public static float Calcular (int primerNumero, int segundoNumero, char operacion)
        {
            float resultado= new float();

            switch (operacion)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if (Calculadora.Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    else
                        Console.WriteLine("El divisor no puede ser 0.");
                    
                    break;
                default:
                    break;
            }
        return resultado;
        }

        private static bool Validar(int numero)
        {
            bool retorno = false;

            if (numero>0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
