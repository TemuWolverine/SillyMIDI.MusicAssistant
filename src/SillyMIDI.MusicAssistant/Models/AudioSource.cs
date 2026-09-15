using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class AudioSource : MediaItemBase
{
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }

    [JsonPropertyName("can_play_pause")]
    public bool CanPlayPause { get; set; }

    [JsonPropertyName("can_seek")]
    public bool CanSeek { get; set; }

    [JsonPropertyName("can_next_previous")]
    public bool CanNextPrevious { get; set; }

    [JsonPropertyName("can_shuffle")]
    public bool CanShuffle { get; set; }

    [JsonPropertyName("can_repeat")]
    public bool CanRepeat { get; set; }

    [JsonPropertyName("exclusive")]
    public bool Exclusive { get; set; } = true;

    [JsonPropertyName("allow_external_trigger")]
    public bool AllowExternalTrigger { get; set; }

    [JsonPropertyName("can_initiate")]
    public bool CanInitiate { get; set; }

    [JsonPropertyName("account_id")]
    public string? AccountId { get; set; }
}

