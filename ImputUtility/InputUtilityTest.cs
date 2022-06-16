using System;

namespace InputUtilitys
{
    class InputUtilityTest
    {
        static void Main(string[] args)
        {
            var name = InputUtility.Input("名前は？");
            Console.WriteLine($"{name}さんですね。");
            var age = InputUtility.InputNumber(100, 3, "年齢を入力して下さい","うそはだめです");
            Console.WriteLine($"{name}さんは、{age}才ですね。");
            var tall = InputUtility.InputFloat(300f,  100,"身長はいくつですか(cm)", "うそですね");
            Console.WriteLine($"{name}さんは、{age}才で、身長は{tall}cmですね。");
        }
    }
}
