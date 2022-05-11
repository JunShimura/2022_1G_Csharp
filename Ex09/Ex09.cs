using System;

namespace ex09
{
    class Ex09
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var com = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=ぐう、1=ちょき、2=ぱあ)");
            var player = int.Parse(Console.ReadLine());
            Console.WriteLine($"私は{com}、あなたは{player}");
            //ここで勝ち負けの判定を行いメッセージを出力
            if (player==0)
            {
                if (com == 0)
                {
                    Console.WriteLine("あいこです");
                }
                else if (com==1)
                {
                    Console.WriteLine("あなたの勝ちです");
                }
                else if (com == 2)
                {
                    Console.WriteLine("あなたの負けです");
                }
            }
            else if (player == 1)
            {
                if (com == 0)
                {
                    Console.WriteLine("あなたの負けです");
                }
                else if (com == 1)
                {
                    Console.WriteLine("あいこです");
                }
                else if (com == 2)
                {
                    Console.WriteLine("あなたの勝ちです");
                }
            }
            else if (player == 2)
            {
                if (com == 0)
                {
                    Console.WriteLine("あなたの勝ちです");
                }
                else if (com == 1)
                {
                    Console.WriteLine("あなたの負けです");
                }
                else if (com == 2)
                {
                    Console.WriteLine("あいこです");
                }
            }

        }
    }
}
