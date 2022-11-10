using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVirtual
{
    class Worker:Member
    {
        private int income;
        public Worker(string name, int age = 0,string organization=null,int income = 0) : base(name, age,organization)
        {
            this.income = income;
        }
    }
}
