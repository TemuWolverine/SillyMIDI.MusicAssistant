using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Events;

public class MediaItemEvent2Response : BaseEventResponse
{
    [JsonPropertyName("data")]
    public new MediaItemEvent2Item? Data { get; set; }
}
