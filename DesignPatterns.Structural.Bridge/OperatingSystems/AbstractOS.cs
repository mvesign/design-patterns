namespace DesignPatterns.Structural.Bridge.OperatingSystems;

/// <inheritdoc />
public abstract class AbstractOS : IOS
{
    /// <summary>
    /// Create an instance of an operating system.
    /// </summary>
    /// <param name="name">Name of the OS.</param>
    protected AbstractOS(string name)
    {
        Name= name;
    }

    /// <summary>
    /// Type.
    /// </summary>
    public string Name { get; set; }

    /// <inheritdoc />
    public void StartUp() =>
        Console.WriteLine($"{Name} is started up");

    /// <inheritdoc />
    public void DisplayScreen() =>
        Console.WriteLine($"Display {Name} screen");

    /// <inheritdoc />
    public void ShutDown() =>
        Console.WriteLine($"{Name} is shut down");
}