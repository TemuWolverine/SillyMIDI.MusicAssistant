using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Events;

public class PlayerQueueTimeUpdatedEventResponse : BaseEventResponse
{
    [JsonPropertyName("data")]
    public new float Data { get; set; }
}