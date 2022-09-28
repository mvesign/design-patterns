using DesignPatterns.Structural.Bridge.OperatingSystems;

namespace DesignPatterns.Structural.Bridge.Images;

/// <summary>
/// Image of an OS.
/// </summary>
public abstract class AbstractImage
{
    /// <summary>
    /// OS.
    /// </summary>
    protected readonly IOS OS;

    /// <summary>
    /// Create an image based on an OS.
    /// </summary>
    /// <param name="os"><see cref="IOS"/></param>
    protected AbstractImage(IOS os)
    {
        OS = os;
    }

    /// <summary>
    /// Check if the image is correct.
    /// </summary>
    public abstract void CheckImage();
}