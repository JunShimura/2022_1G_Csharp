namespace Ex24_saito
{
    using System;
    class x24_saito
    {
        static void Main(String[] args)
        {

            while (true)
            {
                float head = InputFloat("頭の数を入力してください", 0, 1000);
                float leg = InputFloat("足の数を入力してください", 0, 1000);


                float turtle = (leg - 2.0f * head) / 2.0f;
                float crane = head - turtle;

                if (turtle >= 0 && crane >= 0 && (turtle * 10) % 10 == 0 && (crane * 10) % 10 == 0)
                {
                    Console.Write($"鶴が{crane}、亀が{turtle}");
                    break;
                }
                else
                {
                    Console.WriteLine("入力エラーです");
                }
            }
        }

        static float InputFloat(string message, float min, float max)
        {
            while (true)
            {
                float number;
                Console.Write(message + "(" + min + "～" + max + ")");
                try
                {
                    number = float.Parse(Console.ReadLine());


                    if (min <= number && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("入力エラーです");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("えらー");
                }


            }
        }
    }
}