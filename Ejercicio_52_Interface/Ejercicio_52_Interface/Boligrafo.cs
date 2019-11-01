using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_Interface
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo (int unidades, ConsoleColor color)
        {
            this.tinta = (float)unidades;
            this.colorTinta = color;
        }

        //implicita
        public EscrituraWrapper Escribir(string texto)
        {
            string aux="";
            int i;
            for (i=0;((IAcciones)this).UnidadesDeEscritura>0.3 && i<texto.Length;i++)
            {
                aux += texto[i];
                this.tinta -= (float)0.3;
            }
            EscrituraWrapper escritura = new EscrituraWrapper(this.colorTinta, aux);
            return escritura;
        }

        public bool Recargar (int unidades)
        {
            bool retorno = false;
            if (unidades>=0)
            {
                ((IAcciones)this).UnidadesDeEscritura += unidades;
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Boligrafo\n Tinta: {0} Color: {1} \n", this.tinta, this.colorTinta);
            return cadena.ToString();
        }


    }
}
