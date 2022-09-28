using DesignPatterns.Structural.Bridge.OperatingSystems;

namespace DesignPatterns.Structural.Bridge.Images;

/// <inheritdoc />
public class ConcreteImage : AbstractImage
{
    /// <inheritdoc />
    public ConcreteImage(IOS os) : base(os) { }

    /// <inheritdoc />
    public override void CheckImage()
    {
        OS.StartUp();
        OS.DisplayScreen();
        OS.ShutDown();
    }
}