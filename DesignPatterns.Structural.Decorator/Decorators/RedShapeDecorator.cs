namespace DesignPatterns.Structural.Decorator.Decorators;

/// <inheritdoc />
/// <summary>
/// Shape decorator that will decorate the shape in the color red.
/// </summary>
public class RedShapeDecorator : ShapeDecorator
{
    /// <summary>
    /// Create an instance of the red shape decorator.
    /// </summary>
    /// <param name="shape"><see cref="IShape"/></param>
    public RedShapeDecorator(IShape shape) : base(shape) { }
    
    /// <inheritdoc />
    protected override void Decorate() =>
        SetColor();
    
    private static void SetColor() =>
        Console.WriteLine("Color: Red");
}