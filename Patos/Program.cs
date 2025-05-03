using System;

class Program
{
    static void Main(string[] args)
    {
        MallardDuck mallard = new MallardDuck();
        RedHeadDuck redHeadDuck = new RedHeadDuck();
        RubberDuck rubberDuck = new RubberDuck();

        Console.WriteLine("Pato selvagem:");
        mallard.Display();
        mallard.Swim();
        mallard.Fly();
        mallard.Quack();

        Console.WriteLine("Pato da cabeça vermelha:");
        redHeadDuck.Display();
        redHeadDuck.Swim();
        redHeadDuck.Fly();
        redHeadDuck.Quack();

        Console.WriteLine("Pato de borracha:");
        rubberDuck.Display();
        rubberDuck.Swim();
        rubberDuck.Quack();
    }
}