using System;
namespace PruebaMock
{
   public interface IPuntuacion
    {
         int Promedio { get; set; }

        int Calcular(int examen);
        double PorcentajeNota ();

    }
}
