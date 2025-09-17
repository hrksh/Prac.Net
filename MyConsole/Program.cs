using System;
using System.Runtime.CompilerServices;
using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;

// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello World!");

// おテスト

var obj = new MyBitController(573);
obj.VerifyBit(obj.Input, 6, 4);

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



public class MyBitController
{
    private string _binary = string.Empty;
    public string Binary => this._binary;
    private int _input = 0;
    public int Input => this._input;

    private const int _maxbit = 32;

    private MyBitController() {}

    public MyBitController(int num)
    {
        this._input = num;
        this._binary = ToBin32((uint)num);
        this.ShowCurrentNumber();
        this.ShowBinaryString();
    }

    public void ShowCurrentNumber() => Console.WriteLine($"input:  {this._input}");
    public void ShowBinaryString() => Console.WriteLine($"binary: {this._binary}");

    public static string ToBin32(uint v) => Convert.ToString(v, 2).PadLeft(_maxbit, '0');
    public static string ToBin(uint v, int width) => Convert.ToString(v, 2).PadLeft(width, '0');

    public static int FromBin(string binary) => Convert.ToInt32(binary, 2);

    public bool VerifyBit(int target, int startbit, int bitLength)
    {
        // --- Guard ---
        if (startbit < 0 || bitLength <= 0 || startbit >= _maxbit) 
            throw new ArgumentOutOfRangeException(nameof(startbit), "startbitは0〜31");
        if (bitLength > _maxbit) 
            throw new ArgumentOutOfRangeException(nameof(bitLength), "bitLengthは1〜32");
        if (startbit + bitLength > _maxbit) 
            Console.WriteLine($"[warn] 範囲が32ビットを跨ぎます: start={startbit}, len={bitLength}");

        uint u = unchecked((uint)target);

        // 論理右シフト（intの算術右シフトを避ける）
        uint shifted = u >> startbit;

        // 32ビット対応のマスク
        uint mask = (bitLength == 32) ? 0xFFFF_FFFFu : ((1u << bitLength) - 1u);

        uint extracted = shifted & mask;
        bool anySet = extracted != 0;

        Console.WriteLine($"target : {ToBin32(u)}");
        Console.WriteLine($"shift  : {ToBin32(shifted)}  (>> {startbit})");
        Console.WriteLine($"mask   : {ToBin(mask, bitLength)}  (len={bitLength})");
        Console.WriteLine($"select : {ToBin(extracted, bitLength)}  => {(anySet ? "true" : "false")}");

        return anySet;
    }
}
