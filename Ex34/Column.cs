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
        protected IShape shape;
        public Column(IShape shape, float height)
        {
            this.shape = shape;
            this.height = height;
        }
        public float Volume
        {
            get=>shape.Surface * this.height;
        }
        public float Surface
        {
            get=>shape.Surface * 2 + shape.Circumference * this.height;
        }
    }
    internal class Column<T> : ISolid where T : IShape
    {
        protected float height;
        protected T shape;
        public Column(T shape, float height)
        {
            this.shape = shape;
            this.height = height;
        }
        public float Volume
        {
            get => shape.Surface * this.height;
        }
        public float Surface
        {
            get => shape.Surface * 2 + shape.Circumference * this.height;
        }
    }

}
