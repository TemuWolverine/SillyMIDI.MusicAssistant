using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class TaskSchedule
{
    [JsonPropertyName("type")]
    public TaskScheduleType Type { get; set; } = TaskScheduleType.Hourly;

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; } = true;

    [JsonPropertyName("every")]
    public int? Every { get; set; }

    [JsonPropertyName("days_of_week")]
    public List<int>? DaysOfWeek { get; set; }

    [JsonPropertyName("hour")]
    public int? Hour { get; set; }

    [JsonPropertyName("minute")]
    public int? Minute { get; set; }
}

