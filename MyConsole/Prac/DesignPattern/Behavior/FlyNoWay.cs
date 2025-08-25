using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern.Behavior;

/// <summary>
/// 飛ばない
/// </summary>
public class FlyNoWay : IFlyBehavior
{
    public bool Fly()
    {
        Console.WriteLine("Flying without way.");
        return false;
    }
}
