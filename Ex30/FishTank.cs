using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30
{
    class FishTank:CargoBed
    {
        public bool isFilled=false;
        public FishTank(float allowableWeight, string n, float w = 0, float h = 0, float d = 0, float weight = 0):base(allowableWeight, n , w, h, d, weight)
        {

        }
       public bool isAllowable(Fish fish)
        {
            return isFilled && base.isAllowable(fish);
        }
    }
}
