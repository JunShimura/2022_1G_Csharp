﻿//#define operatorEQtest 

using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(3.5f, 5);  //17.5
            RectAngle rectAngle2 = new RectAngle(2, 4);	//8.0二つ合わせて25.5
            RectAngle rectAngle3 = new RectAngle(5, 3);

#if operatorEQtest            
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい"); 
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            if (rectAngle2 == rectAngle3)
            {
                Console.WriteLine("rectAngle2とrectAngle3は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle2とrectAngle3は等しくない");
            }
            if (rectAngle1 == rectAngle3)
            {
                Console.WriteLine("rectAngle1とrectAngle3は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle3は等しくない");
            }
#endif
            RectAngle rectAngle4 = rectAngle1+ rectAngle2;
            Console.WriteLine($"rectAngle4=({rectAngle4.width},{rectAngle4.height}),面積={rectAngle4.GetSurface()}");
        }
    }
}
