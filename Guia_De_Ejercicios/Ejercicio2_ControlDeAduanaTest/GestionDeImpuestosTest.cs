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
    public class GestionDeImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpeustosDeAduana()
        {
            GestionDeImpuestos gI = new GestionDeImpuestos();
            PaqueteFragil pf = new PaqueteFragil("123aaa", 500, "Lanus", "Lomas", 5);
            PaquetePesado pp = new PaquetePesado("156few", 300, "Avellaneda", "Banfield", 2);
            decimal expected = pf.Impuestos+pp.Impuestos; //280

            gI.RegistrarImpuestos(pf);
            gI.RegistrarImpuestos(pp);

            decimal actual = gI.CalcularTotalImpuestosAduana();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpeustosDeAfip()
        {
            GestionDeImpuestos gI = new GestionDeImpuestos();
            PaqueteFragil pf = new PaqueteFragil("123aaa", 500, "Lanus", "Lomas", 5);
            PaquetePesado pp = new PaquetePesado("156few", 300, "Avellaneda", "Banfield", 2);
            decimal expected = ((IAfip)pp).Impuestos;

            gI.RegistrarImpuestos(pf);
            gI.RegistrarImpuestos(pp);

            decimal actual = gI.CalcularTotalImpuestosAfip();

            Assert.AreEqual(expected, actual);
        }
    }
}
