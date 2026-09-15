using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Models;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    [ToRpc]
    public static async Task<CountResponse> GetTrackLyrics(this MusicAssistantClientWs c, MediaItem track)
    {
        var m = new Message(Commands.MetadataGetTrackLyrics)
        {
            Args = new Dictionary<string, object>()
                {
                    { "track", track }
                }
        };
        return await SendAsync<CountResponse>(c, m);
    }
}