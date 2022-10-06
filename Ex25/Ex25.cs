namespace Ex25
{
    internal class Ex25
    {
        const int headMin = 0;        // 頭の数の最小値
        const int headMax = 1000;  // 頭の数の最大値 
        const int legMin = 0;           // 脚の数の最小値
        const int legMax = 1000;     // 脚の数の最大値 

        static void Main(string[] args)
        {
            while (true)
            {
                float heads;
                // 頭の数を入力
                 heads = InputNumber("頭の数を入力してください", headMin, headMax);
                float legs;
                // 脚の数を入力
                while (true)
                {
                    legs = InputNumber("脚の数を入力してください", legMin, legMax);
                    if (IsNaturalNumberOr0(legs) && legs % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine($"入力エラー、偶数を入れてください");
                }
                int crane=0;  // 鶴の数を格納する変数
                int turtle=0;	// 亀の数を格納する変数
                bool isSuccess = GetCraneTurtle((int)heads, (int)legs,  crane,  turtle);
                if (isSuccess)
                {
                    // 正常に算出、craneとturtleに数が入ってる
                    Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
                    break;
                }
                else
                {
                    // 出た答えが異常、craneとturtleに数は入っていない
                    Console.WriteLine("入力エラー");
                }
            }
        }
        static bool GetCraneTurtle(int heads, int legs, int crane, int turtle)
        {
            crane = GetCrane(heads,legs);  //値を求める
            turtle = GetTurtle(heads, legs); //値を求める
            return IsNaturalNumberOr0(crane) && IsNaturalNumberOr0(turtle);
        }

        static int GetTurtle(int heads, int legs)
        {
            return legs / 2 - heads;
        }
        static int GetCrane(int heads, int legs)
        {
            return heads - GetTurtle(heads, legs);
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
                #region TryParsePattern
                /*                try
                                {

                                    i = float.Parse(Console.ReadLine());
                                    if (i >= min && i < max)
                                    {
                                        break;
                                    }
                                }
                                catch(FormatException)
                                {
                                    Console.WriteLine("数値を入力してください");
                                    continue;
                                }
                                catch(OverflowException)
                                {
                                    Console.WriteLine("異常な入力です");
                                    continue;
                                }*/
                #endregion
                if (float.TryParse(Console.ReadLine(), out i) && i >= min && i < max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラー");
                }
            }
            return i;
        }

        static int InputNumber(string message, int min, int max)
        {
            int i;
            while (true)
            {
                Console.WriteLine($"{message}\n範囲は{min}から{max}");
                if (int.TryParse(Console.ReadLine(), out i) && i >= min && i < max)
                {
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
    }
}