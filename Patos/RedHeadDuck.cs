class RedHeadDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Sou um pato de cabeça vermelha");
    }

    public void Fly()
    {
        Console.WriteLine("Estou voando alto!");
    }

    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}