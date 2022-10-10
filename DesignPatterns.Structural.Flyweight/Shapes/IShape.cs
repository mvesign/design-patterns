namespace DesignPatterns.Structural.Flyweight.Shapes;

/// <summary>
/// Shape.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Shape type.
    /// </summary>
    ShapeType Type { get; }

    /// <summary>
    /// Set the color of the shape.
    /// </summary>
    /// <param name="color">Color of the shape.</param>
    void SetColor(string color);

    /// <summary>
    /// Draw the shape on the canvas.
    /// </summary>
    void Draw();
}