using System;

namespace Ex16
{
    class _sw
    {
        const int tableSize = 10000;
        static void Main(string[] args)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = random.Next(int.MinValue, int.MaxValue);  //Randomを使う場合
                Console.WriteLine($"table[{i}]={table[i]}");
            }

            sw.Start();

            //最大値,最小値を求める
            var max = table[0];
            var min = table[0];
            var sum = table[0];
            double average = (double)table[0] / table.Length;
            for (int i = 1; i < table.Length; i++)
            {
                if (max < table[i])
                {   //もっと大きい値があった場合、最大値を更新
                    max = table[i];
                }
                else if (min > table[i])
                {   //もっと小さい値があった場合、最小値を更新
                    min = table[i];
                }
                sum += table[i];
            }
            sw.Stop();

            Console.WriteLine($"最大値＝{max}\n最小値={min}\n平均={(double)sum / table.Length}");
            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");
        }
    }
}