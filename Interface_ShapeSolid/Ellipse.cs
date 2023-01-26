using ShapeSolid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ShapeSolid
{
    internal class Ellipse:IShape
    {
        public readonly float width;
        public readonly float height;
        public Ellipse(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public float Width
        {
            get { return width; }
        }
        public float Height
        {
            get { return height; }
        }
        public float Surface
        {
            get { return GetSurface(width, height); }
        }
        public float Circumference
        {
            get
            {
                return GetSurface(width, height);
            }
        }
        static public float GetSurface(float width, float height)
        {
            return (float)(width * height*Math.PI);
        }
    }
}
