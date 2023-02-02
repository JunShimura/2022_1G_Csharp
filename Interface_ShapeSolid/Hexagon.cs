using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ShapeSolid
{
    internal struct Hexagon : IShape
    {
        private float radius;
        public Hexagon(float radius)
        {
            this.radius = radius;
        }
        public float Radius { get { return radius; } }
        public float Width { get { return radius*2; } }
        public float Height { get { return radius*2; } }
        public float Surface { get { return (float)(radius*radius*3*Math.Sqrt(3)/2); } }
        public float Circumference { get { return (float)(radius * 6); } }
    }
}
