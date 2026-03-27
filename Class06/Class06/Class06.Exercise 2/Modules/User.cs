namespace Class06.Exercise_2.Modules
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Messages { get; set; }

        public User(int id, string username, string password, List<string> messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }
    }
}
