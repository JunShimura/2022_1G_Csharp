using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Column : ISolid
    {
        protected float height;
        IShape shape;
        public Column(IShape shape, float height)
        {
            this.shape = shape;
            this.height = height;
        }
        public float Volume
        {
            get
            {
                return shape.Surface * this.height;
            }
        }
        public float Surface
        {
            get { return shape.Surface * 2 + shape.Circumference * this.height; }
        }
    }
}
