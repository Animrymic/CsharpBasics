Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int firstNumber = 1;

while (firstNumber <= number)
{
    if(firstNumber == 100)
    {
        Console.WriteLine("The limit is reached!");
        break;
    }

    if (firstNumber % 3 != 0 && firstNumber % 7 != 0)
    {
        Console.WriteLine(firstNumber);
    }
    firstNumber++;
}