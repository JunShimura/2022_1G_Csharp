using System;

namespace ex06
{
    class ex06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("身長(m)を入力してください"); // 文字列を出す
            var height = double.Parse(Console.ReadLine());   // 文字列を入力しheightに変換し代入
            Console.WriteLine("体重(kg)を入力してください"); // 文字列を出す
            var weight = double.Parse(Console.ReadLine());   // 文字列を入力しweightに変換し代入
            var bmi = weight / (height * height);  // BMIを算出
            Console.WriteLine($"BMI = {bmi:f2}");  //計算の結果を文字列で表示;
            #region Sample1
            
            if (bmi < 18.5)
            {
                Console.WriteLine("低体重(痩せ型)");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("普通体重");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("肥満(1度)");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("肥満(2度)");
            }
            else if (bmi < 40)
            {
                Console.WriteLine("肥満(3度)");
            }
            else
            {
                Console.WriteLine("肥満(4度)");
            }
            
            #endregion
        }
    }
}