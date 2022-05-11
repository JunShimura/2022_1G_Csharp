using System;

namespace LoopSample
{
    class LoopSampleDoWhile
    {
        static void Main(string[] args)
        {
            //　５の階乗なら5x4x3x2x1=120
            Console.Write("入力した値の階乗を求めます、値を入力してください:");
            var n = int.Parse(Console.ReadLine());
            var answer =1;
            if (n != 0)
            {
                answer = n;
                do
                {
                    n--;
                    answer *= n;
                }
                while (n > 2);
            }
            else
            {
                answer = 1;
            }
            Console.WriteLine($"答えは{answer}");
        }
    }
}
