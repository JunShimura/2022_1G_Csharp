using System;

namespace InputUtilitys
{
    class InputUtilityTest
    {
        static void Main(string[] args)
        {
            var name = InputUtility.Input("名前は？");
            Console.WriteLine($"{name}さんですね。");
            var age = InputUtility.InputNumber("年齢を入力して下さい",3,100 ,"うそはだめです");
            Console.WriteLine($"{name}さんは、{age}才ですね。");
            var tall = InputUtility.InputFloat("身長はいくつですか(cm)",100,300, "うそですね");
            Console.WriteLine($"{name}さんは、{age}才で、身長は{tall}cmですね。");
            Console.WriteLine($"未成年判定は{InputUtility.IsInRange<int>( age,1,100)}");
        }
    }
}
