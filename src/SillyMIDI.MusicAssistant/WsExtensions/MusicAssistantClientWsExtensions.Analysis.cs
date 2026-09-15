using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions
{
    public static partial class MusicAssistantClientWsExtensions
    {
        [ToRpc]
        public static async Task<AnalysisWaveResponse> GetWaveform(this MusicAssistantClientWs c, string itemid, string providerInstanceIdOrDomain)
        {
            var m = new Message(Commands.AudioAnalysisGetWaveform)
            {
                Args = new Dictionary<string, object>
                {
                    { "item_id", itemid },
                    { "provider_instance_id_or_domain", providerInstanceIdOrDomain }
                }
            };

            return await SendAsync<AnalysisWaveResponse>(c, m);
        }

    }
}

