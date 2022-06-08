using System;

namespace Function
{
    class Function
    {
        static void Main(string[] args)
        {
            var i1 = InputNumber("ひとつ目の数を入力してください");
            var i2 = InputNumber("ふたつ目の数を入力してください");
            var i3 = InputNumber("みっつ目の数を入力してください");
            var max = GetMax(i1, i2, i3);
            Console.WriteLine($"最大値は{max}");
            Console.WriteLine($"最大値は{GetMax(100, -2, 800)}");
        }
        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }

        static int GetMax(int a, int b, int c)
        {
            var max = a; //最大値を格納する変数
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            return max;
        }
    }
}
