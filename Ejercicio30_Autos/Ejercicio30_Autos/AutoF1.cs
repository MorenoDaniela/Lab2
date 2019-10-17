using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30_Autos
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;

        }
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1.numero == a2.numero && a1.escuderia == a2.escuderia)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }


        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            if (this.enCompetencia)
            {
                cadena.AppendLine("Auto en competencia");
                cadena.AppendFormat("Combustible: {0} Escuderia: {1} Numero: {2} Vueltas restantes: {3}", this.cantidadCombustible, this.escuderia, this.numero, this.vueltasRestantes);

            }else
            {
                cadena.AppendLine("Auto fuera de competencia");
                cadena.AppendFormat("Combustible: {0} Escuderia: {1} Numero: {2} Vueltas restantes: {3}", this.cantidadCombustible, this.escuderia, this.numero, this.vueltasRestantes);
            }
            return cadena.ToString();
            
        }
    }
}
