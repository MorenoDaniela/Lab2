using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Patente
    {
        private Tipo tipoCodigo;
        private string codPatente;
        public enum Tipo
        {
            Vieja,
            Mercosur
        }
        

        public Patente()
        {

        }

        public Patente(string codPatente, Tipo tipo)
        {
            this.CodigoPatente = codPatente;
            this.TipoCodigo = tipo;
        }

        public string CodigoPatente
        {
            get
            {
                return this.codPatente;
            }
            set
            {
                this.codPatente = value;//validar?
            }
        }

        public Tipo TipoCodigo
        {
            get
            {
                return this.tipoCodigo;
            }
            set
            {
                this.tipoCodigo = value;//validar?
            }
        }

        public override string ToString()
        {
            return this.CodigoPatente;
        }
    }
}
