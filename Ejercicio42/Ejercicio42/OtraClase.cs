using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                MiClase clase = new MiClase(2);
            }
            catch (UnaException e)
            {
                throw new MiException("Metodo instancia", e);
            }
        }
    }
}
