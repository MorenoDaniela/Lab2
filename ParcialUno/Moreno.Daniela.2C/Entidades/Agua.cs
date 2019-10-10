using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private static int medida = 400;

        public Agua (int capacidadML,string marca, int contenidoML)
            :base (marca,capacidadML,contenidoML)
        {

        }

        public override int ServirMedida()
        {
            if (medida>=Contenido)
            {
                Contenido = Contenido - medida;
                
            }else if (medida>Contenido)
            {
                Contenido = Contenido - Contenido;
                
            }
            return Contenido;

        }

        public int ServirMedida(int medida)
        {
            return contenidoML - medida;
        }

        protected override string GenerarInforme()
        {
            return base.ToString();
        }
    }
}
