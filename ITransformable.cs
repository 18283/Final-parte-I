using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ITransformable
    {
        
        void Trasladar(float x, float y, float z);
        void Escalar(float ve);
        void Rotar(float x, float y, float z);
        void Dibujar();
    }
}
