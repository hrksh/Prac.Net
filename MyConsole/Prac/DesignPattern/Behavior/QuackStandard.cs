using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern.Behavior;

/// <summary>
/// 通常鳴き声
/// </summary>
public class QuackStandard : IQuackBehavior
{
    public bool Quack()
    {
        Console.WriteLine("Quacking...(standard)");
        return true;
    }
}
