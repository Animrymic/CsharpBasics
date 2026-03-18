#region Arrays

//Decalration of an array in C#

using System.Collections;

int[] emptyNumbersArray = new int[3];

emptyNumbersArray[0] = 1;
emptyNumbersArray[1] = 10;
emptyNumbersArray[2] = 20;

//emptyNumbersArray[3] = 50;

for (int i = 0; i < emptyNumbersArray.Length; i++)
{
    Console.WriteLine(emptyNumbersArray[i]);
}


string[] names = new string[]
{
    "Martin",
    "Mario",
    "Dimitar",
    "Ognen",
    "Damjan"
};

double[] decimalNumbers = [10.5, 20.4, 100.12];

foreach (string name in names)
{
    Console.WriteLine(name);
}

foreach (double number in decimalNumbers)
{
    Console.WriteLine(number);
}

//Ways of declaration and use of arrays with mixed types in it. 
//Avoid and do not use this!!! unless you need to do so for some reason! 
var mixedArrayValues = new object[] { 1, 1.1, true, "Martin" };
ArrayList mixed = new ArrayList { 1, 2.4, true, false };
#endregion


#region Array Methods

int[] evenNumbers = new int[] { 2, 4, 6, 8, 10 };

// Reverse the array elements
//Array.Reverse(evenNumbers);

Console.WriteLine("Array of even numbers after reverse");

foreach (var num in evenNumbers)
{
    Console.WriteLine(num);

}

int indexFound = Array.IndexOf(evenNumbers, 2);
Console.WriteLine("The index of number 2 is: " + indexFound);

#endregion

#region Array Resize method using example use case

string[] usernames = new string[0]; 

do
{
    Console.Clear();
    Console.WriteLine("Please enter a username: ");
    string userInput = Console.ReadLine();

    Array.Resize(ref usernames, usernames.Length + 1);
    usernames[usernames.Length - 1] = userInput;

    Console.WriteLine("Do you want to insert new username? Y/N");
    userInput = Console.ReadLine(); 

    if (userInput == "n" || userInput == "N")
        break;


} while (true);

foreach ( var username in usernames)
{
    Console.WriteLine(username);
}


int[] test = new int[] { 1, 2, 3, 4, 5 };

Array.Resize(ref test, 10);

test[5] = 10; 
test[6] = 25;
test[7] = 10;
test[8] = 25;
#endregion
