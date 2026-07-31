using System.Text.Json.Serialization;

namespace Anzen.Objects;

public class HealthResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("healthy")]
    public bool Healthy { get; set; }

}
