namespace Generic
{
    internal class Ganerics
    {
        static void Main(string[] args)
        {
            var ix = 10.5;
            var iy = -5;
            var iz = 13;
            var ia = Max(ix, iy, iz);
            Console.WriteLine($"{ix}と{iy}と{iz}の最大値は{ia}");
           float fx = -2.8f;
            float fy = 1.78f;
            float fz = -87;
            float fa = Max(fx, fy, fz);
            Console.WriteLine($"{fx}と{fy}と{fz}の最大値は{fa}");
            byte bx = 2;
            byte by = 8;
            byte bz = 4;
            byte ba = Max(bx, by, bz);
            Console.WriteLine($"{bx}と{by}と{bz}の最大値は{ba}");
            double dx = 200.5;
            double dy = 50000;
            double dz = 4.058;
            double da  = Max(dx, dy, dz);
            Console.WriteLine($"{dx}と{dy}と{dz}の最大値は{da}");
            string sx = "xyzabc";
            string sy = "123abc";
            string sz = "IJK";
            string sa = Max(sx, sy, sz);
            Console.WriteLine($"{sx}と{sy}と{sz}の最大値は{sa}");
        }
/*        static int Max(int x, int y, int z)
        {
            if (x.CompareTo(y) < 0)
                if (y.CompareTo(z) < 0) return z;
                else return y;
            else
                if (x.CompareTo(z) < 0) return z;
            else return x;
        }*/

        static Type Max<Type>(Type x, Type y, Type z) where Type : IComparable<Type>
        {
            if (x.CompareTo(y) < 0)
                if (y.CompareTo(z) < 0) return z;
                else return y;
            else
                if (x.CompareTo(z) < 0) return z;
            else return x;
        }
    }
}