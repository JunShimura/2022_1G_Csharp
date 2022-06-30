using System;

namespace RefOut
{
    class RefOut
    {
        static void Main()
        {
            int a = 100;
            int a;
            //Console.Write($"a={a} → ");
            Test(ref a);
            Console.WriteLine($"{a}");
            int b=1;  //　初期化していない
            //Console.Write($"b={b} → ");   //初期化前で存在しないのでエラー
            TestOut(out b);
            Console.WriteLine($"{b}");
        }
        static void Test(ref int a)
        {
            a = 10; // メソッド内で値を書き換える
        }
        static void TestOut(out int a)
        {
            a = 10; // メソッド内で値を書き換える
        }
    }
}