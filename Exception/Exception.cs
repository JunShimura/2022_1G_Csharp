namespace Exception
{
    internal class Exception
    {
        // 文字→整数に変換する関数CharToInt
        static int CharToInt(char c)
        {
            if (c < '0' || c > '9')
            {
                throw new FormatException();
            }
            return c - '0';
        }

        // 文字列→整数に変換する関数StringToInt
        static int StringToInt(string str)
        {
            int val = 0;
            foreach (char c in str)
            {
                int i = CharToInt(c);
                val = val * 10 + i;
            }
            return val;
        }

        static void Main()
        {
            Console.WriteLine($"{StringToInt("12345")}");

            // 数字以外の文字が含まれている
            Console.WriteLine($"{StringToInt("12a45")}");
        }
    }
}