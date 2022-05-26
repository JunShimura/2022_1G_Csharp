using System;

namespace Ex15
{
    class Ex15
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力：");
            var inputNumber = int.Parse(Console.ReadLine());
            string[] words0to19 =
                {
                    "zero", "one",  "two",  "three",    "four", "five", "six",  "seven",    "eight",    "nine",
                    "ten",  "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
                };
            string[] words20to90 =
                { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (inputNumber >= 0 && inputNumber <= 99)
            {
                if (inputNumber < 20)
                {
                    Console.WriteLine(words0to19[inputNumber]);
                }
                else if (inputNumber <= 99)
                {   //20以上90未満
                    int ten = inputNumber / 10; //10の位
                    int one = inputNumber % 10; //１の位
                    var s = words20to90[ten - 2];
                    if (one != 0)
                    {
                        s += ("-" + words0to19[one]);
                    }
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}