using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern;

/// <summary>
/// カモ基底クラス
/// </summary>
public abstract class Duck
{
    private IQuackBehavior _quackBehavior;
    private IFlyBehavior _flyBehavior;

    public  IQuackBehavior QuackBehavior
    {
        get => _quackBehavior;
        set => _quackBehavior = value;
    }

    public IFlyBehavior FlyBehavior
    {
        get => _flyBehavior;
        set => _flyBehavior = value;
    }

    public abstract void Display();

    // 継承先のクラスが利用するインターフェイスに委譲させる
    
    public bool Quack()
    {
        return _quackBehavior.Quack();
    }

    public bool Fly()
    {
        return _flyBehavior.Fly();
    }
}