using DesignPatterns.Creational.Prototype.Models;

Random random = new();

var employee1 = new Employee
{
    Identifier = random.Next(0, int.MaxValue),
    Person = new Person("Hugo First", GetRandomBirthDate())
};

var employee2 = employee1.ShallowCopy();
var employee3 = employee1.DeepCopy();

Console.WriteLine($"Employee 1 - {employee1}");
Console.WriteLine($"Employee 2 - {employee2}");
Console.WriteLine($"Employee 3 - {employee3}");

Console.WriteLine();

employee1.Identifier = random.Next(0, int.MaxValue);
employee1.Person.Name = "Aida Bug";
employee1.Person.BirthDate = GetRandomBirthDate();

Console.WriteLine($"Employee 1 - {employee1}");
Console.WriteLine($"Employee 2 - {employee2}");
Console.WriteLine($"Employee 3 - {employee3}");

DateTime GetRandomBirthDate() =>
    new(
        random.Next(1970, DateTime.UtcNow.Year),
        random.Next(1, 12),
        random.Next(1, 28)
    );