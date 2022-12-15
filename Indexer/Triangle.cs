using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class Triangle : Surface
    {
        readonly public float length0;
        readonly public float length1;
        readonly public float length2;
        readonly public float[] lengths;    //インデクサを代替する方法
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.length0;
                    case 1:
                        return this.length1;
                    case 2:
                        return this.length2;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public Triangle(float length0 = 0, float length1 = 0, float length2 = 0)
        {
            this.lengths = new float[3];
            this.lengths[0]= this.length0 = length0;
            this.lengths[1]=this.length1 = length1;
            this.lengths[2]=this.length2 = length2;
        }
        public override float GetSurface()
        {
            float s = (length0 + length1 + length2) / 2;
            return (float)(Math.Sqrt(s * (s - length0) * (s - length1) * (s - length2)));
        }
        public override float GetCircumference()
        {
            return length0 + length1 + length2;
        }
        public override void GetBounds(out float width, out float height)
        {
            width = length0 > length1
                ? (length0 > length2 ? length0 : length2)
                : (length1 > length2 ? length1 : length2);
            /*            width = MathF.Max(MathF.Max(length0, length1), length2);
                        if (length0 > length1)
                        {
                            if (length0 > length2)
                            {
                                width = length0;
                            }
                            else
                            {
                                width = length2;
                            }
                        }
                        else
                        {
                            if (length1 > length2)
                            {
                                width = length1;
                            }
                            else
                            {
                                width = length2;
                            }
                        }*/

            height = (float)((double)GetSurface() / width * 2.0);
            return;
        }
    }
}
