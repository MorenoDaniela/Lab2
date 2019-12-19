using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Verdura : ReinoVegetal, IVegetales
    {
        public enum TipoVerdura
        {
            Semilla, 
            Raíz,
            Tuberculo,
            Bulbo,
            Tallo,
            Hoja,
            Inflorescencia,
            Rizoma
        }
        // Tipos del enumerado Semilla, Raíz, Tubérculo, Bulbo, Tallo, Hoja, Inflorescencia, Rizoma
        private TipoVerdura tipo;

        public TipoVerdura Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public Gusto GustoVerdura
        {
            get
            {
                return this.gusto;
            }
        }

        public float Valor
        {
            get
            {
                return this.valor;
            }
        }

        public Verdura(float valor, Gusto gusto, TipoVerdura tipo) : base (valor, gusto)
        {
            // Completar
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Valor: {0} Gusto: {1} Tipo: {2}", this.valor, this.gusto, this.tipo);
            return cadena.ToString();
        }
    }
}
