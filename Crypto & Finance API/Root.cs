using System.Text.Json.Serialization;

public record Root(
    [property: JsonPropertyName("data")] IReadOnlyList<Datum> data,
    [property: JsonPropertyName("info")] Info info
);
