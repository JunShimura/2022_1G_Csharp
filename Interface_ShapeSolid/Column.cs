using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal class Column:ISolid
    {
        protected float height;
        Shape shape;
        public Column(Shape shape,float height) {
            this.shape = shape;
            this.height= height;
        }
        public Column(string name) { }
        public float Volume {
            get
            {
                return shape.Surface * this.height;
            }
        }
    }
}
