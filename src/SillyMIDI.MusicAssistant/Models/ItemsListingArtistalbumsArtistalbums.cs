using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class ItemsListingArtistalbumsArtistalbums
{
    [JsonPropertyName("sortBy")]
    public string SortBy { get; set; }
}