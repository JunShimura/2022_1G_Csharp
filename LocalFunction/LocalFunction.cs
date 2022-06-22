using System;

namespace LocalFunction
{
    class LocalFuctionTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("こんにちは");
            Func1();
            static void Func1()
            {
                Console.WriteLine("いただきます");
            }
        }
    }
}