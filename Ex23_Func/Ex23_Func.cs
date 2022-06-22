namespace Ex23_Func
{
    internal class Ex23_Func
    {

        const int headMin = 0;        // 頭の数の最小値
        const int headMax = 1000;  // 頭の数の最大値 
        const int legMin = 0;           // 脚の数の最小値
        const int legMax = 1000;     // 脚の数の最大値 

        static void Main(string[] args)
        {
            while (true)
            {
                float heads = InputFloat("頭の数を入力してください", headMin, headMax, IsNaturalNumberOr0);
                float legs = InputFloat("脚の数を入力してください", legMin, legMax,CheckEaven);
                 var turtle = legs / 2 - heads;
                var crane = heads - turtle;
                Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
                //　ここで異常値になってるか確認して、問題なければ終了、問題があればエラー表示して先頭へ戻る
                if (IsNaturalNumberOr0(crane) && IsNaturalNumberOr0(turtle))
                {
                    break;
                }
                Console.WriteLine("入力エラー");
            }
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
        static float InputFloat(string message, float min, float max, Func<float, bool> Judge)
        {
            float i;
            while (true)
            {
                Console.WriteLine($"{message}\n範囲は{min}から{max}");
                i = float.Parse(Console.ReadLine());
                if (i >= min && i < max && Judge(i))
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

        static bool IsNaturalNumberOr0(float val)
        {
            return (Math.Floor(val) == val && val >= 0.0);
        }
        static bool CheckEaven(float l)
        {
            return IsNaturalNumberOr0(l) && l % 2 == 0;
        }
    }
}