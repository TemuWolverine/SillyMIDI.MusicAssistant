using System.Text.Json.Serialization;
using WateryTart.MusicAssistant.Converters;

namespace WateryTart.MusicAssistant.Models;

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

