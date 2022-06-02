using System;
namespace MethodSample
{
    class MethodSampleClass
    {
        static void Main()
        {
            Console.WriteLine("変数を入力:");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("変数を入力:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("変数を入力:");
            int c = int.Parse(Console.ReadLine());
            var d = GetMax(a, b, c);
            Console.WriteLine($"最大値は{d}");
            return;
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
