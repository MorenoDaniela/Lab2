using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Fruta : ReinoVegetal, IVegetales
    {
        private ConsoleColor color;
        
        public Fruta(float valor, Gusto gusto, ConsoleColor color) : base (valor,gusto)
        {
            this.color = color;
            // Completar
        }

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
        }

        public float Valor
        {
            get
            {
                return this.valor;
            }
        }

        public Gusto GustoFruta
        {
            get
            {
                return this.gusto;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Valor: {0} Gusto: {1} Color: {2}", this.valor, this.gusto,this.color);
            return cadena.ToString();
        }

    }
}
