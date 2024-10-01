using System.Runtime.Versioning;
using System.Text;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
    適当に練習用
 */

var Satoshi = new Person("satoshi", 28);
var takeshi = new Person("takeshi", 32);


abstract class PersonBase
{
    private string _name = string.Empty;
    internal string Name { get { return _name; } }
    private int _age = 0;
    internal int Age { get { return this._age; } }
    internal PersonBase(string name , int age) { this._name = name; this._age = age; }
    internal virtual bool Introduction() { return false; }
}

class Person : PersonBase
{
    const string SeparatorStringBarStyle = " ---- New Person Generated. ---- ";
    const string FIntroductionName = "Name : {0}";
    const string FIntroductionAge = "Age : {0}";
    public Person(string name, int age) : base(name, age)
    {
        this.Introduction();
    }
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

class Humans
{
    List<Person> _humans = null;
    public Humans() { this._humans = new List<Person>(); }
    public void AddPerson(Person psn) { this._humans.Add(psn); }
    public void ShowCntHumans() { Console.WriteLine(this._humans.Count()); }
    public bool IsExistPerson(Person psn) { return this._humans.Contains(psn); }
}
