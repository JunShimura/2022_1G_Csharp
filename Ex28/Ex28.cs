namespace Ex28
{
    internal class Ex28
    {
        static void Main(string[] args)
        {
            // 底面の直角三角形の底辺3,底面の直角三角形のの高さ4,高さ5の三角柱
            TriangularPrism triangularPrism1 = new TriangularPrism(3, 4, 5);
            Console.WriteLine($"表面積={triangularPrism1.GetSurface()}\n 体積 ={triangularPrism1.GetVolume()}");
            // 底面の三角形の３辺の長さが3,4,5、高さが6
            TriangularPrism triangularPrism2 = new TriangularPrism(3, 4, 5,6);
            Console.WriteLine($"表面積={triangularPrism2.GetSurface()}\n 体積 ={triangularPrism2.GetVolume()}");
        }
    }
}