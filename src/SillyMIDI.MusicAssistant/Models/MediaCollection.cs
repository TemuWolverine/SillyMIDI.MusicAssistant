using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class MediaCollection : MediaItemBase
{
    [JsonPropertyName("items")]
    public List<object>? Items { get; set; }
}

