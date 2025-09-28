using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern.Behavior;

/// <summary>
/// キューキュー
/// </summary>
public class QuackSqueak : IQuackBehavior
{
    public bool Quack()
    {
        Console.WriteLine("Squeaking...");
        return true;
    }
}
