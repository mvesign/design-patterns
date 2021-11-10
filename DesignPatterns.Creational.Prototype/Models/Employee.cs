namespace DesignPatterns.Creational.Prototype.Models
{
    /// <summary>
    /// Details of an employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public int Identifier { get; set; }

        /// <summary>
        /// <see cref="Person"/>
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Create a shallow copy of the current employee.
        /// </summary>
        /// <returns><see cref="Employee"/></returns>
        public Employee ShallowCopy() => (Employee) MemberwiseClone();

        /// <summary>
        /// Create a deep copy of the current employee
        /// </summary>
        /// <returns><see cref="Employee"/></returns>
        public Employee DeepCopy()
        {
            var clone = (Employee)MemberwiseClone();
            clone.Person = new Person(Person.Name, Person.BirthDate);
            clone.Identifier = Identifier;
            return clone;
        }

        /// <inheritdoc />
        public override string ToString() => $"#{Identifier} - {Person}";
    }
}
