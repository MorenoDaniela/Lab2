using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        //private int myVar;

        public Cliente Cliente
        {
            get { return Cliente; }
            set { clientes = value; }
        }


    }
}
