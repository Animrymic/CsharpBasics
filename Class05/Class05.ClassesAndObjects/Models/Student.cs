namespace Class05.ClassesAndObjects.Models
{
    internal class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }

        public Student(string fullName, int age, Group group)
        {
            FullName = fullName;
            Age = age;
            //Group = group ?? new Group("Unknown", 0, "Unknown");
            if(group != null)
            {
                Group = group;
            }
            else
            {
                Group = new Group("Unknown", 0, "Unknown");
            }
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"{FullName} from group {Group.GroupName}");
        }
    }
}
