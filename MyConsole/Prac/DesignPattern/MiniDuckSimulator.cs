namespace MyConsole.Prac.DesignPattern;

public class MiniDuckSimulator
{
    private Duck _duck = new MallardDuck();
    public void Display() { _duck.Display(); }
    public void Fly() { _duck.Fly(); }
    public void Quack() { _duck.Quack(); }
}