using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
#pragma warning disable CS0660, CS0661//desactivar warnings
    public class Cliente
    {

        private string nombre;
        private int numero;

        public int Numero
        {
            
            get { return numero; }
            //set { numero = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
         

        public Cliente (int numero)
        {
            this.numero = numero;
        }

        public Cliente (int numero, string nombre)
        : this (numero)
        {
            Nombre = nombre;
        }

        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;

            if (!(cliente1 is null) && !(cliente2 is null))
            {
                if (cliente1.numero == cliente2.numero)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            bool retorno = false;

            if (!(cliente1 is null) && !(cliente2 is null))
            {
                if (cliente1.numero != cliente2.numero)
                {
                    retorno = true;
                }
            }
            return retorno;
        }




    }
}
