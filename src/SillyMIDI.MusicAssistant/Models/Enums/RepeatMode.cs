using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models.Enums;

[JsonConverter(typeof(FallbackEnumConverter<RepeatMode>))]
public enum RepeatMode
{
    Unknown,
    Off,
    One,
    All, 
}

