using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class EstadoSimulacion
    {
        public static string EstadoSimulacionn(this bool nombre)
        {
            if (nombre is true)
            {
                return "Orbitando";

            }else
            {
                return "Detenido";
            }
        }
    }
}
