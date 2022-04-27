using System;

namespace ex05
{
    class ex05
    {
        static void Main(string[] args)
        {
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            var n = money / 10000;
            if (n!=0)
            {
                Console.WriteLine($"1万円札：{n}枚");
                money %= 10000;
            }
            n= money / 5000;
            if (n!=0)
            {
                Console.WriteLine($"5千円札：{n}枚");
                money %= 5000;
            }
            n= money / 1000;
            if (n!=0)
            {
                Console.WriteLine($"千円札：{n}枚");
                money %= 1000;
            }
            n = money / 500;
            if (n!=0)
            {
                Console.WriteLine($"五百円玉：{n}枚");
                money %= 500;
            }
            n= money / 100;
            if (n!=0)
            {
                Console.WriteLine($"百円玉：{n}枚");
                money %= 100;
            }
            n= money / 50;
            if (n!=0)
            {
                Console.WriteLine($"五十円玉：{n}枚");
                money %= 50;
            }
            n= money / 10;
            if (n!=0)
            {
                Console.WriteLine($"十円玉：{n}枚");
                money %= 10;
            }
            n= money / 5;
            if (n!=0)
            {
                Console.WriteLine($"五円玉：{n}枚");
                money %= 5;
            }
            n= money;
            if (n!=0)
            {
                Console.WriteLine($"一円玉：{n}枚");
            }
        }
    }
}