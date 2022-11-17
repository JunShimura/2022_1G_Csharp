using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Box:Column
    {
        public Box(float w, float h, float d)
        {

        }
        public Box(float w = 1)
        {
            this.width = w;
            this.height = w;
            this.depth = w;
        }
        public float GetVolume()
        {
            return GetVolume(this.width, this.height, this.depth);
        }
        public static float GetVolume(float width, float height, float depth)
        {
            return (float)((double)width * (double)height * (double)depth);
        }
        public float GetSurface()
        {
            return GetSurface(this.width, this.height, this.depth);
        }
        public static float GetSurface(float width, float height, float depth)
        {
            return (float)(((double)width * (double)height + (double)height * (double)depth + (double)depth * (double)width) * 2);
        }
    }
}
