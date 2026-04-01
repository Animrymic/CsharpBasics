#region Exercise-PhoneBook

Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    {"Martin", "078-755-456" },
    {"Dragan", "072-245-675" },
    {"Ognen", "074-890-236" },
    {"Klementina", "070-213-365" }
};

Console.Write("Please enter a name: ");
string nameInput = Console.ReadLine();

if (phoneBook.TryGetValue(nameInput, out string number))
{
    Console.WriteLine("Phone number: " + number);
}
else
{
    Console.WriteLine("Error: Name not found in phonebook");
}

#endregion