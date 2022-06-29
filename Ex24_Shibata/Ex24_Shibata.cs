using System;
using System.Linq;

public class Ex24_Shibata
{

    const float xMin = 0;
    const float xMax = 1000;
    const float yMin = 0;
    const float yMax = 1000;


    static void Main()
    {

        for (int i = 0; i < 10;)
        {
            string v = null;
            Console.WriteLine("頭数 0～1000");
            string n = Console.ReadLine();
            if (n.All(char.IsDigit))
            {
                Int64 k = Int64.Parse(n);
                if (k > 1000)
                {
                    Console.WriteLine("数が多すぎます");
                }
                else
                {
                    int x = Int32.Parse(n);


                    Console.WriteLine("足数 0～1000");
                    string m = Console.ReadLine();
                    if (m.All(char.IsDigit))
                    {
                        Int64 b = Int64.Parse(m);
                        if (b > 1000)
                        {
                            Console.WriteLine("数が多すぎます");
                        }
                        else
                        {
                            int y = Int32.Parse(m);
                            i = 10;
                            int kame = (y - 2 * x) / (4 - 2);
                            int turu = x - kame;
                            string o = tye(x, y, v);
                            string p = tye1(x, y, v);
                            if (p == null && o == null)
                            {
                                Console.WriteLine($"カメの数{kame}匹、鶴の数{turu}");
                            }
                            else
                            {
                                Console.WriteLine(o);
                                Console.WriteLine(p);
                                i = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("自然数以外の入力はやめてください");
                    }


                }
            }
            else
            {
                Console.WriteLine("自然数以外の入力はやめてください");
            }



        }

    }

    static string tye(int x, int y, string o)
    {
        int kame = (y - 2 * x) / (4 - 2);
        int turu = x - kame;
        if (kame < 0 || turu < 0)
        {
            o = "どこかおかしいですね";
        }

        return o;
    }
    static string tye1(int x, int y, string p)
    {
        int kame = (y - 2 * x) / (4 - 2);
        int turu = x - kame;
        int h = kame * 4 + turu * 2;
        if (h == y)
        {

        }
        else if (h < y)
        {
            p = "どいつかが足をくわえてまね";
        }
        else if (h > y)
        {
            p = "足が付いてないやつがいますか？";
        }
        return p;
    }

}