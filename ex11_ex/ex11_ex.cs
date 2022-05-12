using System;
using System.Threading;

namespace ex11
{
    class ex11
    {
        static void Main(string[] args)
        {
            //定数の宣言
            const int min = 1;
            const int max = 50;
            const char char1 = '■';
            const char char2 = '　';
            Console.SetWindowSize(max, max);
            int windowHeight = max/2;
            int windowWidth = max/2;
            char[,] renderMap = new char[windowWidth, windowHeight];
            int centerX = windowWidth/2;
            int centerY = windowHeight/2;

            Console.WriteLine($"WindowSize=({windowWidth},{windowHeight})");
            //変数への入力

            Console.Write("半径：");
            var radius = int.Parse(Console.ReadLine());
            centerY = windowHeight-radius;

            Queue<BlitBit> blit = new Queue<BlitBit>();
            
            for (; ; )
            {
                centerY= (centerY+1)%(windowHeight-radius);
                for (var y = 0; y < windowHeight; y++) //高さ
                {
                    var s = "";
                    for (var x = 0; x <windowWidth; x++) //行ごとの幅
                    {
                        var r = (x-centerX)*(x-centerX)+(y-centerY)*(y-centerY);
                        if (r<radius*radius/4)
                        {
                            if (renderMap[x, y] != char1)
                            {
                                renderMap[x, y] = char1;
                                blit.Enqueue(new BlitBit( x, y, char1));
                            }
                        }
                        else
                        {
                            if(renderMap[x, y] != char2)
                            {
                                renderMap[x, y] = char2;
                                blit.Enqueue(new BlitBit( x, y, char2));
                            }
                        }
                    }
                }
                var render = String.Empty;
/*                for (var y = windowHeight-1; y >=0; y--)
                {
                    for (var x = 0; x < windowWidth; x++)
                    {
                        render+=renderMap[x, y];
                    }
                    render+='\n';
                }
                Console.Clear();
                Console.WriteLine(render);
*/             
                while(blit.Count > 0)
                {
                    var b= blit.Dequeue();
                    Console.SetCursorPosition(b.x, b.y);
                    Console.Write(b.bit);
                }
                Thread.Sleep(50);
            }
        }
        public struct BlitBit
        {
            public int x;
            public int y;
            public char bit;  
            public BlitBit(int x,int y,char b)
            {
                this.x = x;
                this.y = y;
                this.bit = b;
            }
        }
    }
}
