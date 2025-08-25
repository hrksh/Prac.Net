using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;
using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        this.QuackBehavior = new QuackStandard();
        this.FlyBehavior = new FlyWithWings();
    }
    
    public override void Display()
    {
        Console.WriteLine("Mallard Duck");
    }
}