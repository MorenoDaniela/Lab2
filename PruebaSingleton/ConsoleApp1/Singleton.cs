using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Singleton
    {
        private static Singleton instancia;

        private Singleton()
        {

        }
        public static Singleton CreateInstance()
        {
            if (instancia == null)
            {
                Singleton.instancia = new Singleton();
                return Singleton.instancia;
            }
            else
                return instancia;
        }
        public Singleton Instancia
        {
            get
            {
                return CreateInstance();
            }
        }
        
    }
}

