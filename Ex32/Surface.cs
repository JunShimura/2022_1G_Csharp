using System;
using System.Collections.Generic;
using System.Text;

namespace Ex32
{
    abstract class Surface
    {
        abstract public float GetSurface(); //面積を取得する
        abstract public float GetCircumference(); //周囲の長さを取得する
        abstract public void GetBounds(out float width, out float height);
    }
}
