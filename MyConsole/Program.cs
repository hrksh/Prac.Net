using System;
using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;

// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello World!");


// おテスト

var obj = new MyClass();

Task TaskA = obj.MethodA(); // TaskA として 待てるようにしたい
obj.MethodB();
obj.MethodC(TaskA); // TaskA を待ってから 完了させたいので、TaskA を渡して待たせる

System.Console.ReadLine();

/*
Duck testDuck = new ModelDuck();
testDuck.Display();
testDuck.Fly(); // まだ飛ばない
testDuck.Quack();

testDuck.SetFlyBehavior(new FlyRocketPowered());
testDuck.Fly(); // 飛んだw
*/

class MyClass()
{
    // 非同期処理の練習用

    public void MethodA()
    {
        // 待ちたい処理
        Console.WriteLine("MethodA Completed.");
    }

    public void MethodB()
    {
        // MethodA を待たずに終わらせたい処理
        Console.WriteLine("MethodB Completed.");
    }

    public void MethodC()
    {
        // MethodA を待ってから完了させたい処理
        Console.WriteLine("MethodC Completed.");
    }
}


