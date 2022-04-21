using System;
using System.Threading;
namespace ScreenTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Console.WindowWidth},{Console.WindowHeight}");
            for(var i = 0; i <Console.WindowWidth; i++)
            {
                for(var j = 0; j <Console.WindowHeight; j++)
                {
                    Console.SetCursorPosition(left: i, top: j);
                    Console.Write($"{(i+j)%2}");
                    Console.ForegroundColor= ConsoleColor.Green;
                    Thread.Sleep(j*j/4);
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
