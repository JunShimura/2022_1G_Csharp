using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSolid
{
    internal struct RectAngle : IShape
    {
        readonly float width;
        readonly float height;
        public RectAngle(float width = 0, float height = 0)
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
            get { return width * height; }
        }
        public float Circumference
        {
            get
            {
                return (width + height) / 2.0f;
            }
        }
         static public float GetSurface(float width,float height)
        {
            return width * height;
        }
    }
}
