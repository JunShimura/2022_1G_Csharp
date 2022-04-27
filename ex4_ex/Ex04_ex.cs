using System;

namespace ex04
{
    class ex04
    {
        struct Denomination
        {
            readonly public int amount;
            readonly public string message;
            public Denomination(int amount, string message)
            {
                this.amount = amount;
                this.message = message;
            }
            public int getNumber(int money, ref int left)
            {
                left=money%this.amount;
                return money/this.amount;
            }
        };
        static void Main(string[] args)
        {
            Denomination[] denominations =
            {
                new Denomination(10000,"1万円札"),
                new Denomination(5000,"5千円札"),
                new Denomination(2000,"2千円札"),
                new Denomination(1000,"千円札"),
                new Denomination(500,"五百円玉"),
                new Denomination(100,"百円玉"),
                new Denomination(50,"50円玉"),
                new Denomination(10,"10円玉"),
                new Denomination(5,"5円玉"),
                new Denomination(1,"1円玉"),
            };
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            for (int i = 0; i < denominations.Length&&money>0; i++)
            {
                int number = denominations[i].getNumber(money, ref money);
                if (number != 0)
                {
                    Console.Write($"{denominations[i].message}が{number}枚\n");
                }
            }
        }
    };
}