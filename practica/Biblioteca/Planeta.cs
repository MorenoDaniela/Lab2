using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private ETipo tipo;


        private List<Astro> satelites;

        public List<Astro> Satelites
        {
            get { return satelites; }
        }

        public Planeta (int duraOrb, int duraRota, string nombre)
            : base (duraOrb,duraRota,nombre)
        {
            satelites = new List<Astro>();
        }

        public Planeta(int duraOrb, int duraRota, string nombre, int cantSatelites,ETipo tipo)
            : this(duraOrb, duraRota, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }
        
        public static bool operator ==(Planeta p1, Planeta p2)
        {
            bool retorno = false;
            if (!(p1 is null) && !(p2 is null))
            {
                if ((string)p1== (string)p2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }


        public static bool operator ==(Planeta p1, Satelite s1)
        {
            bool retorno = false;
            if (!(p1 is null) && !(s1 is null))
            {
                foreach (Satelite sat in p1.satelites)
                {
                    //if (sat is Satelite)
                    //{
                        if (sat.Nombre==s1.Nombre)
                        {
                            retorno = true;
                            break;
                        }
                    //}
                }
            }
            return retorno;
        }

        public static bool operator !=(Planeta p1, Satelite s1)
        {
            return !(p1 == s1);
        }

        public static bool operator +(Planeta planeta, Astro astro)
        {   
            bool retorno = false;
            if (!(planeta is null) && !(astro is null))
            {
                if (planeta.cantSatelites > planeta.satelites.Count)
                {
                    if (astro is Satelite)
                    {
                        planeta.satelites.Add(astro);
                        retorno = true;
                    }
                }
                
            }
            return retorno;
        }

        public override string Orbitar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Orbita el planeta: {0} \n", this.nombre);
            return cadena.ToString();
        }

        public new string Rotar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Orbita el planeta: {0} \n", this.nombre);
            return cadena.ToString();
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.Mostrar());
            cadena.AppendFormat("Cantidad satelites: {0} \n", this.cantSatelites);
            cadena.AppendFormat("Tipo: {0} \n", this.tipo);
            cadena.AppendFormat(this.Orbitar());
            cadena.AppendFormat(this.Rotar());

            return cadena.ToString();
        }
    }
}
