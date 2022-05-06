using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Clase11;

namespace TestDrivenDevelopment
{
    [TestClass]
    public class TestCalculadoraString
    {
        [TestMethod]
        public void Add_NumerosSeparadosPorComa_DevolverLaSuma()
        {
            string numeros = "1,2";
            int expected = 1 + 2;
            int actual = 0;

            actual = Calculadora.Add(numeros);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AdmiteSaltosDeLineaEntreNumerosEnLugarDeComas_DevolverLaSuma()
        {
            string numeros = "1\n2,3";
            int expected = 6;
            int actual = 0;

            actual = Calculadora.Add(numeros);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_SoportaDistintosDelimitadores_DevolverLaSuma()
        {
            string numeros = "//;\n1;2";
            int expected = 3;
            int actual = 0;

            actual = Calculadora.Add(numeros);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_CuandoRecibaUnNumeroNegativo_LanzarExcepcion()
        {
            string numeros = "-1";

            Calculadora.Add(numeros);
           
        }
    }
}
