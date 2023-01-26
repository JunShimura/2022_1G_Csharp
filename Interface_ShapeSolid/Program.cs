using InputUtilitys;
using ShapeSolid;
namespace Interface_ShapeSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolid[] solids
                = {
                        new Box(2, 3, 5),
                        new RightTriangularPrism(2,3,5),
                        new Sphere(3),
                        new Column<RectAngle>(new RectAngle(2,3),5),
            };
            //Boxクラスを利用する
            Box box01 = new Box(2, 3, 5);

            //ジェネリック化したColumnを利用する
            Column<RectAngle> box02 //柱を底面を四角で作ってください
             = new Column<RectAngle>(new RectAngle(2, 5), 3);

            //三角柱でジェネリック化したColumnを利用する
            Column<Triangle> trianglePrism
                = new Column<Triangle>(new Triangle(3, 2, 1), 4);
            
            RectAngle rectAngle01 = new RectAngle(1.5f, 4);
            RectAngle rectAngle02 = new RectAngle(4.5f, 9.25f);
            Column<RectAngle> box03 = new Column<RectAngle>(rectAngle01, 5);
            Column<RectAngle> box04 = new Column<RectAngle>(rectAngle02, 3.5f);
            //この時にもし「rectAngle01」がclassだった場合はbox03が存在する間は消せないことを意味する

            foreach (ISolid solid in solids)
            {
                Console.WriteLine($"体積={solid.Volume},表面積={solid.Surface}");
            }
            RectAngle[] rectAngles = new RectAngle[] { new RectAngle(3, 7), new RectAngle(4, 7),new RectAngle(7,3)};
            Console.WriteLine(rectAngles[0] == rectAngles[1]);
            Console.WriteLine(rectAngles[0] == rectAngles[2]);
            /*            // 幅3,高さ4,奥行5の箱の表面積を求める（インスタンスを作らずに計算）
                        TriangularPrism triangularPrism1 = new TriangularPrism(3, 4, 6);
                        var s1 = triangularPrism1.GetSurface();
                        var v1 = triangularPrism1.GetVolume();
                        var s2 = TriangularPrism.GetSurface(3, 4, 6);
                        var v2 = TriangularPrism.GetVolume(3, 4, 6);
                        Console.WriteLine($"s1={s1},s2={s2},v1={v1},v2={v2}");
                        if (s1 != 84 || s1 != s2 || v1 != 36 || v1 != v2)
                        {
                            Console.WriteLine("Test is faild.");
                        }
                        TriangularPrism triangularPrism2 = new TriangularPrism(3, 4, 5, 6);
                        s1 = triangularPrism2.GetSurface();
                        v1 = triangularPrism2.GetVolume();
                        s2 = TriangularPrism.GetSurface(3, 4, 5, 6);
                        v2 = TriangularPrism.GetVolume(3, 4, 5, 6);
                        Console.WriteLine($"s1={s1},s2={s2},v1={v1},v2={v2}");
                        if (s1 != 84 || s1 != s2 || v1 != 36 || v1 != v2)
                        {
                            Console.WriteLine("Test is faild.");
                        }

                        Sphere sphere = new Sphere(3);
                        s1 = sphere.GetSurface();
                        v1 = sphere.GetVolume();
                        s2 = Sphere.GetSurface(3);
                        v2= Sphere.GetVolume(3);
                        if (s1 != (float)113.097335529233 || s1 != s2 || v1 != (float)113.097335529233 || v1 != v2)
                        {
                            Console.WriteLine("Test is faild.");
                        }
                        Cylinder cylinder = new Cylinder(3,6);
                        s1 = cylinder.GetSurface();
                        v1 = cylinder.GetVolume();
                        s2 = Cylinder.GetSurface(3, 6);
                        v2 = Cylinder.GetVolume(3, 6);
                        if (s1 != (float)169.646003293849 || s1 != s2 || v1 != (float)169.646003293849 || v1 != v2)
                        {
                            Console.WriteLine("Test is faild.");
                        }*/
        }
    }
}