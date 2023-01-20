namespace ActionFunc
{
    internal class Program
    {
        // SomeDelegateという名前のデリゲート型を定義
        //delegate void SomeDelegate(int a);
        //delegate void testDelegate(int a, int b);
        //delegate int testDelegateC(int a, int b);

        static void Main()
        {
            // 暗黙にSomeDelegate型に変換
            //SomeDelegate a = A;
            Action<int> a = A;
            a(256);

            //testDelegate test1 = FuncA;
            Action<int, int> test1 = FuncA;
            test1(2, 5);    //test1に代入されたFuncAが呼ばれる
            test1 = FuncB;
            test1(2, 5);    //test2に代入されたFuncBが呼ばれる
            test1 = (int a, int b) => { Console.WriteLine($"平均は{(a + b) / 2}"); };
            test1(2, 5);
            Action<int, int> mixed = FuncA;
            mixed += FuncB;
            mixed += (int a, int b) => { Console.WriteLine($"平均は{(a + b) / 2}"); };
            mixed -= FuncB;
            mixed(13, -2);

            var t0 = -1;
            var t1 = 4;

            Func<int,int,int> test3 = FuncD;
            var ans = test3(t0, t1); //5が返される
            Console.WriteLine($"{t0}と{t1}の差は{ans}");

        }

        static void A(int n)
        {
            Console.WriteLine($"A({n})が呼ばれました");
        }
        static void FuncA(int a, int b)
        {
            Console.WriteLine($"大きいほうは{Math.Max(a, b)}");
        }
        static void FuncB(int a, int b)
        {
            Console.WriteLine($"小さいほうは{Math.Min(a, b)}");
        }
        static int FuncD(int a, int b)
        {
            return Math.Abs(a - b); //差の絶対値
        }
    }
}