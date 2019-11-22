using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestsUnitarios
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Xml<List<Planeta>> xml = new Xml<List<Planeta>>();
            List<Planeta> lista = new List<Planeta>();
            xml.Leer("emoji triste", out lista);
                
        }
    }
}
