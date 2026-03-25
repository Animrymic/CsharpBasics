using Class05.Exercises.Models;

#region Exercise 1

Console.Write("Enter first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter last name: ");
string lastName = Console.ReadLine();

Console.Write("Enter age: ");
int age = int.Parse(Console.ReadLine());

Human person = new Human();
person.FirstName = firstName;
person.LastName = lastName;
person.Age = age;

Console.WriteLine(person.GetPersonStats());

#endregion

#region Exercise 2

Console.WriteLine("Enter the dog name: ");
string dogName = Console.ReadLine();

Console.WriteLine("Enter the dog's race: ");
string dogRace = Console.ReadLine();

Console.WriteLine("Enter the dog's color");
string dogColor = Console.ReadLine();

Dog dog = new Dog();
dog.Name = dogName;
dog.Race = dogRace;
dog.Color = dogColor;

Console.WriteLine("\nChoose an action:");
Console.WriteLine("1. Eat");
Console.WriteLine("2. Play");
Console.WriteLine("3. Chase Tail");
Console.Write("Enter option (1-3): ");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
	case 1:
		dog.Eat();
		break;
	case 2:
		dog.Play();
		break;
	case 3:
		dog.ChaseTail();
		break;
	default:
        Console.WriteLine("Invalid Choice!");
		break;
}



#endregion