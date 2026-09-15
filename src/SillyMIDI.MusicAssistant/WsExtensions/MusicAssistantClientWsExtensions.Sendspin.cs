using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Pairs the built-in web player that minted the given pairing token.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="pairingToken">The calling web player's version 0 pairing token.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<TempResponse> PairWebPlayerAsync(this MusicAssistantClientWs c, string pairingToken)
    {
        var m = new Message(Commands.SendspinPairWebPlayer)
        {
            Args = new Dictionary<string, object>
            {
                { "pairing_token", pairingToken }
            }
        };

        return await SendAsync<TempResponse>(c, m);
    }
}

