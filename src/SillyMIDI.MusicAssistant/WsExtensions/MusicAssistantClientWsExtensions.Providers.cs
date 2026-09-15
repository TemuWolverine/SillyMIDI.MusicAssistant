using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    [ToRpc]
    public static async Task<ProviderManifestResponse> GetProvidersManifestsAsync(this MusicAssistantClientWs c)
    {
        return await SendAsync<ProviderManifestResponse>(c, ClientHelpers.JustCommand(Commands.ProvidersManifests));
    }
}