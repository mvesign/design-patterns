using DesignPatterns.Structural.Facade.Shapes;

namespace DesignPatterns.Structural.Facade;

/// <summary>
/// Artist.
/// </summary>
public class Artist
{
    private readonly Circle _circle = new();
    private readonly Square _square = new();
    private readonly Triangle _triangle = new();

    /// <summary>
    /// Draw a composite of all shapes.
    /// </summary>
    public void Draw()
    {
        _circle.Draw();
        _square.Draw();
        _triangle.Draw();
    }
}