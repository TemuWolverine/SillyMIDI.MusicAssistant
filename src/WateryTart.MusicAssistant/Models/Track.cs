using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class Track : MediaItemBase
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("artists")]
    public List<Artist>? Artists { get; set; }

    [JsonPropertyName("last_played")]
    public int LastPlayed { get; set; }

    [JsonPropertyName("album")]
    public Album? Album { get; set; }

    [JsonPropertyName("disc_number")]
    public int DiscNumber { get; set; }

    [JsonPropertyName("track_number")]
    public int TrackNumber { get; set; }
}

