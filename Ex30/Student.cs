using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30
{
    class Student:Person
    {
        public readonly int id;
        public Student(DateTime lifeSpan, int id, DateTime bd, string n, float w = 0, float h = 0, float d = 0,float weight = 0) : base(lifeSpan,bd, n, w, h, d, weight)
            {
            this.id = id;
        }
    }
}
