using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern.Behavior;

/// <summary>
/// 翼を使って飛ぶ
/// </summary>
public class FlyWithWings : IFlyBehavior
{
    public bool Fly()
    {
        Console.WriteLine("Flying with wings.");
        return true;
    }
}
