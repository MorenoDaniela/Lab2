using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CentralTelefonica
{
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

        public Centralita ()
        {
            //this.Llamadas = new List<Llamada>(Llamadas);
            this.listaLlamadas = new List<Llamada>();

        }
        public Centralita(string nombreEmpresa)
            :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia=0;

            foreach (Llamada llamada in listaLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas && llamada is Local)
                {
                    ganancia = ganancia + ((Local)llamada).CostoLlamada;
                }
                else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas && llamada is Provincial)
                {
                    ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
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
                    aux = ((Local)call).Mostrar();
                }else if (call is Provincial)
                {
                    aux = ((Provincial)call).Mostrar();
                }
                cadena.AppendLine(aux);
            }
            return cadena.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(IComparer<Llamada>.OrdenarPorDuracion);//no se como carajo hacer esto me harte. Ya probe todas las combinaciones T.T
        }

    }
}
