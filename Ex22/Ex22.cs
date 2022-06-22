using System;

namespace Ex22
{
    class Ex22
    {

        const float rMin = 1; //半径の最小値
        const float rMax = 100; //半径の最小値
        const float hMin = 1; //高さの最小値
        const float hMax = 300; //高さの最大値

        static void Main(string[] args)
        {
            float r = InputFloat("半径は幾つですか？", rMin, rMax);　//半径
            float h = InputFloat("高さは幾つですか?", hMin, hMax); //高さ
            float s = GetCircleSurface(r);
            float v = GetCylinderVolume(r, h);
            Console.WriteLine("底面積は{0},体積は{1}", s, v);
        }
        static float GetCircleSurface(float radius)
        {  //半径から円の面積を求める
            float surface = 0;
            //　ここに処理を追加
            surface = (float)Math.PI * radius * radius;
            return surface;
        }
        static float GetCylinderVolume(float radius, float height)
        {  //半径と高さから円柱の体積を求める
            float volume = GetCircleSurface(radius) * height;
            return volume;
        }

        /// <summary>
        /// 浮動小数点数を入力
        /// </summary>
        /// <param name="message">入力を促す文言</param>
        /// <param name="min">最小値（以上）</param>
        /// <param name="max">最大値（未満）</param>
        /// <returns>入力された値</returns>
        static float InputFloat(string message, float min, float max)
        {
            float i;
            while (true)
            {
                Console.WriteLine($"{message}\n範囲は{min}から{max}");
                i = float.Parse(Console.ReadLine());
                if (i >= min && i < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラー");
                }
            }
            return i;
        }
    }
}