using System;

namespace Ex30
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(
                new DateTime(84L*365*24*60*60*1000*1000*10),
                new DateTime(2003, 1, 20), "でじたる太郎", 175.0f, 80, 50,80);
            CargoBed miniCargo = new CargoBed(10, "自転車の荷台", 30, 50, 45, 20);
            Console.WriteLine($"{person}の寿命は{person.lifeSpan.Year}年{person.lifeSpan.Month}月{person.lifeSpan.Day}日です");
            Console.WriteLine($"誕生日が{person.birthday.ToString()}で、" +
                $"\n今、{person.GetAge()}歳です");
            Console.WriteLine($"今日は誕生日{(person.isBirthDay()?"です、HPD!":"ではないです")}");
            Console.WriteLine($"{person.name}は{miniCargo.name}に{(miniCargo.isAllowable(person) ? "載せられます" : "載せられません")}");
            Cat cat = new Cat(
                new DateTime(12, 1, 1), new DateTime(2022, 1, 1),
                "たま", 45, 30, 50, 0.5f);
            Console.WriteLine($"{cat.name}は{miniCargo.name}に{(miniCargo.isAllowable(cat) ? "載せられます" : "載せられません")}");


        }
    }
}
