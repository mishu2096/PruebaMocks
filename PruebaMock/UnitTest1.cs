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
            puntuacion.AssertWasCalled(p => p.Calcular(notas.Examen));
            puntuacion.AssertWasCalled(p => p.PorcentajeNota());
            

        }
        [TestMethod]
        public void SiElPromedioMasElExamenPasa()
        {
            var puntuacion = MockRepository.GenerateStub<IPuntuacion>();
            puntuacion.Stub(t => t.PorcentajeNota()).Return(0.7);

            puntuacion.Promedio = 80;
            puntuacion.Calcular(90);

            var notas = new Notas();
            notas.Examen = 70;
            notas.Pasa(puntuacion);

            Assert.IsTrue(notas.Sipaso);
            puntuacion.AssertWasCalled(p => p.Calcular(notas.Examen));
            puntuacion.AssertWasCalled(p => p.PorcentajeNota());
            
        }

        [TestMethod]
        public void SiElPromedioMasElExamenEsMenorNoPasa()
        {
            var puntuacion = MockRepository.GenerateStub<IPuntuacion>();
            puntuacion.Stub(t => t.PorcentajeNota()).Return(0.7);

            puntuacion.Promedio = 40;
            puntuacion.Calcular(80);

            var notas = new Notas();
            notas.Examen = 65;
            notas.Pasa(puntuacion);
            Assert.IsTrue(notas.Sipaso);
            puntuacion.AssertWasCalled(p => p.Calcular(notas.Examen));
            puntuacion.AssertWasCalled(p => p.PorcentajeNota());
          
        }
    }
}
