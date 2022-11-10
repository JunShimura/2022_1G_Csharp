using System;

class Base
{
    // 基底クラスBaseのTest()メソッド（virtual修飾子付き）
    public virtual void Test()
    {
        Console.WriteLine("Base.Test()");
    }
}

class Derived : Base
{
    // 派生クラスDerivedのTest()メソッド（override修飾子は後述）
    public override void Test()
    {
        Console.WriteLine("Derived.Test()");
    }
}

class VirtualTest
{
    static void Main()
    {
        Base a = new Base();
        // 変数aの動的なクラスがBaseなので
        // 基底クラスのTest()メソッドが呼ばれる
        a.Test();

        Base b;
         Derived b2 = new Derived();
        b = b2;
        // 変数bの動的なクラスがDerivedなので
        // 派生クラスのTest()メソッドが呼ばれる
        b.Test();

        Derived c = new Derived();
        // 変数cの動的なクラスがDerivedなので
        // 派生クラスのTest()メソッドが呼ばれる
        c.Test();
        Base d = c;
        d.Test();   // Derived.Testが呼ばれる
    }
}