using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30
{
    class Car:Thing
    {
        public Car(string n, float w = 0, float h = 0, float d = 0, float weight = 0) : base(n, w, h, d,weight)
        {
        }
    }
}
