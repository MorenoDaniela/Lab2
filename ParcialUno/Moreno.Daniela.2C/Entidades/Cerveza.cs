using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private static int medida = 330;
        public Tipo tipo = Tipo.Vidrio;

        public Cerveza(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {
            //this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, string marca,Tipo tipo, int contenidoML)
            : this(capacidadML,marca,contenidoML)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {

            return Contenido - (int)(medida * 0.80);
        }

        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}", base.ToString());
            cadena.AppendFormat("Tipo: {0} \n", this.tipo);
            return cadena.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }



    }
}
