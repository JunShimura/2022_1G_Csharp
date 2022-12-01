using System;

namespace AbstractSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Surface testSurface = new Surface();  エラーになる
            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Trapezoid trapezoid = new Trapezoid(10, 13, MathF.Sqrt(10), MathF.Sqrt(13));
            //Surface surface = new Surface();    // エラーになる、new出来ない
            Surface surface = trapezoid;    // 参照だけ有効
            Surface[] surfaces = {rectAngle1,rightTriangle, trapezoid };
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"{i}番目\nsurfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
                float width, height;
                surfaces[i].GetBounds(out width, out height);
                Console.WriteLine($"surfacesを囲う長方形の幅は{width},高さは{height}");
            }
        }
    
    }
}
