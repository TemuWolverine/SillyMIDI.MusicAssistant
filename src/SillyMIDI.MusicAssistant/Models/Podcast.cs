using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class Podcast : MediaItemBase
{
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    [JsonPropertyName("total_episodes")]
    public int? TotalEpisodes { get; set; }
}

