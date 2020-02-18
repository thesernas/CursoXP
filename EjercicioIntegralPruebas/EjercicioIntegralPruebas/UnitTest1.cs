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

        [TestMethod]
        public void TestGradoToxicidadPairWise1()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 6, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "10-20", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "ALTA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "BÁSICO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "MTP", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "ACTIVO", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise2()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 6, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "20-30", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "BAJA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "ALCALINO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "HOMEOPÁTICO", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "EXCIPIENTE", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise3()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 6, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "20-30", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "MEDIA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "ALCALINO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "HOMEOPÁTICO", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "EXCIPIENTE", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise4()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 7, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "20-30", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "MEDIA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "BASICO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "HOMEOPÁTICO", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "EXCIPIENTE", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise5()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 7, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "20-30", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "ALTA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "ALCALINO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "HOMEOPÁTICO", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "ACTIVO", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise6()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 7, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "10-20", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "BAJA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "ALCALINO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "MTP", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "EXCIPIENTE", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise7()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 7, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "10-20", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "BAJA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "BASICO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "MTP", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "EXCIPIENTE", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }

        [TestMethod]
        public void TestGradoToxicidadPairWise8()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 7, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "10-20", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "MEDIA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "ALCALINO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "MTP", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "EXCIPIENTE", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }
        [TestMethod]
        public void TestGradoToxicidadPairWise9()
        {
            HU2 Obj = new HU2();
            var ObjE = new Elemento();
            ObjE.PH = new Propiedad() { ValorRecibido = 7, ValorPonderado = 0 };
            ObjE.NP = new Propiedad() { ValorRecibido = "20-30", ValorPonderado = 0 };
            ObjE.CN = new Propiedad() { ValorRecibido = "ALTA", ValorPonderado = 0 };
            ObjE.Acidez = new Propiedad() { ValorRecibido = "ALCALINO", ValorPonderado = 0 };
            ObjE.Tipo = new Propiedad() { ValorRecibido = "HOMEOPÁTICO", ValorPonderado = 0 };
            ObjE.Composicion = new Propiedad() { ValorRecibido = "ACTIVO", ValorPonderado = 0 };

            Assert.AreEqual(-1, Obj.ObtenerGradoToxicidad(ObjE));
        }
    }
}
