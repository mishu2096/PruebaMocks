using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace PruebaMock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SiElEstudianteTieneMayorQue70PAsa()
        {
           
            var puntuacion = MockRepository.GenerateStub<IPuntuacion>();
            puntuacion.Stub(p => p.PorcentajeNota()).Return(0.7);

            var notas = new Notas ();
            notas.Examen = 70;
            notas.Pasa(puntuacion);

            Assert.IsTrue(notas.Sipaso);
            puntuacion.AssertWasCalled(p => p.PorcentajeNota());
            puntuacion.AssertWasCalled(p => p.Calcular(notas.Examen));

        }
    }
}
