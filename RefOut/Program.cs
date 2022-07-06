using System;

namespace RefOut
{
    class RefOut
    {
        static void Main()
        {
/*         
 *         int x = 16384;
            int y = 48;
            int g = GetGcm(x, y);
*/
            Console.WriteLine($"gcm({x},{y})={g}");
            int a = 100;
            //Console.Write($"a={a} → ");
            Test(ref a);
            Console.WriteLine($"{a}");
            int b=1;  //　初期化していない
            //Console.Write($"b={b} → ");   //初期化前で存在しないのでエラー
            TestOut(out b);
            Console.WriteLine($"{b}");
*/        
        }
        static void Test(ref int a)
        {
            a = 10; // メソッド内で値を書き換える
        }
        static void TestOut(out int a)
        {
            a = 10; // メソッド内で値を書き換える
        }
        static int GetGcm(int a,int b)
        {
            if (a < b)
            {
                var t = a;
                a = b;
                b = t;
            }
            int r = b;// ユークリッドの互除法
            while (r != 0)
            {
                b = r;
                r = a % b;
                a= b;
            }
            return b;
        }
    }
}