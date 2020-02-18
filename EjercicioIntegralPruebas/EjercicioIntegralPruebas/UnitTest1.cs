using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EjercicioIntegralPruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToxicidadVerde()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("VERDE", obj.ObtenerNivelToxicidad(3.80));
        }

        [TestMethod]
        public void TestToxicidadAzulLI()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("AZUL", obj.ObtenerNivelToxicidad(3.81));
        }

        [TestMethod]
        public void TestToxicidadAzulLS()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("AZUL", obj.ObtenerNivelToxicidad(8.25));
        }

        [TestMethod]
        public void TestToxicidadAmarilloLI()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("AMARILLO", obj.ObtenerNivelToxicidad(8.26));
        }
        [TestMethod]
        public void TestToxicidadAmarilloLS()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("AMARILLO", obj.ObtenerNivelToxicidad(15));
        }
        [TestMethod]
        public void TestToxicidadRojo()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("ROJO", obj.ObtenerNivelToxicidad(15.1));
        }

        [TestMethod]
        public void TestToxicidadRojoLS()
        {
            HU1 obj = new HU1();
            Assert.AreEqual("ROJO", obj.ObtenerNivelToxicidad(100));
        }

    }
}
