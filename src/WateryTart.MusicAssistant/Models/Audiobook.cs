using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class Audiobook : MediaItemBase
{
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("authors")]
    public List<object>? Authors { get; set; }

    [JsonPropertyName("narrators")]
    public List<object>? Narrators { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("fully_played")]
    public bool? FullyPlayed { get; set; }

    [JsonPropertyName("resume_position_ms")]
    public int? ResumePositionMs { get; set; }
}

