using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_ex
{
    interface IBounds
    {
        public void GetBounds(out float width, out float height);  //囲う長方形の幅と高さ
    }
}
