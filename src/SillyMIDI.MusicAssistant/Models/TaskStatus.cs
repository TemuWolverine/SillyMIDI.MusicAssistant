using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models;

[JsonConverter(typeof(FallbackEnumConverter<TaskStatus>))]
public enum TaskStatus
{
    Unknown,
    Idle,
    Pending,
    Running,
    Success,
    PartialSuccess,
    Failed,
    Cancelled
}

