using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30
{
    class Fish:Animal
    {
        public Fish(DateTime lifeSpan, DateTime bd, string n, float w = 0, float h = 0, float d = 0,float weight=0) : base(lifeSpan, bd, n, w, h, d,weight)
        {

        }
    }
}
