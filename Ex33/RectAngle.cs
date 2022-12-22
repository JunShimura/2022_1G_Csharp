using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }

        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }
        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            RectAngle ans = new RectAngle(float.MaxValue,float.MaxValue);
            List<RectAngle> candidates = new List<RectAngle>()
            {
                Plus(rectAngle1.width,rectAngle2.width, rectAngle1.height,rectAngle2.height),
                Plus(rectAngle1.width, rectAngle2.height, rectAngle1.height, rectAngle2.width),
                Plus(rectAngle1.height, rectAngle2.width, rectAngle1.width, rectAngle2.height),
                Plus(rectAngle1.height, rectAngle2.height, rectAngle1.width, rectAngle2.width)
            };
            //ans = candidates.Min(candidate => candidate.GetSurface);
            foreach (RectAngle candidate in candidates)
            {
                if (ans.GetSurface() > candidate.GetSurface())
                {
                    ans = candidate;
                }
            }

            return ans;
        }
        private static RectAngle Plus(float l1, float l2, float l3, float l4)
        {
            return new RectAngle(l1 + l2, (l3 > l4) ? l3 : l4);
        }
    }
}
