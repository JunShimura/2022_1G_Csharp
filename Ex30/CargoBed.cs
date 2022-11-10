using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ex30
{
    class CargoBed : Thing
    {
        readonly public float allowableWeight;
        public CargoBed(float allowableWeight, string n, float w = 0, float h = 0, float d = 0, float weight = 0) : base(n, w, h, d, weight)
        {
            this.allowableWeight = allowableWeight;
        }
        public bool isAllowable(Thing cargo)
        {
            var result = false;
            if (cargo.weight <= allowableWeight)
            {
                if (cargo.width <= this.width)
                {   // 幅は入る
                    if (cargo.height <= this.height //そのまま
                        && cargo.depth <= this.depth
                        ||
                        cargo.height <= this.depth //ｘ回転
                        && cargo.depth <= this.height)
                    {
                        result = true;
                    }
                }
                else if (cargo.width <= this.height) //ｘ回転
                {
                    if (cargo.height <= this.width
                        && cargo.depth <= this.depth
                        ||
                        cargo.height <= this.depth  //ｙ回転
                        && cargo.depth <= this.width)
                    {
                        result = true;
                    }
                }
                else if (cargo.width <= this.depth)//ｙ回転
                {
                    if (cargo.height <= this.width
                    && cargo.depth <= this.height
                    ||
                    cargo.height <= this.height
                    && cargo.depth <= this.width)
                    {
                        result = true;
                    }
                }
            }
            else
            {   // 重すぎる
                result = false;
            }

            //ソートする方法
            List<float> bedScale = new List<float>() { this.width,this.height,this.depth};
            bedScale.Sort();
            List<float> cargoScale = new List<float>() { cargo.width, cargo.height, cargo.depth };
            cargoScale.Sort();
            result = true;
            for(var i = 0; i < bedScale.Count; i++)
            {
                if (bedScale[i] < cargoScale[i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
