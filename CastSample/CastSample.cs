using System;

namespace CastSample
{
    class CastSample
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 2;
            float f = 0.5f;
            var x = i * f;
            var y = i * (int)f;
            var z = (int)(i * f);
            var w1 = i / j * i;
            var w2 = i * i / j;
            var w3 = (float)i / j;
        }
    }
}

