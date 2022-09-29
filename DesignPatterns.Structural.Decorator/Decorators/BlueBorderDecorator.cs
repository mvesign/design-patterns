namespace DesignPatterns.Structural.Decorator.Decorators;

/// <inheritdoc />
/// <summary>
/// Shape decorator that will decorate the shape with a border in the color blue.
/// </summary>
public class BlueBorderDecorator : ShapeDecorator
{
    /// <summary>
    /// Create an instance of the blue border decorator.
    /// </summary>
    /// <param name="shape"><see cref="IShape"/></param>
    public BlueBorderDecorator(IShape shape) : base(shape) { }

    /// <inheritdoc />
    protected override void Decorate() =>
        SetBorder();

    private static void SetBorder() =>
        Console.WriteLine("Border: Blue");
}