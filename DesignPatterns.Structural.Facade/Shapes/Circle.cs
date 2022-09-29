namespace DesignPatterns.Structural.Facade.Shapes;

/// <inheritdoc />
public class Circle : IShape
{
    /// <inheritdoc />
    public void Draw() =>
        Console.WriteLine($"Draw {nameof(Circle)}");
}