using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Models;
using SillyMIDI.MusicAssistant.Models.Enums;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /*MusicAssistantClientWs*/
    public static async Task<StringArrayResponse> GetLyricsAsync(this MusicAssistantClientWs c, Item track)
    {
        /*track.Metadata = null;
        track.Album = null;*/
        track.Position = null;
        //track.Artists = null;
        var m = new Message(Commands.MetadataGetTrackLyrics)
        {
            Args = new Dictionary<string, object>()
                {
                    { "track", track }
                }
        };

        /*        var m = new Message(Commands.MetadataGetTrackLyrics)
        {
            Args = new Dictionary<string, object>()
                {
                    {
                    "track", new Item {
                        ItemId = track.ItemId,
                        MediaType= MediaType.Track,
                        Provider = track.Provider,
                    } }
                }
        };*/
        return await SendAsync<StringArrayResponse>(c, m);
    }
}