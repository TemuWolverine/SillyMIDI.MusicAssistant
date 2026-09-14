using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class SoundEffect : MediaItemBase
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}

