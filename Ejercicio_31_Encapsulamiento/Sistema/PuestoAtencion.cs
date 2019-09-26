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
        Puesto puesto;

        public static int NumeroActual
        {
            get { return numeroActual+1; }
            //set { numeroActual = value; }
        }

        public bool Atender(Cliente clien)
        {
            bool retorno = false;
            if (!(clien is null))
            {
                Thread.Sleep(2000);
                retorno = true;
            }
            return retorno;
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }


        public enum Puesto
        {
            Caja1,
            Caja2
        }


    }
}
