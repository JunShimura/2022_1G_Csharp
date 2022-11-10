using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30
{
    /// <summary>
    /// 物体
    /// </summary>
    class Thing
    {
        readonly public string name;
        public float width;
        public float height;
        public float depth;
        public float weight;
        public Thing(string name = null,float width = 0,float height =0,float depth=0,float weight=0 )
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.depth = depth;
            this.weight = weight;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }
        public float BoxSize()
        {
            return width + height + depth;
        }
    }
}
