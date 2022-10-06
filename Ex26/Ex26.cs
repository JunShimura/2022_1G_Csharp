using InputUtilitys;
namespace Ex26
{
    internal class Ex26
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Console.WriteLine($"表面積は{box1.GetSurface()}");
            Console.WriteLine($"体積は{box1.GetVolume()}");
            Box box2 = new Box(
                InputUtility.InputFloat("幅："),
                InputUtility.InputFloat("高さ："),
                InputUtility.InputFloat("奥行き：")
                );
            Console.WriteLine($"表面積は{box2.GetSurface()}");
            Console.WriteLine($"体積は{box2.GetVolume()}");

        }
    }
}