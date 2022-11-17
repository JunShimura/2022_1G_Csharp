using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31
{
    class Hornet:Character
    {
        public Hornet(string name, float hp, float power) : base(name, hp, power, true) { }
        public override void Attack(Character destination)
        {
            if (!destination.isResistPoison)
            {
                Console.WriteLine($"{this.name}は{destination.name}を針で刺した！");
                Console.WriteLine($"{destination.name}は{destination.hp}のダメージ");
                destination.hp = 0;
                Console.WriteLine($"{destination.name}は死んだ");
            }
            else
            {
                base.Attack(destination);
            }
        }
    }
}
