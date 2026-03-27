using Class06.Exercise_2.Modules;
class Program
{
    static List<User> users = new List<User>()
    {
        new User(1, "Dragan", "dragan", new List<string> { "Hello Dragan!", "Welcome back!" }),
        new User(2, "Mitko", "mitko", new List<string> { "Hi Mitko!", "You have 2 notifications." }),
        new User(3, "Boban", "boban", new List<string> { "Hey Boban!", "Check your inbox." })
    };

    static void Main()
    {
        while(true)
        {
            ShowMenu();
            string userChoice = Console.ReadLine(); 

            if (userChoice == "1")
            {
                Login(); 
            } else if (userChoice == "2") {
                Register(); 
            } else if (userChoice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nSelect an option: ");
        Console.WriteLine("1. Log in");
        Console.WriteLine("2. Register");
        Console.WriteLine("3. Exit");
    }

    static void Login()
    {
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        User user = FindUser(username, password);

        if (user != null)
        {
            Console.WriteLine($"\nWelcome {user.Username}. Here are your messages!");
            foreach (var message in user.Messages)
            {
                Console.WriteLine(message);
            }
        }

        else
        {
            Console.WriteLine("ERROR: Invalid username or password");
        }
    }

    static void Register()
    {
        Console.WriteLine("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter username: ");
        string username = Console.ReadLine(); 

        if(users.Any(u => u.Username == username))
        {
            Console.WriteLine("Error: username already exists!");
            return;
        }


        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        User newUser = new User(id, username, password, new List<string>());
        users.Add(newUser);

        Console.WriteLine("\nRegistration complete! Users:");
        PrintUsers();

    }
    static void PrintUsers()
    {
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Id} {user.Username}");
        }
    }
    static User FindUser(string username, string password)
    {
        return users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }
}

