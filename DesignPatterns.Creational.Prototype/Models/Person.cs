namespace DesignPatterns.Creational.Prototype.Models;

/// <summary>
/// Details of a person.
/// </summary>
public class Person
{
    /// <summary>
    /// Create a person.
    /// </summary>
    /// <param name="name"><see cref="Name"/></param>
    /// <param name="birthDate"><see cref="BirthDate"/></param>
    public Person(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Date of birth.
    /// </summary>
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// Age.
    /// </summary>
    public int Age => (DateTime.UtcNow - BirthDate).Days / 365;

    /// <inheritdoc />
    public override string ToString() =>
        $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(BirthDate)}: {BirthDate:yy-MM-dd}";
}