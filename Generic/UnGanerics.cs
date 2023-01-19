namespace Generic
{
    internal class UnGanerics
    {
        static void Main(string[] args)
        {
            int ix = 10;
            int iy = -5;
            int ia = Difference(ix,iy);
            Console.WriteLine($"{ix}と{iy}の差は{ia}");
            float fx = -2.8f;
            float fy = 1.0f;
            float fa = Difference(fx, fy);
            Console.WriteLine($"{fx}と{fy}の差は{fa}");
            byte bx = 2;
            byte by = 8;
            byte ba = Difference(bx, by);
            Console.WriteLine($"{bx}と{by}の差は{ba}");
        }
        static int Difference(int x, int y)
        {
            return Math.Abs(x - y);
        }
        static float Difference(float x, float y)
        {
            return Math.Abs(x - y);
        }
        static byte Difference(byte x, byte y)
        {
            return (byte)Math.Abs((int)x - (int)y);
        }
    }
}