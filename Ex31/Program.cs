using System;

namespace Ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2,true);
            Character character2 = new Character("ささっき", 1000, 25,false);
            Tank tank1 = new Tank("Tiger", 500000, 250);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125);
            tank2.bullet = 5;
            Cow cow = new Cow("もうもうちゃん", 253, 12.5f);
            Cat tama = new Cat("たまちゃん", 100, 2.5f);
            Hornet hornet = new Hornet("ばんぶるびー", 20, 1);
            hornet.Attack(character1);
            hornet.Attack(tank2);
            Character[] characters = { character2, tank1, tank2,cow,tama,hornet };
            foreach(Character character in characters)
            {
                character.Attack(character1);
            }
        }
    }
}
