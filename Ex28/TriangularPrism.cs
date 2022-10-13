using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28
{
    internal class TriangularPrism
    {
        private float width;
        private float depth;
        private float height;
        private float bottom;
        private float side;

        public TriangularPrism(float width, float depth, float height)
        {
            this.width = width;
            this.depth = depth;
            this.height = height;
            bottom = width*depth/2;
            side = height * (
                    width
                    + depth
                    + MathF.Sqrt(width * width + depth * depth));
        }
        public TriangularPrism(float l1, float l2,float l3, float height)
        {
            var s = (l1+l2+l3)/2;
            bottom = (float)Math.Sqrt(s * (s - l1) * (s - l2) * (s - l3));
            side = (l1 + l2 + l3) * height;
            this.height = height;
        }

        public float GetVolume()
        {
            return bottom*height;
        }
        public float GetSurface()
        {
            return side + bottom * 2;
        }
    }
}
