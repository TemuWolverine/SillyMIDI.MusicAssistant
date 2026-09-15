using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Models;

namespace SillyMIDI.MusicAssistant.Events;

public class MediaItemEventResponse : BaseEventResponse
{
    [JsonPropertyName("data")]
    public new MediaItemEventItem? Data { get; set; }
}