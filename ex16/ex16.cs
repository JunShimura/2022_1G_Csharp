using System;

namespace Ex16
{
    class Ex16
    {
        const int tableSize = 10;
        static void Main(string[] args)
        {

            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write($"数値を入力：{i+1}個目：");
                table[i] = int.Parse(Console.ReadLine());
            }

            //最大値,最小値を求める
            var max = table[0];
            var min = table[0];
            var sum = table[0];
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
            Console.WriteLine($"最大値＝{max}\n最小値={min}");
            Console.WriteLine($"平均={(double)sum / table.Length}");
        }
    }
}