class MallardDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Sou um pato selvagem!");
    }

    public void Fly()
    {
        Console.WriteLine("Estou voando!");
    }

    public void Quack()
    {
        Console.WriteLine("Quack, quack!!");
    }
}