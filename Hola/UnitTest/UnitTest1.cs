using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_NoAgregaException()
        {
            try
            {
               //Verdura v0 = new Verdura((float)2.5, ReinoVegetal.Gusto.Salado, Verdura.TipoVerdura.Hoja);
                Fruta v1 = new Fruta((float)2.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Red);
                Fruta v2 = new Fruta((float)1.5, ReinoVegetal.Gusto.Toxica, ConsoleColor.Blue);
                Fruta v3 = new Fruta((float)0.5, ReinoVegetal.Gusto.Salado, ConsoleColor.Black);

                Canasta<Fruta> canasta = new Canasta<Fruta>(2);

                //canasta += v0;
                canasta += v1;
                canasta += v2;
                canasta += v3;

                Assert.Fail("No se tiro la excepcion correspondiente");
            }
            catch (Exception excepcion)
            {
               Assert.IsTrue(excepcion is NoAgregaException);
            }
        }
    }
}
