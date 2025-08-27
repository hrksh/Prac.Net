using System;
using MyConsole.Prac.DesignPattern;
using MyConsole.Prac.DesignPattern.Behavior;

// See https://aka.ms/new-console-template for more information
// System.Console.WriteLine("Hello World!");

Duck testDuck = new ModelDuck();

// おテスト

testDuck.Display();
testDuck.Fly(); // まだ飛ばない
testDuck.Quack();

testDuck.SetFlyBehavior(new FlyRocketPowered());
testDuck.Fly(); // 飛んだw

System.Console.ReadLine();