using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660, CS0661
    public class Centralita
    {

        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
        }

        public Centralita()
        {
            //this.Llamadas = new List<Llamada>(Llamadas);
            this.listaLlamadas = new List<Llamada>();

        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada llamada in listaLlamadas)
            {
                //(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas && llamada is Local)
                if (tipo == Llamada.TipoLlamada.Local && llamada is Local)
                {
                    ganancia = ganancia + ((Local)llamada).CostoLlamada;
                }
                //(tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas && llamada is Provincial)
                else if (tipo == Llamada.TipoLlamada.Provincial && llamada is Provincial)
                {
                    ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                }else if (tipo == Llamada.TipoLlamada.Todas)
                {
                    ganancia = ganancia + llamada.CostoLlamada;
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            string aux = "";
            cadena.AppendLine("Razon social: " + this.razonSocial);
            cadena.AppendLine("Ganancia total: " + GananciasPorTotal);
            foreach (Llamada call in listaLlamadas)
            {
                if (call is Local)
                {
                    aux = ((Local)call).ToString();
                }
                else if (call is Provincial)
                {
                    aux = ((Provincial)call).ToString();
                }
                cadena.AppendLine(aux);
            }
            return cadena.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada call)
        {
            this.listaLlamadas.Add(call);
        }

        public static bool operator ==(Centralita c, Llamada call)
        {
            bool retorno = false;

            if (!(c is null) && !(call is null))
            {
                foreach (Llamada llamada in c.listaLlamadas)
                {
                    if (llamada == call)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada call)
        {
            bool retorno = true;
            if (c == call)
            {
                retorno = false;
            }
            return retorno;
        }

        public static Centralita operator +(Centralita c, Llamada call)
        {
            Centralita central = null;
            if (!(c is null) && !(call is null))
            {
                central = c;
                if (c != call)
                {
                    c.AgregarLlamada(call);
                    central = c;
                }
            }

            return central;
        }
    }
}
