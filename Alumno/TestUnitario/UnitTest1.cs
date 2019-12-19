using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [ExpectedException(typeof(NoAgregaException))]
        public void Test()
        {
            Fruta v2 = new Fruta((float)12.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Blue);
            Fruta v3 = new Fruta((float)10.2, ReinoVegetal.Gusto.Dulce, ConsoleColor.Green);
            Fruta v1 = new Fruta((float)2.5, ReinoVegetal.Gusto.Dulce, ConsoleColor.Red);


            Canasta<Fruta> canasta1 = new Canasta<Fruta>(2);


            canasta1 += v2;
            canasta1 += v3;
            canasta1 += v1;

        }
    }
}
