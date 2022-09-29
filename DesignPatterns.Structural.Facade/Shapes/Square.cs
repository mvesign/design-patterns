namespace DesignPatterns.Structural.Facade.Shapes;

/// <inheritdoc />
public class Square : IShape
{
    /// <inheritdoc />
    public void Draw() =>
        Console.WriteLine($"Draw {nameof(Square)}");
}