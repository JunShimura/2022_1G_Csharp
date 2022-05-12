using System;

namespace ex11
{
    class ex11
    {
        static void Main(string[] args)
        {
            //定数の宣言
            const int min = 1;
            const int max = 100;
            const char char1 = '〇';
            const char char2 = '●';
            //変数への入力
            Console.Write("幅：");
            var width = int.Parse(Console.ReadLine());
            Console.Write("高さ：");
            var height = int.Parse(Console.ReadLine());
            if (width >= min && width <= max && height >= min && height <= max)
            {
                Console.WriteLine("1.長方形");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        s += char1;
                    }
                    Console.WriteLine(s);
                }
                /*
                var s2 = "";
                              for (var i = 1; i <= height*width; i++) //高さ×幅
                                {
                                    s2+= char1;
                                    if(i%width == 0)
                                    {
                                        s2+= '\n';
                                    }
                                }
                                Console.Write(s2);
                */

                Console.WriteLine("2.よこ縞");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if (i % 2 == 0)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("3.縦縞");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if (j % 2 == 0)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("4.中抜け");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if (i == 1 || i == height || j == 1 || j == width)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("5.直角三角形");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    var length = (float)i / height * width;
                    for (var j = 1; j <= length; j++) //行ごとの幅
                    {
                        s += char1;
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("6.チェック");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if ((i + j) % 2 == 0)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("7.円");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= height; j++) //行ごとの幅
                    {
                        var r = (i-height/2)*(i-height/2)+(j-height/2)*(j-height/2);
                        if (r<height*height/4)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }


            }
            else
            {
                Console.WriteLine("入力エラー"); //入力エラー
            }
        }
    }
}
