﻿using System;

namespace LoopSampleWhile
{
    class LoopSampleWhile
    {
        static void Main(string[] args)
        {
            //　５の階乗なら5x4x3x2x1=120
            Console.Write("入力した値の階乗を求めます、値を入力してください:");
            var n = int.Parse(Console.ReadLine());
            var answer = 1;
            // for(; n > 1;)
            while (n > 1)
            {
                answer *= n;
                n--;
            }
            Console.WriteLine($"答えは{answer}");
        }
    }
}
