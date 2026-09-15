using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models.Enums;

[JsonConverter(typeof(FallbackEnumConverter<ImageType>))]
public enum ImageType
{
    Unknown,
    Thumb,
    ThumbHq,
    Landscape,
    Fanart,
    Discart,
    Clearart,
    Logo,
    Banner,
    cutout,
    Other
}