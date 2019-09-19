using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks
using System.Threading;

namespace Sistema
{
    class PuestoAtencion
    {
        private static int numeroActual;
        PuestoAtencion puesto;

        public int NumeroActual
        {
            get { return numeroActual; }
            //set { numeroActual = value; }
        }

        public bool Atender(Cliente clien)
        {
            bool retorno = false;
            Thread.sleep(2000);



        }
    }
}
