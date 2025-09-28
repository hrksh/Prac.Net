using MyConsole.Prac.DesignPattern.Interface;

namespace MyConsole.Prac.DesignPattern;

// 一連でやってきたこれらは、StrategyPattern

/// <summary>
/// カモ基底クラス
/// </summary>
public abstract class Duck
{
    public IQuackBehavior? QuackBehavior { get; set; }
    public IFlyBehavior? FlyBehavior { get; set; }

    public abstract void Display();

    /// <summary>
    /// Fly振舞いをセットする
    /// </summary>
    /// <param name="behavior">Flyインターフェイス</param>
    public void SetFlyBehavior(IFlyBehavior behavior) => FlyBehavior = behavior;
    /// <summary>
    /// Quack振舞いをセットする
    /// </summary>
    /// <param name="behavior">Quackインターフェイス</param>
    public void SetQuackBehavior(IQuackBehavior behavior) => QuackBehavior = behavior;
    
    // 継承先のクラスが利用するインターフェイスに委譲させる
    public bool? Quack()
    {
        return QuackBehavior?.Quack();
    }
    public bool? Fly()
    {
        return FlyBehavior?.Fly(); }
}
