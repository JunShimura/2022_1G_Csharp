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
            Triangle triangle = new Triangle(3,4,5);

            Surface[] surfaces = { rectAngle1, rightTriangle,circle,triangle };
            for(var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"surfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
                float boundsWidth;
                float boundsHeight;
                surfaces[i].GetBounds(out boundsWidth, out boundsHeight);
                Console.WriteLine($"surfacesの入る長方形は、幅が{boundsWidth}で高さが{boundsHeight}");
            }
        }
    
    }
}
