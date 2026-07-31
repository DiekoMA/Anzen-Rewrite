using System.Text.Json.Serialization;

namespace Anzen.Objects.Password;

public class VaultEntry
{
    [JsonPropertyName("item_name")]
    public required string Name { get; set; }

    [JsonPropertyName("folder_id")]
    public required string? Folder { get; set; }

    /// Username is used here but honestly this could be an email too.
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// The users password
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("auth_key")]
    public string? AuthenticatorKey { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }
}
