namespace DesignPatterns.Structural.Flyweight.Shapes;

/// <summary>
/// Circle shape.
/// </summary>
public class Circle : IShape
{
    private string _color;

    /// <inheritdoc />
    public ShapeType Type => ShapeType.Circle;

    /// <inheritdoc />
    public void SetColor(string color) =>
        _color = color;

    /// <inheritdoc />
    public void Draw() =>
        Console.WriteLine($"{Type} with properties [Color: {_color}, HashCode: {GetHashCode()}]");
}