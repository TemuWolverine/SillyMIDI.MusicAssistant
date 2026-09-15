using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models;

public class Album : MediaItemBase
{
    [JsonPropertyName("artists")]  public List<Artist>? Artists { get; set; }
    [JsonPropertyName("album_type")] public AlbumType AlbumType { get; set; }
}

[JsonConverter(typeof(FallbackEnumConverter<AlbumType>))]
public enum AlbumType
{
    Unknown,
    Album,
    Single,
    Live,
    Soundtrack,
    Compilation,
    Ep,
}