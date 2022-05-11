using System;

namespace Ex09_ex01
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
            string[] judgeMessage = { "あいこです", "あなたの勝ちです", "あなたの負けです" };
            Console.WriteLine(judgeMessage[(com - player + 3) % 3]);
        }
    }
}

