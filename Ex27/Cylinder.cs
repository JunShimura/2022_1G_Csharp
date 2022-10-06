using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
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
            return radius*radius*(float)Math.PI *height;
        }
        public float GetSurface()
        {
            //return (radius * radius * (float)Math.PI * 2 + radius * 2 * (float)Math.PI * height);
            return (radius * (float)Math.PI * 2 * (radius + height));
        }
    }
}
