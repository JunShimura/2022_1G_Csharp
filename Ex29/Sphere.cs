using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29
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
            return GetVolume(radius);
        }
        public static float GetVolume(float radius)
        {
            return (float)(4 * Math.PI * radius * radius * radius / 3);
        }
        public float GetSurface()
        {
            return GetSurface(radius);
        }
        public static float GetSurface(float radius)
        {
            return (float)(4 * Math.PI * radius * radius);
        }
    }
}
