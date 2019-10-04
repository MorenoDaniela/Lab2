using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {
        public MiClase ()
        {
            try
            {
                MetodoEstatico();
            }
            catch(DivideByZeroException e)
            {
                throw new DivideByZeroException("Primer constructor");
            }
        }

        public MiClase(int dec)
        {
            try
            {
                MiClase aux = new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("Constructor con parametro", e);
            }
        }

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }

        /*
        public Exception MiException(string msj, Exception e)
        {
            Exception retorno = new Exception(msj, e);
            return retorno;
        }*/

        
    }
}
