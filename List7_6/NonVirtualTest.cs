using System;

class Base
{
    // 基底クラスBaseのTest()メソッド
    public void Test()
    {
        Console.WriteLine("Base.Test()");
    }
}

class Derived : Base
{
    // 派生クラスDerivedのTest()メソッド
    public new void Test()
    {
        Console.WriteLine("Derived.Test()");
    }
}

class NonVirtualTest
{
    static void Main()
    {
        Base a = new Base();
        // 変数aの静的な型はBaseなので
        // 基底クラスのTest()メソッドが呼ばれる
        a.Test();

        Base b = new Derived();
        // 変数bの静的な型はBaseなので
        // 基底クラスのTest()メソッドが呼ばれる
        b.Test();

        Derived c = new Derived();
        // 変数cの静的な型はDerivedなので
        // 派生クラスのTest()メソッドが呼ばれる
        c.Test();
        Base d = c;
        d.Test();   //　Base.Testが呼ばれる
    }
}
