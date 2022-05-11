
using System;

namespace ex10
{
    class ex10
    {
        static void Main(string[] args)
        {
            Console.Write("何の段:");
            var n = int.Parse(Console.ReadLine());
            if (n > 0 && n <= 9)
            {
                for (var i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{n}*{i}={n * i}");
                }
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}
