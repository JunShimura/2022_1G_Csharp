using System;

namespace Ex21
{
    class ex21_hint
    {

        static void Main(string[] args)
        {
            string s1 = InputString("名前を入力してください");
            int no = InputNumber("ほめ指数を入力してください（１から５）");
            if(no>=1 && no <= 5)
            {
                string s2 = Praise(s1, no);
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
        static string Praise(string s, int praiseIndex)
        {
            string answer = string.Empty;
            string[] message = { "かっこいい", "ゲームがうまい", "つよい", "もうどうにかして", "つきあってください" };
            for(var i = 1;( i <= praiseIndex)&&praiseIndex<=message.Length; i++)
            {
                answer += $"{s}さん{message[i-1]}!\n";
            }
            return answer;
        }
        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }
        static string InputString(string message)
        {
            Console.WriteLine(message);
            var i = Console.ReadLine();
            return i;
        }
    }
}
