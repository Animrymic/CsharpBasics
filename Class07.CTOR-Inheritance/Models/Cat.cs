namespace Class07.CTOR_Inheritance.Models;

public class Cat : Animal
{
    public String Lazyness { get; set; }

    public Cat() : base("Cat")
    {
        Console.WriteLine("A new instance of a Cat is created");
    }

    public void Meow()
    {
        Console.WriteLine("Meow, meow!");
        Thread.Sleep(2000);
    }

    public override void Eat()
    {
        Console.WriteLine("You can' tell a cat to eat!");
    }
}
