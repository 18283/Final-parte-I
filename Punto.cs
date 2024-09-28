using OpenTK;
using OpenTK.Graphics;

namespace ConsoleApp1
{
    public class Punto
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Punto()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }

        public Punto(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Set(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public (float, float, float) Get()
        {
            return (x, y, z);
        }

        public override string ToString()
        {
            return $"[{x:F2}]-[{y:F2}]-[{z:F2}]";
        }
    }
}
