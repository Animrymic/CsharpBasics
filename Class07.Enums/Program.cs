using Class07.Enums.Enums;

Console.WriteLine(DaysOfWeek.Monday);
Console.WriteLine(Convert.ToInt32(DaysOfWeek.Monday));

Console.WriteLine(DaysOfWeek.Tuesday);
Console.WriteLine(Convert.ToInt32(DaysOfWeek.Tuesday));

Console.WriteLine("Please enter day of week: ");
string input = Console.ReadLine();

if (input == DaysOfWeek.Saturday.ToString() || input == DaysOfWeek.Sunday.ToString())
{
    Console.WriteLine("YEEEY IT IS THE WEEKEND");
}
