using System;
namespace Chapter2_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力してください");
            var x = int.Parse(Console.ReadLine());
            var y = x * x;
            Console.WriteLine($"{x}×{x}={y}");
        }
    }
}
