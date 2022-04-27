using System;
namespace Chapter3
{
    internal class Chapter3_if
    {
        static void Main(string[] args)
        {
            Console.WriteLine("体重を入力：");
            var weight = Double.Parse(Console.ReadLine());
            if (weight < 30.0) { Console.WriteLine("ガリガリ"); }
            else if (weight < 80.0)
            {
                Console.WriteLine("ちょうどいい");    //30≦体重＜80
            }
            else if (weight < 120)
            {
                Console.WriteLine("デブかも");      //80≦体重＜120
            }
            else
            {
                Console.WriteLine("おすもうさん");    //120≦体重
            }
        }
    }
}