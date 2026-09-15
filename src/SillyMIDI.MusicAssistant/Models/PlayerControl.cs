using System.Text.Json.Serialization;

namespace SillyMIDI.MusicAssistant.Models;

public class PlayerControl
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("provider")]
    public string Provider { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("supports_power")]
    public bool SupportsPower { get; set; }

    [JsonPropertyName("supports_volume")]
    public bool SupportsVolume { get; set; }

    [JsonPropertyName("supports_mute")]
    public bool SupportsMute { get; set; }

    [JsonPropertyName("power_state")]
    public bool PowerState { get; set; }

    [JsonPropertyName("volume_level")]
    public int VolumeLevel { get; set; }

    [JsonPropertyName("volume_muted")]
    public bool VolumeMuted { get; set; }
}

