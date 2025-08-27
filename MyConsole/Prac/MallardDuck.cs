using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;
using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        // コンストラクタでSetするのはやめて、BaseでSetter、Getterを用意する
    }
    
    public override void Display()
    {
        Console.WriteLine("Mallard Duck");
    }
}