using System;

namespace Ex20
{
    class Ex20
    {
        static void Main(string[] args)
        {
            float r = InputFloat("半径を入力してください");
            float h = InputFloat("高さを入力してください");
            float s = GetCircleSurface(r); //底面積
            float v = GetCylinderVolume(r, h); //体積
            Console.WriteLine("底面積は{0},体積は{1}", s, v);
        }
        static float GetCircleSurface(float radius)
        {  //半径から円の面積を求める
            float surface = 0;
            //　ここに処理を追加
            surface = (float)(Math.PI * radius * radius);  //floatのキャストを追加
            return surface;
        }
        static float GetCylinderVolume(float radius, float height)
        {  //半径と高さから円柱の体積を求める
            //float volume = (float)Math.PI * radius * radius * height;
            float volume = GetCircleSurface(radius) * height;
            return volume;
        }

        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }
        static float InputFloat(string message)
        {
            Console.WriteLine(message);
            float i = float.Parse(Console.ReadLine());
            return i;
        }
    }

}