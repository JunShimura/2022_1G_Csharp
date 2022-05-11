using System;

class K
{
    static void Main(String[] args)
    {
        Console.Write("数字を入力してください");
        var N = int.Parse(Console.ReadLine());
        if (N <= 9 && N > 0)
            for (int i = 1; i <= 9; i++)
                Console.WriteLine("{0}*{1}={2}", N, i, N * i);
        else
            Console.WriteLine("入力エラー");
    }
}
