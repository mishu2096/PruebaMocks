namespace PruebaMock
{
    public class Puntuacion : IPuntuacion
    {
        public Puntuacion()
        {
        }
        public int Examen { get; internal set; }
        public double NotaMinima()
        {
            return Examen ;
        }
    }
}
