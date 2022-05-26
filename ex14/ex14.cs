using System;

namespace ex14
{
    class ConvertBinary
    {
        static void Main(string[] args)
        {
            const int DIGIT = 16;
            const int DIVIDE = 4;
            int inputNumber;
            const int baseNumber=2;
            Console.WriteLine("数を入力:");
            inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber >= 0 && inputNumber <= 65535)
            {
                string answer = "";
                for (int i = 0; i < DIGIT / DIVIDE; i++)
                {
                    answer = " " + answer;
                    for (int j = 0; j < DIVIDE; j++)
                    {
                        answer = inputNumber % baseNumber + answer;
                        inputNumber /= baseNumber;
                    }
                }
                Console.WriteLine($"{baseNumber}進数:{answer}");
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}

