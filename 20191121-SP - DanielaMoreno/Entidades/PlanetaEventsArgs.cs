using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class PlanetaEventsArgs : EventArgs
    {
        private short avance;
        private short radioRespectoSol;

        public short Avance
        {
            get
            {
                return this.avance;
            }
        }

        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }
        }

        public PlanetaEventsArgs(short avance, short radio)
        {
            this.avance = avance;
            this.radioRespectoSol = radio;
        }
    }
}
