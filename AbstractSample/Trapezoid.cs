using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AbstractSample
{
    internal class Trapezoid : Surface
    {
        readonly public float top;
        readonly public float bottom;
        readonly public float left;
        readonly public float right;
        readonly public float height;
        public Trapezoid(float top, float bottom, float left, float right)
        {
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
            float x;
            float diff = bottom - top;
            //x=(l^2-r^2+b^2)/2b
            x = (left * left - right * right + diff * diff) / (2 * diff);
            height = (float)Math.Sqrt(left * left - x * x);
        }
        public override float GetSurface()
        {
            return (top + bottom) * height  / 2;
        }
        public override float GetCircumference()
        {
            return top + bottom + left + right;
        }
        public override void GetBounds(out float width, out float height)
        {
            width = bottom>top?bottom:top;
            height = this.height;
        }
    }
}
