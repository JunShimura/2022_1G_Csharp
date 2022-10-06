using InputUtilitys;
namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Box.GetSurface(
                    InputUtility.InputFloat("箱の幅"),
                    InputUtility.InputFloat("箱の高さ"),
                    InputUtility.InputFloat("箱の奥行")
                    );
            Console.WriteLine($"箱の表面積は{s}");
        }
    }
}