using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Models;

namespace SillyMIDI.MusicAssistant.Events;

public class PlayerEventResponse : BaseEventResponse
{
    [JsonPropertyName("data")]
    public new Player? Data { get; set; }
}