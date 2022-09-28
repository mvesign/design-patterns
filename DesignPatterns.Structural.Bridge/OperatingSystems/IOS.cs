namespace DesignPatterns.Structural.Bridge.OperatingSystems;

/// <summary>
/// Operating system.
/// </summary>
public interface IOS
{
    /// <summary>
    /// Start up the OS.
    /// </summary>
    void StartUp();

    /// <summary>
    /// Display values on the screen.
    /// </summary>
    void DisplayScreen();

    /// <summary>
    /// Shut down the OS.
    /// </summary>
    void ShutDown();
}