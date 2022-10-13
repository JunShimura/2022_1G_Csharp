using InputUtilitys;

namespace Ex27
{
    internal class Ex27
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(
                InputUtility.InputFloat("円柱の底面の半径："),
                InputUtility.InputFloat("高さ：")
                );
            Console.WriteLine($"体積は{cylinder.GetVolume()}\n表面積は{cylinder.GetSurface()}");
            Sphere sphere = new Sphere(
                InputUtility.InputFloat("球の半径：")
                );
            Console.WriteLine($"体積は{sphere.GetVolume()}\n表面積は{sphere.GetSurface()}");
            TriangularPrism triangularPrism = new TriangularPrism(
                InputUtility.InputFloat("三角柱の底面の底辺："),
                InputUtility.InputFloat("三角柱の底面の高さ："),
                InputUtility.InputFloat("三角柱の高さ：")
                );
            Console.WriteLine($"体積は{triangularPrism.GetVolume()}\n表面積は{triangularPrism.GetSurface()}");
        }
    }
}