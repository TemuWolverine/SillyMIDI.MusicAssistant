using System.Text.Json;
using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

/// <summary>
/// Server information returned by the <c>info</c> command.
/// </summary>
public sealed class ServerInfo
{
    [JsonPropertyName("schema_version")]
    public int SchemaVersion { get; set; }

    [JsonPropertyName("server_version")]
    public string? ServerVersion { get; set; }

    [JsonPropertyName("onboard_done")]
    public bool OnboardDone { get; set; }

    [JsonPropertyName("homeassistant_addon")]
    public bool HomeAssistantAddon { get; set; }

    [JsonExtensionData]
    public Dictionary<string, JsonElement>? AdditionalProperties { get; set; }
}
