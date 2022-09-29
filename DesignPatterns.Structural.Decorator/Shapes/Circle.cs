namespace DesignPatterns.Structural.Decorator.Shapes;

/// <inheritdoc />
public class Circle : IShape
{
    /// <inheritdoc />
    public void Draw() =>
        Console.WriteLine($"Shape: {nameof(Circle)}");
}