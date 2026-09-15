using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class BrowseFolder : MediaItemBase
{
    [JsonPropertyName("translation_params")]
    public List<string>? TranslationParams { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;
}

