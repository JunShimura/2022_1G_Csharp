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
                table[i] = random.Next(randomRangeMin, randomRangeMax);  //Randomを使う場合
                //table[i] = table.Length - i;
                Console.WriteLine($"table[{i}]={table[i]}");
            }

            sw.Start();

            for (var fixId = 0; fixId < table.Length - 1; fixId++)
            {
                var maxId = fixId;  //仮の最大値の入る索引
                //最大値の在る索引をmaxIdに求める
                for (int i = fixId + 1; i < table.Length; i++)
                {
                    if (table[maxId] < table[i])
                    {   //もっと大きい値があった場合、最大値を更新
                        maxId = i;
                    }
                }
                //最大値を固定したいIDのデータと交換
                if (maxId != fixId)
                {
                    var temp = table[maxId];
                    table[maxId] = table[fixId];
                    table[fixId] = temp;
                }
            }
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
