using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27
{
    internal class TriangularPrism
    {
        private float width;
        private float depth;
        private float height;

        public TriangularPrism(float width, float depth, float height)
        {
            this.width = width;
            this.depth = depth;
            this.height = height;
        }
        public float GetVolume()
        {
            return width*depth/2*height;
        }
        public float GetSurface()
        {
            return width * depth 
                + height*(
                    width
                    +depth
                    +MathF.Sqrt(width*width+depth*depth));
        }
    }
}
