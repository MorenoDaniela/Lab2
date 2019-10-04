using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class UnaException : Exception
    {
        public UnaException(string msj, Exception e)
            : base(msj,e)
        {

        }
        
    }
}
