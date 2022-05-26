using System;

namespace ex14
{
    class ConvertBinary
    {
        static void Main(string[] args)
        {
            const int DIGIT = 16;
            const int DIVIDE = 4;
            char[] numberChar = new char[] {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F',
                'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R','S','T','U','V','W','X','Y','Z', //36
                'あ','い','う','え','お','か','き','く','け','こ',};
            int inputNumber;
            int baseNumber;
            Console.WriteLine("基数を入力:");
            baseNumber = int.Parse(Console.ReadLine());
            if (baseNumber > numberChar.Length)
            {
                Console.WriteLine("ERROR");
                return; 
            }
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
                        answer = numberChar[  inputNumber % baseNumber] + answer;
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

