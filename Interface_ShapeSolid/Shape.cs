using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal struct Shape:IShape
    {
        public float Surface { get; }
        public float Width { get; }
        public float Height { get; }
    }
}
