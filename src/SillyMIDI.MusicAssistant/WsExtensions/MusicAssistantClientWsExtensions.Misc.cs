using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Responses;
using SillyMIDI.MusicAssistant.Generators.Attributes;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    [ToRpc]
    public static async Task<ServerInfoResponse> GetInfoAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.Info)
        {
            Args = new Dictionary<string, object>()
        };

        return await SendAsync<ServerInfoResponse>(c, m);
    }
}
