
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
