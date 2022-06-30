namespace ColoredText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            OutputColoredText("Hello, World!", ConsoleColor.Blue);
            OutputColoredText("Hello, World!", ConsoleColor.Red);
        }
        static void OutputColoredText(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
            Console.Beep(440, 100);
            Console.Beep(440*2, 200);
            Console.Beep(440*4, 400);
        }



    }
}