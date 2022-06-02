using System;

namespace Ex17
{
    class Ex17
    {
        //設定
        const int tableSize = 10000;
        const int randomRangeMin = int.MinValue;
        const int randomRangeMax = int.MaxValue;

        static void Main(string[] args)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                //table[i] = random.Next(randomRangeMin, randomRangeMax);  //Randomを使う場合
                table[i] = table.Length - i;
                Console.WriteLine($"table[{i}]={table[i]}");
            }

            sw.Start();

            Array.Sort(table);
            Array.Reverse(table);

            sw.Stop();

            Console.WriteLine("整列後");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"table[{i}]={table[i]}");
            }

            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");
        }
    }
}
