using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMock
{
    public class Puntuacion : IPuntuacion
    {
        public Puntuacion()
        {
        }
        public int Promedio { get; set; }
        public int NotaTotal { get; set; }

        public int Calcular (int examen)
        {
            return Promedio + examen;
        }


        public double PorcentajeNota()
        {
            return NotaTotal / Convert.ToDouble(Promedio);
        }
    }
}
