using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Models;

namespace SillyMIDI.MusicAssistant.Events;

public class PlayerQueueEventResponse : BaseEventResponse
{
    [JsonPropertyName("data")]
    public new PlayerQueue? Data { get; set; }
}