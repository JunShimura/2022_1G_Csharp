using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26
{
    internal class Box
    {
        private float width;
        private float height;
        private float depth;
        public Box(float w, float h, float d)
        {
            this.width = w;
            this.height = h;
            this.depth = d;
        }
        public Box(float w = 1)
        {
            this.width = w;
            this.height = w;
            this.depth = w;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }
        public float GetSurface()
        {
            return (width * height + height * depth + depth * width) * 2;
        }
    }
}
