namespace ClassSample
{
    class ClassSampleMain
    {
        static void Main(string[] args)
        {
            // インスタンス
            ClassSampleA classSampleA = new ClassSampleA(10,-6);
            var a = classSampleA.Func();
            int b;
            //classSampleA.a = 5; //エラーになる
            Console.WriteLine($"a={a}");
        }
    }
    
    class ClassSampleA   //　Classの宣言
    {
        int a = 3;
        int b = 5;
        public ClassSampleA(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Func()
        {
            return a + b;
        }
    }
    class Person
    {
        public string Name;  //名前
        public int Age;         // 年齢

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}