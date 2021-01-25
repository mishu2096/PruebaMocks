using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMock
{
   public  interface IEstudiante
    {
      
        void Agregar(string producto, int cantidad);
        int Existencia(string producto);
    }
}
