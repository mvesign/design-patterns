namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// The one and only point I can make here.
/// </summary>
public class Point
{
    /// <summary>
    /// Private constructor to force the single instance
    /// </summary>
    private Point()
    {
        Identifier = new Random().Next();
    }

    /// <summary>
    /// Get the one and only instance of the point.
    /// </summary>
    public static Point Instance { get; } = new();

    /// <summary>
    /// Identifier of the point.
    /// </summary>
    public int Identifier { get; }

    /// <inheritdoc />
    public override string ToString() =>
        $"Point #{Identifier}";
}