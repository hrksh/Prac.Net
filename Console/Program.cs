using System.Runtime.Versioning;
using System.Text;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
 * develop
 * デザインパターンの練習用
 * + VS GUI側からのGit操作も兼ねる
 * シングルトンで実装を追加・・・
 */

// var Satoshi = new Person("satoshi", 28);
// var takeshi = new Person("takeshi", 32);

Humans.Inst().AddPerson(new Person("satoshi", 28));
Humans.Inst().AddPerson(new Person("takeshi", 32));

public abstract class PersonBase
{
    private string _name = string.Empty;
    internal string Name { get { return _name; } }
    private int _age = 0;
    internal int Age { get { return this._age; } }
    internal PersonBase(string name , int age) { this._name = name; this._age = age; }
    internal virtual bool Introduction() { return false; }
}

public class Person : PersonBase
{
    const string SeparatorStringBarStyle = " ---- New Person Generated. ---- ";
    const string FIntroductionName = "Name : {0}";
    const string FIntroductionAge = "Age : {0}";
    public Person(string name, int age) : base(name, age) { }
    internal override bool Introduction()
    {
        if (string.IsNullOrEmpty(this.Name) || this.Age < 0) return false;

        StringBuilder sb = new StringBuilder();
            sb.Append(SeparatorStringBarStyle);
            sb.Append(Environment.NewLine + $"{string.Format(FIntroductionName, this.Name)}");
            sb.Append(Environment.NewLine + $"{string.Format(FIntroductionAge, this.Age)}");
        Console.WriteLine(sb);
        return true;
    }
}

class SuperPerson : Person
{
    public SuperPerson(string name, int age) : base(name, age) { }
}

public class Humans
{    
    private static Humans? _humans = null;
    // Singleton
    private Humans() { }
    public static Humans Inst()
    {
        if (_humans == null) _humans = new Humans();
        return _humans;
    }
    static List<Person> _humanList = new List<Person>();
    public void AddPerson(Person psn) { _humanList.Add(psn); }
    public void ShowCntHumans() { Console.WriteLine(_humanList.Count()); }
    public bool IsExistPerson(Person psn) { return _humanList.Contains(psn); }
}
