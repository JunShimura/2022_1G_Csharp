using System;
namespace Ex25_hint
{
    class Ex25_hint
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
                while (true)
                {
                    heads = InputFloat("頭の数を入力してください", headMin, headMax);
                    if (IsNaturalNumberOr0(heads))
                    {
                        break;
                    }
                    Console.WriteLine("入力エラー、自然数を入れてください");
                }
                float legs;
                // 脚の数を入力
                while (true)
                {
                    legs = InputFloat("脚の数を入力してください", legMin, legMax);
                    if (IsNaturalNumberOr0(legs) && legs % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine($"入力エラー、偶数を入れてください");
                }

                /* ---ここから
                var turtle = GetTurtle((int)heads, (int)legs);
                var crane = GetCrane((int)heads, (int)legs);
                Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
                //　ここで異常値になってるか確認して、問題なければ終了、問題があればエラー表示して先頭へ戻る
                if (IsNaturalNumberOr0(crane) && IsNaturalNumberOr0(turtle))
                {
                    break;
                }
                Console.WriteLine("入力エラー");
                --- ここまでを別の処理にして置き換える　*/
                int crane;  // 鶴の数を格納する変数
                int turtle;	// 亀の数を格納する変数
                if (GetCraneTurtle((int)heads, (int)legs, out crane, out turtle))
                {
                    // 正常に算出、craneとturtleに数が入ってる
                }
                else
                {
                    // 出た答えが異常、craneとturtleに数は入っていない
                }
            }
        }
        static bool GetCraneTurtle(int heads, int legs, out int crane, out int turtle)
        {
            crane = 0;  //値を求める
            turtle = 0; //値を求める
            return true;    //正常値ならtrue、異常ならfalseを返す
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
        static bool IsNaturalNumberOr0(float val)
        {
            return (Math.Floor(val) == val && val >= 0.0);
        }
    }
}
