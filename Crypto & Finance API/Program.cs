using System.Text.Json;

var baseAddress = "https://api.coinlore.net/api/";
var requistUri = "tickers/";
Console.WriteLine("\tCryptocurrency market data..!");
Console.WriteLine("Waiting for looding...\n");
IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read(baseAddress, requistUri);

var root = JsonSerializer.Deserialize<Root>(json);
var count = 0;


foreach (var item in root.data)
{

    Console.WriteLine($"{count+1}.curruncy name :{item.name},\nupdate date : {new TimeOnly(root.info.time)},\nprice btc : {item.price_btc},\nprice usd :{item.price_usd},\n% change in 24h  :{item.percent_change_24h}");
    Console.WriteLine();
    count++;
}

Console.ReadLine();
