using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUnitarioCentralita;
using Entidades;

namespace TestUnitarioCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCentralNull()
        {
            Centralita central = new Centralita("Daniela");
            Assert.IsNotNull(central.Llamadas);
            
        }

        [TestMethod]
        [ExpectedException (typeof (CentralitaException))] 
        
        public void TestCargarLocal()
        {
            Centralita central = new Centralita("daniela");
            Llamada call = new Local("111", 10, "222", 1);
            Llamada call2 = new Local("111", 10, "222", 1);
            Llamada call3 = new Local("222", 10, "342", 1);
  
            central += call;
            central += call2;
            central += call3;
            
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestCargarProvincial()
        {
            Centralita central = new Centralita("daniela");
            Llamada call = new Provincial("111", Provincial.Franja.Franja_3, 12, "222");
            Llamada call2 = new Provincial("111", Provincial.Franja.Franja_3, 12, "222");
            Llamada call3 = new Provincial("123", Provincial.Franja.Franja_3, 12, "435");

            central += call;
            central += call2;
            central += call3;
        }

        [TestMethod]

        public void CargarDos()
        {
            Centralita central = new Centralita("daniela");
            Llamada call = new Local("111", 10, "222", 1);
            Llamada call2 = new Local("111", 10, "222", 1);
            Llamada call3 = new Provincial("111", Provincial.Franja.Franja_3, 12, "222");
            Llamada call4 = new Provincial("111", Provincial.Franja.Franja_3, 12, "222");
            Assert.AreNotEqual(call, call3);
            Assert.AreNotEqual(call2, call4);
            Assert.AreNotEqual(call, call4);
            Assert.AreNotEqual(call2, call3);
            Assert.AreEqual(call, call2);
            Assert.AreEqual(call3, call4);
        }
    }
}
