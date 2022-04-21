using System;

namespace ex04
{
    class ex04
    {
        static void Main(string[] args)
        {
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            #region sample1

            var n = money / 10000;
            Console.WriteLine($"1万円札：{n}枚");
            money %= 10000;
            n= money / 5000;
            Console.WriteLine($"5千円札：{n}枚");
            money %= 5000;
            n= money / 1000;
            Console.WriteLine($"千円札：{n}枚");
            money %= 1000;
            n = money / 500;
            Console.WriteLine($"五百円玉：{n}枚");
            money %= 500;
            n= money / 100;
            Console.WriteLine($"百円玉：{n}枚");
            money %= 100;
            n= money / 50;
            Console.WriteLine($"五十円玉：{n}枚");
            money %= 50;
            n= money / 10;
            Console.WriteLine($"十円玉：{n}枚");
            money %= 10;
            n= money / 5;
            Console.WriteLine($"五円玉：{n}枚");
            money %= 5;
            n= money;
            Console.WriteLine($"一円玉：{n}枚");

            #endregion
            #region Optimized
            /*
             Console.WriteLine(
                 $"1万円札：{  money / 10000}枚\n"
                 +$"5千円札：{  money % 10000 / 5000}枚\n"
                 +$"千円札：{    money % 5000 / 1000}枚\n"
                 +$"五百円玉：{ money % 1000 / 500}枚\n"
                 +$"百円玉：{    money % 500 / 100}枚\n"
                 +$"五十円玉：{ money % 100 / 50}枚\n"
                 +$"十円玉：{    money % 50 / 10}枚\n"
                 +$"五円玉：{    money % 10 / 5}枚\n"
                 +$"一円玉：{    money % 5}枚");
            */
            #endregion

        }
    }
}