using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models.Enums;

[JsonConverter(typeof(FallbackEnumConverter<PlaybackState>))]
public enum PlaybackState
{
    Unknown,
    Idle,
    Playing,
    Paused,
    Stopped
}