var baseAddress = "https://api.coingecko.com/api/v3/coins/";
var requistUri = "markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false";

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requistUri);

Console.ReadLine();

public interface IApiDataReader
{
    public Task<string> Read(string baseAddress, string requistUri);
}
public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requistUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        HttpResponseMessage responce = await client.GetAsync(requistUri);
        responce.EnsureSuccessStatusCode();
        var json = await responce.Content.ReadAsStringAsync();
        return json;
    }
}