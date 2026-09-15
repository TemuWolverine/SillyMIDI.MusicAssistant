using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class MediaCollection : MediaItemBase
{
    [JsonPropertyName("items")]
    public List<object>? Items { get; set; }
}

