using System;

namespace Ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Surface testSurface = new Surface();  エラーになる
            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 7);
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(5,7,3);

            Surface[] surfaces = { rectAngle1, rightTriangle,circle,triangle };
            foreach(Surface surface in surfaces)
            {
                Console.WriteLine($"の面積は{surface.GetSurface()}");
                Console.WriteLine($"周囲長は{surface.GetCircumference()}");
                float boundsWidth;
                float boundsHeight;
                surface.GetBounds(out boundsWidth, out boundsHeight);
                Console.WriteLine($"surfacesの入る長方形は、幅が{boundsWidth}で高さが{boundsHeight}");
            }
        }
    
    }
}
