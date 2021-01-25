using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMock
{
   public interface IPuntuacion
    {
         int Promedio { get; set; }

        int Calcular(int examen);
        double PorcentajeNota ();

    }
}
