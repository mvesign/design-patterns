namespace DesignPatterns.Structural.Proxy;

/// <summary>
/// Service which instantiate the <see cref="HttpApiClient"/>.
/// </summary>
public class HttpApiService
{
    private HttpApiClient _httpApiClient;
    private string _cachedJsonData;
    
    /// <summary>
    /// Get the JSON data of an API endpoint for the first call, for recurring calls it's stored in a local cache.
    /// </summary>
    /// <returns>Raw JSON data.</returns>
    public string GetJsonData()
    {
        Console.WriteLine("HTTP API Service");
        if (string.IsNullOrEmpty(_cachedJsonData))
        {
            _httpApiClient ??= new HttpApiClient();
            _cachedJsonData = _httpApiClient.GetJsonData();
        }

        return _cachedJsonData;
    }
}