namespace Class07.CTOR_Inheritance.Models;

public class Parrot : Animal
{
    public string Color { get; set; }

    public Parrot()
    {
        
    }

    public Parrot(int id, string name, string type, string color)
        : base(id, name, type)
    {
        Color = color;    
    }

    public void Fly()
    {
        Console.WriteLine("Woow! I am flying!");
    }

    public override void Eat()
    {
        Console.WriteLine($"I am {Name} and I am {Type} who do not have time to eat, because I speak all the time!");
    }
}
