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
                Console.Write($"数値を入力：{i + 1}個目：");
                table[i] = int.Parse(Console.ReadLine());
            }

            //最大値,最小値を求める
            var maxId = 0;
            var minId = 0;
            var sum = table[0];
            for (int i = 1; i < table.Length; i++)
            {
                if (table[maxId] < table[i])
                {   //もっと大きい値があった場合、最大値を更新
                    maxId = i;
                }
                else if (table[minId] > table[i])
                {   //もっと小さい値があった場合、最小値を更新
                    minId = i;
                }
                sum += table[i];
            }
            Console.WriteLine($"最大値＝{table[maxId]}\n最小値={table[minId]}\n平均={(double)sum / table.Length}");
        }
    }
}
