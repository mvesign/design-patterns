using System.Linq;
using DesignPatterns.Structural.Flyweight.Shapes;

namespace DesignPatterns.Structural.Flyweight;

/// <summary>
/// Factory of shapes.
/// </summary>
public static class ShapeFactory
{
    private static readonly List<IShape> Shapes = new();

    /// <summary>
    /// Get the shape linked to a given type.
    /// </summary>
    /// <param name="type">Type of the shape of type <see cref="ShapeType"/>.</param>
    /// <returns>Shape of type <see cref="IShape"/>.</returns>
    public static IShape GetShape(ShapeType type)
    {
        var shape = Shapes.FirstOrDefault(_ => _.Type.Equals(type));
        if (shape == null)
        {
            shape = type switch
            {
                ShapeType.Circle => new Circle(),
                _ => throw new Exception("No need to be present, just here to please the compiler.")
            };

            Shapes.Add(shape);
        }

        return shape;
    }
}