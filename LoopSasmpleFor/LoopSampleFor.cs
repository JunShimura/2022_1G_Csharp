using System;

namespace LoopSampleFor
{
    class LoopSampleFor
    {
        static void Main(string[] args)
        {
            //　５の階乗なら5x4x3x2x1=120
            Console.Write("入力した値の階乗を求めます、値を入力してください:");
            var n = int.Parse(Console.ReadLine());
            var answer = 1;
            for(var i=1;i<=n;i++)
            {
                answer *= i;
            }
            Console.WriteLine($"答えは{answer}");
        }
    }
}

