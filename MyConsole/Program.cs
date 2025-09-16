using System;
using System.Runtime.CompilerServices;
using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;

// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello World!");

// おテスト

int binary1 = 0b0000_0000_0111_0000;
int binary2 = 0b1001_0100_0111_0000;
int part = (binary2 >> 10) & ((1 >> 6) - 1);
bool bitON = part != 0;

Console.WriteLine("Part:");
Console.WriteLine(Convert.ToString(part, 2).PadLeft(32, '0'));
Console.WriteLine($"Bit is {bitON}");


System.Console.ReadLine();

class MyAsyncClass()
{
    // 非同期処理の練習用

    public async Task MethodA()
    {
        Console.WriteLine("MethodA Started.");
        
        // 10秒間 待機する処理
        for (int i = 1; i <= 10; i++)
        {
            await Task.Delay(1000);
            Console.WriteLine(i);
        }
        Console.WriteLine("MethodA Completed.");
    }

    public async Task Something()
    {
        // ここにも重たい処理をしたい
        await Task.Delay(3000);
    }

    public async Task MethodB()
    {
        // MethodA を待たずに終わらせたい処理
        Console.WriteLine("MethodB Started.");
        await Task.Delay(50);
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

class MyBitClass()
{
    public MyBitClass(int number) : this()
    {
        Console.WriteLine(number);
    }

    public void Show32bitString(int target)
    {
        Console.WriteLine(Convert.ToString(target, 2).PadLeft(32,'0'));
    }
}

