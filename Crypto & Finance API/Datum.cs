using System.Text.Json.Serialization;

public record Datum(
        [property: JsonPropertyName("id")] string id,
        [property: JsonPropertyName("symbol")] string symbol,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("nameid")] string nameid,
        [property: JsonPropertyName("rank")] int rank,
        [property: JsonPropertyName("price_usd")] string price_usd,
        [property: JsonPropertyName("percent_change_24h")] string percent_change_24h,
        [property: JsonPropertyName("percent_change_1h")] string percent_change_1h,
        [property: JsonPropertyName("percent_change_7d")] string percent_change_7d,
        [property: JsonPropertyName("price_btc")] string price_btc,
        [property: JsonPropertyName("market_cap_usd")] string market_cap_usd,
        [property: JsonPropertyName("volume24")] double volume24,
        [property: JsonPropertyName("volume24a")] double volume24a,
        [property: JsonPropertyName("csupply")] string csupply,
        [property: JsonPropertyName("tsupply")] string tsupply,
        [property: JsonPropertyName("msupply")] string msupply
    );
