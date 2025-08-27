using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern;

/// <summary>
/// カモ基底クラス
/// </summary>
public abstract class Duck
{
    private IQuackBehavior _quackBehavior;
    public  IQuackBehavior QuackBehavior
    {
        get => _quackBehavior;
        set => _quackBehavior = value;
    }
    private IFlyBehavior _flyBehavior;
    public IFlyBehavior FlyBehavior
    {
        get => _flyBehavior;
        set => _flyBehavior = value;
    }
    public abstract void Display();

    /// <summary>
    /// Fly振舞いをセットする
    /// </summary>
    /// <param name="behavior">Flyインターフェイス</param>
    public void SetFlyBehavior(IFlyBehavior behavior) => _flyBehavior = behavior;
    /// <summary>
    /// Quack振舞いをセットする
    /// </summary>
    /// <param name="behavior">Quackインターフェイス</param>
    public void SetQuackBehavior(IQuackBehavior behavior) => _quackBehavior = behavior;
    
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