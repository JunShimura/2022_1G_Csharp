using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex29
{
    internal class Cylinder
    {
        private float radius;
        private float height;
        
        public Cylinder(float radius, float height)
        {
            this.radius = radius;
            this.height = height;
        }

        public float GetVolume()
        {
            return GetVolume(radius, height);
        }
        static public float GetVolume(float radius, float height)
        {
            return (float)(radius *radius*Math.PI *height);
        }
        public float GetSurface()
        {
            return GetSurface(radius, height);
        }
        static public float GetSurface(float radius, float height)
        {
            return (float)(radius * Math.PI * 2 * (radius + height));
        }
    }
}
