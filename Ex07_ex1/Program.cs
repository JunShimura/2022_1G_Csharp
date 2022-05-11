using System;

namespace ex07_ex1
{
    class ex07_ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("体重を入力(kg：");
            double weight = double.Parse(Console.ReadLine());

            switch (weight)
            {
                case <30.0:
                    Console.WriteLine($"ガリガリ\n{30 - weight}kg足りません");
                    break;
                case <80.0:
                    Console.WriteLine("ちょうどいい");
                    break;
                case <120:
                    Console.WriteLine($"デブかも\n{weight - 80}kg減らしましょう");
                    break;
                default:
                    Console.WriteLine("おすもうさん\n危険です");
                    break;
            }
        }
    }
}