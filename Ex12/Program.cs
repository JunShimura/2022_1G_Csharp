using System;

namespace Ex12
{
    class DetermineNumber
    {
        static void Main(string[] args)
        {
            //　難易度の設定
            const int max = 10;   //乱数の最大値
            const int maxTime = 3; //解答できる回数

            //  乱数で正解を設定
            Random rand = new Random();    // 乱数生成オブジェクトを生成
            int answer = rand.Next(1, max); //　乱数が入る
            int score = 0;  //最終的な点数
            int tempScore = 10000; //答えた回数で変動する仮の点数
            //回答を入力
            for (int i = 0; i < maxTime; i++)
            {
                int inputNum;
                for (; ; )
                {
                    Console.WriteLine($"あと{maxTime - i}回答えられます、\nいくつでしょうか？");
                    inputNum = int.Parse(Console.ReadLine());
                    if(inputNum>= 1&& inputNum<max)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("入力エラー");
                    }
                }
                if (inputNum == answer)
                {
                    Console.WriteLine("当たり！");
                    score = tempScore;  //得点が入った
                    break;
                }
                else if (inputNum > answer)
                {
                    Console.WriteLine("はずれ,もっと小さい");
                }
                else
                {
                    Console.WriteLine("はずれ,もっと大きい");
                }
                tempScore /= 2; //得点が入らないので減点
            }
            Console.WriteLine($"答えは{answer}でした\n{score}点");
        }
    }
}
