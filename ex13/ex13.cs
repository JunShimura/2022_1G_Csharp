using System;

namespace Ex13
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
            var answer = rand.Next(1, max); //　乱数が入る
            var score = 0;  //最終的な点数
            var tempScore = 10000; //答えた回数で変動する仮の点数
            //回答を入力
            var lastDiff = 0; //前回の差
            for (int i = 0; i < maxTime; i++)
            {
                Console.WriteLine($"あと{maxTime - i}回答えられます、\nいくつでしょうか？");
                var inputNum = int.Parse(Console.ReadLine());
                if (inputNum == answer)
                {   // あたり
                    Console.WriteLine("当たり！");
                    score = tempScore;  //得点が入った
                    break;
                }
                else
                {   // はずれ
                    var diff = inputNum - answer;
                    if (diff < 0)
                    { //負数なのでー1をかけて絶対値にする
                        diff *= (-1);
                    }
                    if (i > 0) //2回目以降
                    {
                        if (lastDiff < diff)
                        { // 前回入力より遠ざかった場合「遠くなりました」
                            Console.WriteLine("遠くなりました");
                        }
                        else if (lastDiff > diff)
                        {   // 前回入力より近づいた場合「近づきました」
                            Console.WriteLine("近づきました");
                        }
                        else
                        {  // 差が変わらない場合は「変わりません」 
                            Console.WriteLine("差が変わりません");
                        }
                    }
                    lastDiff = diff;
                }
                tempScore /= 2; //得点が入らないので減点
            }
            Console.WriteLine($"答えは{answer}でした\n{score}点");
        }
    }
}
