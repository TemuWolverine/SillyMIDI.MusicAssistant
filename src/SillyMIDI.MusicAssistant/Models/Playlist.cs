using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models
{
    public class Playlist : MediaItemBase
    {
        [JsonPropertyName("owner")]
        public string? Owner { get; set; }
        
        [JsonPropertyName("is_editable")]
        public bool? IsEditable { get; set; }
    }
}