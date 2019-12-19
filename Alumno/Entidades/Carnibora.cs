using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carnibora : ReinoVegetal, IVegetales
    {
        public enum Captura
        {
            Pinzas,
            Caida,
            Mecanicas,
            Combinada,
            Pelos
        }
        // Tipos del enumerado: Pinzas, Pelos, Caída, Mecánicas, Combinada
        private Captura tipo;
        private int tamanio;

        public float Valor
        {
            get
            {
                return this.valor;
            }
        }

        public Gusto GustoCarnibora
        {
            get
            {
                return this.gusto;
            }
        }

        public Captura Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }
        public Carnibora(float valor, Gusto gusto, Captura tipo) : base (valor,gusto)
        {
            // Completar
            this.tipo = tipo; //falta tamaño
        }

        public Carnibora(float valor, Gusto gusto, Captura tipo, int tamanio) : this (valor,gusto,tipo)
        {
            // Completar
            this.tamanio = tamanio;
        }

        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Valor: {0} Gusto: {1} Tipo: {2} Tamaño: {3} ", this.valor, this.gusto, this.tipo, this.tamanio);
            return cadena.ToString();
        
        }
    }
}
