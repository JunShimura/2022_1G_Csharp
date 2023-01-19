namespace List9_1
{
    internal class Program
    {
        static void Main()
        {
            // デリゲート。Addメソッドを変数fに代入
            Func<int, int, int> f;
            Func<int, float, double> g;
            f = Add;
            g = PowAbs;
            // 変数fを呼び出す。実際に呼ばれるのはAddメソッド
            Console.WriteLine(f(1, 2));
            Console.WriteLine(g(-5, 2.5f));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static double PowAbs(int x, float y)
        {
            return Math.Abs(Math.Pow(y, x));
        }
    }
}