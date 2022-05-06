using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Clase11;

namespace TestParadaEnBoxes
{
    [TestClass]
    public class TestCompetencia
    {
        [TestMethod]
        public void ListaVehiculos_CuandoSeInstanciaUnaCompetencia_DebeDevolverLaListaInstanciada()
        {
            Competencia competencia = new Competencia(5,5,Competencia.TipoCompetencia.F1);
            Assert.IsNotNull(competencia.Vehiculos);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Add_CuandoSeAgregueUnAutoF1EnMotoCross_DebeDevolverCompetenciaNoDisponibleException()
        {
            AutoF1 autito = new AutoF1(123, "Ferrari");
            Competencia cmp = new Competencia(5,5,Competencia.TipoCompetencia.MotoCross);
            bool loAgrega = cmp + autito;
        }

        [TestMethod]
        public void Add_CuandoSeAgregueMotoEnCompetenciaDeMoto_DebeDevolverTrue()
        {
            MotoCross motito = new MotoCross(123, "Batimoto");
            Competencia cmpMotos = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
            bool loAgrega = cmpMotos + motito;
            Assert.IsTrue(loAgrega);
        }

        [TestMethod]
        public void Add_CuandoSeAgregueVehiculoEnCompetenciaQueSeHayaAñadidoCorrectamente_DebeDevolverTrue()
        {
            Competencia cmpMotos = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross motito = new MotoCross(123, "Batimoto");
            bool loAgrega = cmpMotos + motito;
            bool existe = cmpMotos == motito;
            Assert.IsTrue(existe);
        }

        [TestMethod]
        public void Add_CuandoSeQuiteVehiculoEnCompetenciaQueSeHayaQuitadoCorrectamente_DebeDevolverTrue()
        {
            MotoCross motito = new MotoCross(123, "Batimoto");
            Competencia cmpMotos = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);

            bool loAgrega = cmpMotos + motito;
            bool loQuita = cmpMotos - motito;
            bool existe = cmpMotos != motito;

            Assert.IsTrue(existe);
        }
    }
}
