#region DataTypes


// Declaration and initialization of variables
// Using data types

int number = 154;
int otherNumber = 10500;
short shortNumber = 150;
long bigNumber = 1237234837656;
double decimalNumber = 10.44;
float decimalNumber2 = 155.45f;
decimal decimalNumber3 = 15545.23245m;

string fullName = "Dragan Trojanovikj";
bool isRaining = false; 
string lastName;
lastName = "Panovski";
Console.WriteLine(lastName);
char character = 'D';

Console.WriteLine(number);
Console.WriteLine(otherNumber);
Console.WriteLine(decimalNumber);
Console.WriteLine(decimalNumber2);
Console.WriteLine(decimalNumber3);
Console.WriteLine(bigNumber);
Console.WriteLine(fullName);
Console.WriteLine(character);
Console.WriteLine(shortNumber);
Console.WriteLine(isRaining);









#endregion

#region ImplicitDataTypes

var academyName = "Avenga Academy";

// this will not work! the application will not run until fixed.
//academyName = 10;

var numberOfStudents = 20;
//numberOfStudents = 20.10; //this will not work!

var isSunny = true;
isSunny = false;


#endregion

#region CheckDataType

Console.WriteLine(isRaining.GetType());

#endregion
