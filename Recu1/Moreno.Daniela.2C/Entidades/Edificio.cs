using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        private Cantina[] cantinas;
        private const short limiteCantinas = 2;
        private static Edificio singleton;

        private Edificio ()
        {
            cantinas = new Cantina[limiteCantinas];
        }

        static Edificio()
        {
            if (singleton is null)
            {
                singleton = new Edificio();

            }
        }

        public Edificio GetBar()
        {
            return singleton;
        }

        public static bool operator + (Edificio e, Cantina c)
        {
            bool retorno = false;
            int i;
            if (!(e is null) && !(c is null))
            {
                for (i=0;i<limiteCantinas;i++)
                {
                    if (e.cantinas[i] is null)
                    {
                        e.cantinas[i] = c;
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }


}
