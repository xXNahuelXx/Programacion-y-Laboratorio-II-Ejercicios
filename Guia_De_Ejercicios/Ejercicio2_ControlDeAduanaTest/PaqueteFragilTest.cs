using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Clase13;

namespace Ejercicio2_ControlDeAduanaTest
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            PaqueteFragil pf = new PaqueteFragil("123aaa",500,"Lanus","Lomas",5);

            bool resultado = pf.TienePrioridad;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            PaqueteFragil pf = new PaqueteFragil("123aaa", 500, "Lanus", "Lomas", 5);
            decimal expected = 175;

            decimal actual = pf.Impuestos;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            PaqueteFragil pf = new PaqueteFragil("123aaa", 500, "Lanus", "Lomas", 5);
            decimal expected = 675;

            decimal actual = pf.AplicarImpuestos();

            Assert.AreEqual(expected, actual);
        }

    }
}
