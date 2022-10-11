using DesignPatterns.Structural.Proxy;

var httpApiService = new HttpApiService();

Console.WriteLine(httpApiService.GetJsonData());
Console.WriteLine();
Console.WriteLine(httpApiService.GetJsonData());