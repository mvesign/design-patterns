namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// The one and only sun.
/// </summary>
public class Sun
{
    /// <summary>
    /// Private constructor to force the single instance
    /// </summary>
    private Sun()
    {
        Identifier = new Random().Next();
    }

    /// <summary>
    /// Get the one and only instance of the sun.
    /// </summary>
    public static Sun Instance { get; } = new();

    /// <summary>
    /// Identifier of the sun.
    /// </summary>
    public int Identifier { get; }

    /// <inheritdoc />
    public override string ToString() =>
        $"Sun #{Identifier}";
}