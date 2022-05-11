
using System;

namespace ex07
{
    class ex07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("体重を入力(kg：");
            double weight = double.Parse(Console.ReadLine());
            if (weight < 30.0)
            {
                Console.WriteLine("ガリガリ\n{30 - weight}kg足りません");
            }
            else if (weight < 80.0)
            {
                Console.WriteLine("ちょうどいい");
            }
            else if (weight < 120)
            {
                Console.WriteLine("デブかも\n{weight - 80}kg減らしましょう");
            }
            else
            {
                Console.WriteLine("おすもうさん\n危険です");
            }
        }
    }
}