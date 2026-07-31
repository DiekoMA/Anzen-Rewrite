using System.Text.Json.Serialization;

namespace Anzen.Objects.Password;

public class Snippet()
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("item_name")]
    public required string Content { get; set; }

    [JsonPropertyName("item_name")]
    public string? Attachment { get; set; }
}
