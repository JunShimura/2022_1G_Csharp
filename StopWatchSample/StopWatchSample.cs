using System;

namespace StopWatchSample
{
    class SWsample
    {
        static void Main(string[] args)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            Console.WriteLine("キーを押すとスタートします");
            Console.ReadKey();
            // 計測の開始
            sw.Start();
            Console.WriteLine("キーを押すとストップします");
            Console.ReadKey();
            //　計測の終了
            sw.Stop();
            // 前回のスタートからストップまでの経過時間を表示
            Console.WriteLine($"{sw.ElapsedMilliseconds}ミリ秒");
        }
    }
}


