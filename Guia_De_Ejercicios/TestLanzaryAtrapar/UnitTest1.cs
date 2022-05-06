using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades_Clase11;

namespace TestLanzaryAtrapar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiMetodo_CuandoSeQuiereDividirPorCero_DeberiaDevolverDevideByZeroException()
        {
            MiClase.MiMetodo();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClaseConstructor_CuandoSeQuiereDividirPorCero_DeberiaDevolverDevideByZeroException()
        {
            new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClaseConstructorConParametro_CuandoSeQuiereDividirPorCero_DeberiaDevolverUnaExcepcion()
        {
            new MiClase(2);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void OtroMetodoDeOtraClase_CuandoInstancieMiClaseConParametro_DeberiaDevolverMiExcepcion()
        {
            OtraClase otraClase = new OtraClase();
            otraClase.OtroMetodo();
        }
    }
}
