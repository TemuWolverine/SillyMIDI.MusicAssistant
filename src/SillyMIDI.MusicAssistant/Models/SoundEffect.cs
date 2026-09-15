using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class SoundEffect : MediaItemBase
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}

