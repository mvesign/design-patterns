namespace DesignPatterns.Structural.Decorator.Shapes;

/// <inheritdoc />
public class Rectangle : IShape
{
    /// <inheritdoc />
    public void Draw() =>
        Console.WriteLine($"Shape: {nameof(Rectangle)}");
}