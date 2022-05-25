using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Clase13;

namespace Ejercicio2_ControlDeAduanaTest
{
    [TestClass]
    public class PaquetePesadoTest
    {

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado pp = new PaquetePesado("123aaa", 500, "Lanus", "Lomas", 5);

            bool resultado = pp.TienePrioridad;

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado pp = new PaquetePesado("123aaa", 500, "Lanus", "Lomas", 5);
            decimal expected = 175;

            decimal actual = pp.Impuestos;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            PaquetePesado pp = new PaquetePesado("123aaa", 500, "Lanus", "Lomas", 5);
            decimal expected = 125;

            decimal actual = ((IAfip)pp).Impuestos;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipyAduana()
        {
            PaquetePesado pp = new PaquetePesado("123aaa", 500, "Lanus", "Lomas", 5);
            decimal expected = 125+500+175;

            decimal actual = pp.AplicarImpuestos();

            Assert.AreEqual(expected, actual);
        }

    }
}
