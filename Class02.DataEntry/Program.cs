

#region Data Entries

string userInput = Console.ReadLine();
Console.WriteLine("[USER INPUT] " + userInput);

Console.WriteLine("Please insert number 1:");
//int number1 = int.Parse(Console.ReadLine());
//int number1 = Convert.ToInt32(Console.ReadLine());
bool isParsedNum1 = int.TryParse(Console.ReadLine(), out int number1); 

Console.WriteLine("Please insert number 2:");
//int number2 = int.Parse(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
bool isParsedNum2 = int.TryParse(Console.ReadLine(), out int number2);

#endregion

#region Branching if/else, switch

if (!isParsedNum1 || !isParsedNum2)
{
    Console.WriteLine("You try to sum values that are not numers! Please try again!");
    return;
}
else
{
    Console.WriteLine(number1 + number2);
}


Console.WriteLine("Enter day of the week and I will let you know if you have classes!");
string dayOfTheWeek = Console.ReadLine();

switch (dayOfTheWeek)
{
    case "Monday":
        Console.WriteLine("You have classes on this day!");
        break;
    case "Tuesday":
        Console.WriteLine("No classes on this day!");
        break;
    case "Wednesday":
        Console.WriteLine("You have classes on this day!");
        break;
    case "Thursday":
    case "Friday":
    case "Saturday":
    case "Sunday":
        Console.WriteLine("No classes on this day!");
        break;
    default:
        Console.WriteLine("No such day of the week! Please try again!");
        break;
}



#endregion