using DesignPatterns.Structural.Decorator.Shapes;

namespace DesignPatterns.Structural.Decorator.Decorators;

/// <summary>
/// Base decorator of an <see cref="IShape"/>.
/// </summary>
public abstract class ShapeDecorator : IShape
{
    /// <summary>
    /// Shape that needs to be decorated.
    /// </summary>
    protected readonly IShape Shape;

    /// <summary>
    /// Create an instance of the base decorator.
    /// </summary>
    /// <param name="shape"><see cref="IShape"/></param>
    protected ShapeDecorator(IShape shape)
    {
        Shape = shape;
    }

    /// <inheritdoc />
    public void Draw()
    {
        Shape.Draw();
        Decorate();
    }

    /// <summary>
    /// Decorate the <see cref="Shape"/>.
    /// </summary>
    protected abstract void Decorate();
}