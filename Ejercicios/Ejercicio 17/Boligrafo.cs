using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short  cantidadTintaMaxima=100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
            //this.cantidadTintaMaxima = 100;
        }

        public ConsoleColor GetColor(Boligrafo lapicera)
        {
            return lapicera.color;
        }

        public short GetTinta (Boligrafo lapicera)
        {
            return lapicera.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta +=tinta;

            if (this.tinta>100)
            {
                this.tinta = 100;
            }else if (this.tinta<0)
            {
                this.tinta = 0;
            }
        }

        public void Recargar ()
        {
            this.SetTinta(100);//verificar
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            string aux = "*";
            dibujo = "";

           
            if (this.tinta<=gasto)
            {
                for (;this.tinta>0;this.tinta--)
                {
                    dibujo += aux; ;
                    
                    //Console.WriteLine("{0}", dibujo);
                    
                }
                retorno = true;
            }else
            {
                for(;gasto>0;gasto--)
                {
                    dibujo += aux;
                }
                retorno = true;
            }
            this.SetTinta((short)-gasto);

            Console.ForegroundColor = this.GetColor(this);
            return retorno;

        }
    }
}
