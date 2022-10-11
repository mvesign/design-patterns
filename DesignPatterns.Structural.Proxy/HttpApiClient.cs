namespace DesignPatterns.Structural.Proxy;

/// <summary>
/// Client class that connects to an API.
/// </summary>
public class HttpApiClient
{
    /// <summary>
    /// Get the JSON data of an API endpoint.
    /// </summary>
    /// <returns>Raw JSON data.</returns>
    public string GetJsonData()
    {
        Console.WriteLine("HTTP API Client");
        return "{\"Key\":\"Value\"}";
    }
}