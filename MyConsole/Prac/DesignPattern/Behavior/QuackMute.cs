using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern.Behavior;

/// <summary>
/// ミュート
/// </summary>
public class QuackMute : IQuackBehavior
{
    public bool Quack()
    {
        Console.WriteLine("...");
        return false;
    }
}
