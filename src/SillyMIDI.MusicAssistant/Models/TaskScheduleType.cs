using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models;

[JsonConverter(typeof(FallbackEnumConverter<TaskScheduleType>))]
public enum TaskScheduleType
{
    Unknown,
    Hourly,
    Daily,
    Weekly
}

