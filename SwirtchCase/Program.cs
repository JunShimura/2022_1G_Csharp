using System;

namespace SwirtchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var com = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=ぐう、1=ちょき、2=ぱあ)");
            var player = int.Parse(Console.ReadLine());
            if(com== 0)
            {
                Console.WriteLine("私はぐう");
            }
            else if(com== 1)
            {
                Console.WriteLine("私はちょき");
            }
            else if(com== 2)
            {
                Console.WriteLine("私はぱあ");
            }
            
            switch (com)
            {
                
                case 0:
                    Console.WriteLine("私はぐう");
                    break;
                case 1:
                    Console.WriteLine("私はちょき");
                    break;
                case 2:
                    Console.WriteLine("私はぱあ");
                    break;
                default:
                    break;
            }
            float f=0;
            switch (f)
            {
                case float value when value>0.0f:
                    f=0.0f;
                    break;
            }



        }
    }
}
