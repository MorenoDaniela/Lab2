using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Verdura : ReinoVegetal, IVegetales
    {
        // Tipos del enumerado Semilla, Raíz, Tubérculo, Bulbo, Tallo, Hoja, Inflorescencia, Rizoma

        public enum TipoVerdura { Semilla, Raíz, Tubérculo, Bulbo, Tallo, Hoja, Inflorescencia, Rizoma }

        private TipoVerdura tipo;

        public Verdura(float valor, Gusto gusto, TipoVerdura tipo)
            : base(valor, gusto)
        {
            this.tipo = tipo;
        }

        public TipoVerdura Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder message = new StringBuilder();

            message.Append(base.ToString());
            message.AppendFormat("TIPO: {0}\n", this.Tipo);

            return message.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }

}
