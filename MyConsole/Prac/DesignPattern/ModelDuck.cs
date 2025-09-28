using MyConsole.Prac.DesignPattern.Behavior;

namespace MyConsole.Prac.DesignPattern;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        this.FlyBehavior = new FlyNoWay();
        this.QuackBehavior = new QuackStandard();
    }
    public override void Display()
    {
        Console.WriteLine("i am model duck.");
    }
}