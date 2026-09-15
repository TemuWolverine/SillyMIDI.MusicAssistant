using System.Text.Json.Serialization;
using SillyMIDI.MusicAssistant.Converters;

namespace SillyMIDI.MusicAssistant.Models.Enums;

[JsonConverter(typeof(FallbackEnumConverter<MediaType>))]
public enum MediaType
{
    Unknown,
    Artist,
    Album,
    Track,
    Genre,
    Playlist,
    Radio,
    Podcast,
    PodcastEpisode,
    Audiobook,
    Folder,
    Collection,
    Announcement,
    FlowStream,
    PluginSource,
    AudioSource,
    SoundEffect
}