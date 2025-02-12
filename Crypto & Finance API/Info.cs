using System.Text.Json.Serialization;

public record Info(
    [property: JsonPropertyName("coins_num")] int coins_num,
    [property: JsonPropertyName("time")] int time
);
