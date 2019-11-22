using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivosException : Exception
    {
        public ErrorArchivosException(string msj) : this (msj, null)
        {

        }

        public ErrorArchivosException(string msj, Exception inner) : base (msj,inner)
        {

        }
    }
}
