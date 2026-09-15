using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class PodcastEpisode : MediaItemBase
{
    [JsonPropertyName("podcast")]
    public object? Podcast { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("fully_played")]
    public bool? FullyPlayed { get; set; }

    [JsonPropertyName("resume_position_ms")]
    public int? ResumePositionMs { get; set; }
}

