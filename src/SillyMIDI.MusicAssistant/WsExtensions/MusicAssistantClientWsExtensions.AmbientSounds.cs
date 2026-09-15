using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Adds a custom ambient sound by stream URL.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="url">Stream URL of the ambient sound.</param>
    /// <param name="name">Display name.</param>
    /// <returns>A task that represents the asynchronous operation, returning a <see cref="SoundEffectResponse"/>.</returns>
    [ToRpc]
    public static async Task<SoundEffectResponse> AddAmbientSoundAsync(this MusicAssistantClientWs c, string url, string name)
    {
        var m = new Message(Commands.AmbientAddSound)
        {
            Args = new Dictionary<string, object>
            {
                { "url", url },
                { "name", name }
            }
        };

        return await SendAsync<SoundEffectResponse>(c, m);
    }

    /// <summary>
    /// Removes a previously added custom ambient sound.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="url">Stream URL of the ambient sound to remove.</param>
    /// <returns>A task that represents the asynchronous operation, returning a <see cref="TempResponse"/>.</returns>
    [ToRpc]
    public static async Task<TempResponse> RemoveAmbientSoundAsync(this MusicAssistantClientWs c, string url)
    {
        var m = new Message(Commands.AmbientRemoveSound)
        {
            Args = new Dictionary<string, object>
            {
                { "url", url }
            }
        };

        return await SendAsync<TempResponse>(c, m);
    }
}

