using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class Radio : MediaItemBase
{
    [JsonPropertyName("translation_params")]
    public List<string>? TranslationParams { get; set; }

    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("is_dynamic")]
    public bool IsDynamic { get; set; }
}

