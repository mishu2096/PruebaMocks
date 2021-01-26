using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMock
{
    internal class Notas
    {
        public Notas()
        {
        }

        public int Examen { get; internal set; }
        public bool Sipaso { get; internal set; }
        public bool Nopaso { get; internal set; }

        internal void Pasa(IPuntuacion puntuacion)
        {
            if (Examen >=puntuacion.NotaMinima())
            {
             
                this.Sipaso = true;
            }
            else
            {
                this.Nopaso = false;
            }

        }
    }
}
