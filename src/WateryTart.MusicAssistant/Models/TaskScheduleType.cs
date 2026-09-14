using System.Text.Json.Serialization;
using WateryTart.MusicAssistant.Converters;

namespace WateryTart.MusicAssistant.Models;

[JsonConverter(typeof(FallbackEnumConverter<TaskScheduleType>))]
public enum TaskScheduleType
{
    Unknown,
    Hourly,
    Daily,
    Weekly
}

