using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class Artist : MediaItemBase
{
    [JsonPropertyName("available")]
    public bool Available { get; set; }
}
