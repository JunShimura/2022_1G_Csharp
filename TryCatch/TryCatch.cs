namespace TryCatch
{
    internal class TryCatch
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("数字を入力してください：");
                string value = Console.ReadLine();
                try
                {
                    var number = Int32.Parse(value);
                    Console.WriteLine("{0} --> {1}", value, number);
                }
                catch (FormatException)
                {   //変換できない文字
                    Console.WriteLine("{0}: Bad Format", value);
                    continue;
                }
                catch (OverflowException)
                {//オーバーフロー
                    Console.WriteLine("{0}: Overflow", value);
                    continue;
                }
                catch
                {
                    Console.WriteLine("何かおかしい！");
                    continue;
                }
                break;
            }

            int a;
            while (true)
            {
                Console.Write("二つ目：数字を入力してください：");
                bool sucess = int.TryParse(Console.ReadLine(), out a);
                if (sucess)
                {
                    Console.WriteLine($"変換できました、値は{a}");
                    break;
                }
                else
                {
                    Console.WriteLine($"変換できませんでした");
                }
            }
        }
    }
}