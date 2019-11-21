using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException : Exception
    {
        public PatenteInvalidaException(string msj) : this ("Patente invalida", null)
        {

        }
        public PatenteInvalidaException(string msj, Exception inner) : base (msj,inner)
        {

        }
    }
}
