using Class08.LINQ.Models;
using System.ComponentModel;

var students = new List<Student>
        {
            new Student(1, "Alice", "Smith", 20, "G1", Academy.WebDev, new List<string>{ "Basic C#", "AdvancedCSharp" }),
            new Student(2, "Bob", "Johnson", 22, "G2", Academy.FrontEnd, new List<string>{ "HTML/CSS", "JS" }),
            new Student(3, "Carol", "Williams", 19, "G3", Academy.Design, new List<string>{ "Figma", "Photoshop" }),
            new Student(4, "David", "Brown", 21, "G4", Academy.WebDev, new List<string>{ "BasicJS", "AJS" }),
            new Student(5, "Eve", "Jones", 23, "G1", Academy.FrontEnd, new List<string>{ "HTML/CSS", "Figma" }),
            new Student(6, "Frank", "Garcia", 24, "G2", Academy.Design, new List<string>{ "Basic HTML/CSS", "Figma" }),
            new Student(7, "Grace", "Miller", 20, "G3", Academy.WebDev, new List<string>{ "Basic C#", "BasicJS" }),
            new Student(8, "Hank", "Davis", 22, "G4", Academy.FrontEnd, new List<string>{ "JS", "HTML/CSS" }),
            new Student(9, "Ivy", "Martinez", 18, "G1", Academy.Design, new List<string>{ "Photoshop", "Basic HTML/CSS" }),
            new Student(10, "Jack", "Lopez", 25, "G2", Academy.WebDev, new List<string>{ "AdvancedCSharp", "AJS" })
        };


Student alice = students
                   .Where(x => x.FirstName == "Alice")
                   .First();
Console.WriteLine($"{alice.FirstName} {alice.LastName} - {alice.Academy.ToString()}");


var allWebDevStudentsFromG1 = students
                                .Where(x => x.Academy == Academy.WebDev && x.Group == "G1")
                                .ToList();
foreach (var std in allWebDevStudentsFromG1)
{
    Console.WriteLine($"{std.FirstName} {std.LastName} - Academy: {std.Academy.ToString()} Group: {std.Group}");
}


var lastStudent = students.Last();
Console.WriteLine($"{lastStudent.FirstName} {lastStudent.LastName}");

var eveSubjects = students.Where(x => x.FirstName == "Eve")
                          .Select(x => x.Subjects)
                          .First();
foreach (var sub in eveSubjects)
{
    Console.WriteLine(sub);
}

var customSelection = students
                        .Where(x => x.FirstName == "Frank")
                        .Select(x => new
                        {
                            FullName = $"{x.FirstName} {x.LastName}",
                            x.Subjects
                        })
                        .FirstOrDefault();

Console.WriteLine(customSelection.FullName);
foreach (var sub in customSelection.Subjects)
{
    Console.WriteLine(sub);
}
