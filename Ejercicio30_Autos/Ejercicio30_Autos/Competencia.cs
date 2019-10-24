using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30_Autos
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public enum TipoCompetencia
        {
            F1,
            Motocross
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return competidores[i];
            }
        }
        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { tipo = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        private Competencia()
        {
            competidores = new List <VehiculoDeCarrera>();
        }

        public Competencia(short vuelta, short competidores, TipoCompetencia tipo)
            : this()
        {
            this.cantidadVueltas = vuelta;
            this.cantidadCompetidores = competidores;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Cantidad competidores: {0} Cantidad vueltas: {1} Tipo: {2} \n", this.cantidadCompetidores, this.cantidadVueltas, this.tipo);
            return cadena.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if (!(c is null) && !(v is null))
            {
                foreach (VehiculoDeCarrera vehi in c.competidores)
                {
                    if (vehi is Motocross && c.tipo == Competencia.TipoCompetencia.Motocross)
                    {
                        retorno = true;
                    }else if (vehi is AutoF1 && c.tipo==Competencia.TipoCompetencia.F1)
                    {
                        retorno = true;
                    }
                }
            }
            
            return retorno;
        }
        
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if (!(c is null) && !(v is null))
            {
                if (c.cantidadCompetidores>c.competidores.Count && c==v)
                {
                    v.EnCompetencia = true;
                    Random numero = new Random();
                    int aux = numero.Next();
                    v.CantidadCombustible = (short)aux;
                    v.VueltasRestantes = c.cantidadVueltas;
                    c.competidores.Add(v);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if (!(c is null) && !(a is null))
            {
                c.competidores.Remove(a);
                retorno = true;
            }
            return retorno;
        }
    }
}
