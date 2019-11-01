using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_Interface
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            this.tamanioMina = (float)unidades;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            string aux = "";
            int i;
            for (i = 0; UnidadesDeEscritura > 0.1 && i < texto.Length; i++)
            {
                aux += texto[i];
                this.tamanioMina -= (float)0.1;
            }
            EscrituraWrapper escritura = new EscrituraWrapper(Color, aux);
            return escritura;
        }

        //explicita
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Lapiz\n Tamaño mina: {0} Color: {1} \n", this.tamanioMina, Color);
            return cadena.ToString();
        }





    }
}
