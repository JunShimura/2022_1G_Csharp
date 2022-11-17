using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31
{
    class Character
    {
        readonly public string name;
        public float hp;
        protected float power;
        readonly public bool isResistPoison;
        public Character(string name,float hp,float power,bool resistancePoison=false)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.isResistPoison = resistancePoison;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
