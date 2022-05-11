using System;

namespace Ex09_ex01_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    var com = i;
                    var player = j;
                    var judge = (com - player + 3) % 3;
                    Console.WriteLine($"com={com},player={player},judge={judge}");
                }
            }
        }
    }
}
