using System;
using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;

// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello World!");


// おテスト

var obj = new MyClass();

Task TaskA = obj.MethodA(); // TaskA が受け取れるよう非同期メソッド化
await obj.MethodB();
await obj.MethodC(TaskA); // TaskA を待ってから 完了させたいので、TaskA を渡して待たせる

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

    public async Task MethodA()
    {
        Console.WriteLine("MethodA Started.");
        // 5秒間 待機する処理
        await Task.Delay(5000);
        Console.WriteLine("MethodA Completed.");
    }

    public async Task MethodB()
    {
        // MethodA を待たずに終わらせたい処理
        // こいつは逆にすぐ終わらせたい。出力なら先にこいつが完了した表示がほしい。
        // 先に終わらせたいので、この処理も非同期処理になる => async 化
        Console.WriteLine("MethodB Started.");
        await Task.Delay(5); // 5 msec の短い処理 を待ったら完了する
        Console.WriteLine("MethodB Completed.");
    }

    public async Task MethodC(Task taskA)
    {
        // MethodA を待ってから完了させたい処理
        Console.WriteLine("MethodC Started.");
        await taskA; // TaskAを待ってから終了
        Console.WriteLine("MethodC Completed.");
    }
}


