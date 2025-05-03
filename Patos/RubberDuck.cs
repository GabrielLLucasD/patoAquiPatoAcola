class RubberDuck : Duck, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Sou um pato de borracha");
    }


    public void Quack()
    {
        Console.WriteLine("Squeak!!");
    }
}