Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int startNumber = 1;

while (startNumber <= number)
{
    Console.WriteLine(startNumber);
    startNumber++;
}

Console.Write("Enter a number: ");
int secondExerciseNumber = int.Parse(Console.ReadLine());

int i = secondExerciseNumber;

while (i >= 1)
{
    Console.WriteLine(i);
    i--;
}

Console.Write("Enter a number: ");
int thirdNumber = int.Parse(Console.ReadLine());

int n = 2;

while (n <= thirdNumber)
{
    Console.WriteLine(n);
    n += 2;
}

Console.Write("Enter a number: ");
int fourthNumber = int.Parse(Console.ReadLine());

int m = 1;

while (m <= fourthNumber)
{
    Console.WriteLine(m);
    m += 2;
}
