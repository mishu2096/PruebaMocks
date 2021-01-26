using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace PruebaMock
{
    [TestClass]
    public class NotasTest
    {
        [TestMethod]
        public void SiTieneUnTotalDe70CuandoVerificoEntoncesSiPasa ()
        {
           
            var limite = MockRepository.GenerateStub<IPuntuacion>();
            limite.Stub(p => p.NotaMinima()).Return(0.7);

            var nota = new Notas ();
            nota.Examen = 70;
            nota.Pasa(limite);

            Assert.IsTrue(nota.Sipaso);
            limite.AssertWasCalled(p => p.NotaMinima());



        }
        [TestMethod]
        public void SiTieneUnaNotaTotalDeMas70SiPasa()
        {
            var puntuacion = MockRepository.GenerateStub<IPuntuacion>();
            puntuacion.Stub(t => t.NotaMinima()).Return(0.7);

           
            var notas = new Notas();
            notas.Examen = 80;
            notas.Pasa(puntuacion);

            Assert.IsTrue(notas.Sipaso);
            puntuacion.AssertWasCalled(p => p.NotaMinima());
            
        }

        [TestMethod]
        public void SiTieneUnaNotaMenorDe70NoPasa()
        {
            var puntuacion = MockRepository.GenerateStub<IPuntuacion>();
            puntuacion.Stub(t => t.NotaMinima()).Return(0.7);

            var notas = new Notas();
            notas.Examen = 65;
            notas.Pasa(puntuacion);

            Assert.IsFalse(notas.Nopaso);
            puntuacion.AssertWasCalled(p => p.NotaMinima());
          
        }
    }
}
