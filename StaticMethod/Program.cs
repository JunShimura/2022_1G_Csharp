using InputUtilitys;
namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 幅3,高さ4,奥行5の箱の表面積を求める（インスタンスを作ってから計算）
            Box box1 = new Box(3, 4, 5);  // newが必要
            var s1 = box1.GetSurface();
            // 別の物で表面積を求めるならまたnewが要る
            box1 = new Box(1.5f,2,3.75f);  // newが必要
            s1 = box1.GetSurface();

            // 幅3,高さ4,奥行5の箱の表面積を求める（インスタンスを作らずに計算）
            var s2 = Box.GetSurface(3,4,5);
            var s3 = Box.GetSurface(1.5f, 2, 3.75f);
            Console.WriteLine($"箱2の表面積は{Box.GetSurface(3, 4, 5)}");
            
            //　入力値から計算
            var s = Box.GetSurface( // newが不要
                    InputUtility.InputFloat("箱の幅"),
                    InputUtility.InputFloat("箱の高さ"),
                    InputUtility.InputFloat("箱の奥行")
                    );
            Console.WriteLine($"箱の表面積は{s}");
        }
    }
}