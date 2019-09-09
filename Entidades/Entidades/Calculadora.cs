using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string op = "+";
            if (operador=="-")
            {
                op = "-";
            }else if (operador=="/")
            {
                op = "/";
            }else if (operador=="*")
            {
                op = "*";
            }
            return op;
        }

        public static double Operar(Numero num1, Numero num2, string operador)
        {

        }
    }
}
