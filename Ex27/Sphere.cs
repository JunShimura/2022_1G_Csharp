using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    internal class Sphere
    {
        private float radius;
        public Sphere(float radius)
        {
            this.radius = radius;
        }
        public float GetVolume()
        {
            return 4 * (float)Math.PI * radius * radius * radius / 3;
        }
        public float GetSurface()
        {
            return 4 * (float)Math.PI * radius * radius;
        }
    }
}
