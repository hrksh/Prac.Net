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
    /// <summary>
    /// カモ基底クラス
    /// </summary>
    public class Duck
    {
        public void Quack() {}
        public void Swim() {}
        public void Display() {}
        public virtual bool Fly()
        {
            return false;
        }
    }

    public class ReadHeadDuck : Duck
    {
        public override bool Fly()
        {
           return true;
        }
    }
}