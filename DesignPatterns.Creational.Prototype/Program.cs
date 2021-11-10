using System;
using DesignPatterns.Creational.Prototype.Models;

namespace DesignPatterns.Creational.Prototype
{
    internal class Program
    {
        private static readonly Random Random = new();

        private static void Main()
        {
            var employee1 = new Employee
            {
                Identifier = Random.Next(0, int.MaxValue),
                Person = new Person("Hugo First", GetRandomBirthDate())
            };

            var employee2 = employee1.ShallowCopy();
            var employee3 = employee1.DeepCopy();

            Console.WriteLine($"Employee 1 - {employee1}");
            Console.WriteLine($"Employee 2 - {employee2}");
            Console.WriteLine($"Employee 3 - {employee3}");

            Console.WriteLine();

            employee1.Identifier = Random.Next(0, int.MaxValue);
            employee1.Person.Name = "Aida Bug";
            employee1.Person.BirthDate = GetRandomBirthDate();

            Console.WriteLine($"Employee 1 - {employee1}");
            Console.WriteLine($"Employee 2 - {employee2}");
            Console.WriteLine($"Employee 3 - {employee3}");
        }

        private static DateTime GetRandomBirthDate() =>
            new(
                Random.Next(1970, DateTime.UtcNow.Year),
                Random.Next(1, 12),
                Random.Next(1, 28)
            );
    }
}
