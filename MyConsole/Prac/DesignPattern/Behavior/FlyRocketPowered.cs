using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern.Behavior;

public class FlyRocketPowered : IFlyBehavior
{
    public bool Fly()
    {
        Console.WriteLine("Flying with Rocket.");
        return true;
    }
}