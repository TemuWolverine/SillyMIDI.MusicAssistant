using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Models.Enums;

namespace SillyMIDI.MusicAssistant.Events;

public class BaseEventResponse
{
    [JsonPropertyName("event")] public EventType EventName { get; set; }
    
    [JsonPropertyName("object_id")] public string? ObjectId { get; set; }
    
    [JsonPropertyName("data")] public object? Data { get; set; }
}