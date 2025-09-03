using System;
using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;

// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello World!");


// おテスト

var obj = new MyClass();

Task TaskA = obj.MethodA(); // TaskA が受け取れるよう非同期メソッド化
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

    public async Task MethodA()
    {
        // 待ちたい処理 が Task化できた。
        // await => 指定されてる処理を待たせるような感じ・・・
        // これなら、この処理が終わるまではこのタスクは待つ
        await Task.Run(() =>
        {
            // 5秒間 待機する処理
            for (int i = 1; i <= 5; i++)
            {
                Task.Delay(1000);
                Console.WriteLine(i);
            }
            Console.WriteLine("MethodA Completed.");
        });
    }

    public void MethodB()
    {
        // MethodA を待たずに終わらせたい処理
        Console.WriteLine("MethodB Completed.");
    }

    public void MethodC(Task task)
    {
        // MethodA を待ってから完了させたい処理
        Console.WriteLine("MethodC Completed.");
    }
}


