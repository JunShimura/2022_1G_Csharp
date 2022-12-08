using System.Runtime.CompilerServices;

namespace OperatorSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            V3 v3_1 = new V3(1, 2, 3);
            V3 v3_2 = new V3(-2, 5, 1);
            V3 v3_4 = v3_1+ v3_2;
            Console.WriteLine($"{v3_4}");
        }
    }
    class V3
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public V3(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static V3 operator+(V3 v1, V3 v2)
        {
            return new V3(v1.X+v2.X,v1.Y+v2.Y,v1.Z+v2.Z);
        }
        public override string ToString()
        {
            return $"({X.ToString()},{Y.ToString()},{Z.ToString()})";
        }
    }
}