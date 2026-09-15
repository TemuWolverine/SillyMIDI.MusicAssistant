using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class Link
{

    [JsonPropertyName("type")] public string? Type { get; set; }
    [JsonPropertyName("url")] public string? Url { get; set; }
}