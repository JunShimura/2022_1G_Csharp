using System;

namespace ex14
{
    class ConvertBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数を入力:");
            var inputNumber = int.Parse(Console.ReadLine());
            string result = string.Empty;
            if (inputNumber >= 0)
            {
                result = ToBinaryString(inputNumber);
            }
            Console.WriteLine($"={result}");
        }
        static string ToBinaryString(int i)
        {
            if (i > 0)
            {
                return $"{ToBinaryString(i / 2)}{i%2}";
            }
            return string.Empty;
        }
    }
}

