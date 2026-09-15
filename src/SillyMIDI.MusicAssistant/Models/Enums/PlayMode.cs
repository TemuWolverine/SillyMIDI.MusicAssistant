using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models.Enums;

[JsonConverter(typeof(FallbackEnumConverter<PlayMode>))]
public enum PlayMode
{
    Unknown,
    Play,
    Replace,
    Next,
    ReplaceNext,
    Add
}