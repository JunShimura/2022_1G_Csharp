using System;

namespace MethodSample
{
    class ex18
    {
        static void Main(string[] args)
        {
            HelloWorldEnglish();
            HelloWorldBelorussiya();
        }
        static void HelloWorldEnglish()
        {
            Console.WriteLine("Hello World!");
        }
        static void HelloWorldJapanese()
        {
            Console.WriteLine("こんにちは世界!");
        }
        static void HelloWorldBelorussiya()
        {
            Console.WriteLine("Прывітанне Сусвет!");
        }
    }
}