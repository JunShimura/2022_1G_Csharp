using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31
{
    class Cow : Character
    {
        public Cow(string name, float hp, float power ) : base(name, hp, power) { }
        public override void Attack(Character destination)
        {

                Console.WriteLine($"{this.name}は{destination.name}を角で突いた！");
                Console.WriteLine($"{destination.name}にふたつ孔が開いた！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}