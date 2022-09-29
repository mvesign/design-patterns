namespace DesignPatterns.Structural.Facade.Shapes;

/// <inheritdoc />
public class Triangle : IShape
{
    /// <inheritdoc />
    public void Draw() =>
        Console.WriteLine($"Draw {nameof(Triangle)}");
}