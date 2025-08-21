using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 諸々を削除した

Console.WriteLine("Hello World!");
Console.ReadLine();

namespace Prac
{

}

namespace Common.Util
{

}

// ファイル分けは後から実施

namespace Prac.DesignPattern
{
    // 抽象クラスでやればいいって訳じゃないらしい
    // こう？
    
    /// <summary>
    /// カモ基底クラス
    /// </summary>
    public abstract class Duck : IFlyBehavior, IQuackBehavior
    {
        private IQuackBehavior _quackBehavior;
        private IFlyBehavior _flyBehavior;

        public IQuackBehavior QuackBehavior
        {
            get => _quackBehavior;
            set => _quackBehavior = value;
        }

        public IFlyBehavior FlyBehavior
        {
            get => _flyBehavior;
            set => _flyBehavior = value;
        }
        
        public void Swim() {}
        public void Display() {}

        public bool Quack()
        {
            return (bool)_quackBehavior?.Quack();
        }
        public bool Fly()
        {
            return (bool)_flyBehavior?.Fly();
        }
    }

    public class ReadHeadDuck : Duck
    {
        public ReadHeadDuck()
        {
            // Java だと Interface が new できるっぽい？ C# じゃ無理そうなので別の方法を考える？
            this.FlyBehavior = new IFlyBehavior();
            this.QuackBehavior = new IQuackBehavior();
        }
    }

    public interface IFlyBehavior
    {
        public bool Fly();
    }
    
    public interface IQuackBehavior
    {
        public bool Quack();
    }
}