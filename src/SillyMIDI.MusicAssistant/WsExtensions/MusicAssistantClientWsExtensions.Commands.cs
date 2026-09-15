using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Executes a Music Assistant command that does not yet have a dedicated, strongly typed extension method.
    /// </summary>
    /// <remarks>
    /// The OpenAPI <c>/api</c> operation deliberately leaves command results unconstrained. This method
    /// preserves that result as a <see cref="System.Text.Json.JsonElement"/> instead of deserializing it
    /// to <see cref="object"/> and losing its JSON shape. Use the command name and argument names listed
    /// in the Commands Reference.
    /// </remarks>
    [ToRpc]
    public static async Task<JsonElementResponse> ExecuteCommandAsync(
        this MusicAssistantClientWs c,
        string command,
        IReadOnlyDictionary<string, object?>? args = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(command);

        var m = new Message(command);
        if (args is { Count: > 0 })
        {
            m.Args = args
                .Where(argument => argument.Value is not null)
                .ToDictionary(argument => argument.Key, argument => argument.Value!);
        }

        return await SendAsync<JsonElementResponse>(c, m);
    }
}
