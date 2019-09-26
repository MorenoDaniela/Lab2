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
            get { return clientes.Dequeue(); }
            set { clientes.Enqueue(value); }
        }

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio (string nombre)
            : this ()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            //if (n.clientes.Contains(c))
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente==c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool retorno = true;
            if (n==c)
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n!=c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (!(n is null))
            {
                Cliente aux = n.Cliente;
                if (!(aux is null))
                {
                    if (n.caja.Atender(aux))
                    {
                        retorno = true;

                    }
                }
            }
            return retorno;
        }

    }
}
