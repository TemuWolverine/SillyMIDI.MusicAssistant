using WateryTart.MusicAssistant.Messages;
using WateryTart.MusicAssistant.Responses;
using WateryTart.MusicAssistant.Generators.Attributes;

namespace WateryTart.MusicAssistant.WsExtensions;

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
