using WateryTart.MusicAssistant.Generators.Attributes;
using WateryTart.MusicAssistant.Messages;
using WateryTart.MusicAssistant.Responses;

namespace WateryTart.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Returns the track count and approximate total duration for the given rules.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="rules">SmartPlaylistRules dictionary/object.</param>
    /// <returns>A task returning the count and duration summary.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> SmartPlaylistsCountTracksAsync(this MusicAssistantClientWs c, object rules)
    {
        var m = new Message(Commands.SmartPlaylistsCountTracks)
        {
            Args = new Dictionary<string, object>
            {
                { "rules", rules }
            }
        };

        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Creates a new smart playlist with the given rules.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="name">Name for the new playlist.</param>
    /// <param name="rules">Dictionary of SmartPlaylistRules fields.</param>
    /// <param name="isDynamic">If true, tracks are re-evaluated fresh on each play.</param>
    /// <returns>A task returning the created <see cref="PlaylistResponse"/>.</returns>
    [ToRpc]
    public static async Task<PlaylistResponse> CreateSmartPlaylistAsync(this MusicAssistantClientWs c, string name, object rules, bool? isDynamic = null)
    {
        var args = new Dictionary<string, object>
        {
            { "name", name },
            { "rules", rules }
        };

        if (isDynamic.HasValue)
        {
            args.Add("is_dynamic", isDynamic.Value);
        }

        var m = new Message(Commands.SmartPlaylistsCreate)
        {
            Args = args
        };

        return await SendAsync<PlaylistResponse>(c, m);
    }

    /// <summary>
    /// Evaluates rules once and creates a static (non-dynamic) builtin playlist.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="name">Name for the new playlist.</param>
    /// <param name="rules">Dictionary of SmartPlaylistRules fields.</param>
    /// <param name="count">Optional track count override.</param>
    /// <returns>A task returning the generated <see cref="PlaylistResponse"/>.</returns>
    [ToRpc]
    public static async Task<PlaylistResponse> GenerateSmartPlaylistAsync(this MusicAssistantClientWs c, string name, object rules, int? count = null)
    {
        var args = new Dictionary<string, object>
        {
            { "name", name },
            { "rules", rules }
        };

        if (count.HasValue)
        {
            args.Add("count", count.Value);
        }

        var m = new Message(Commands.SmartPlaylistsGenerate)
        {
            Args = args
        };

        return await SendAsync<PlaylistResponse>(c, m);
    }

    /// <summary>
    /// Returns the smart playlist rules for the given playlist ID.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="playlistId">Provider playlist ID (UUID) or library DB ID.</param>
    /// <returns>A task returning the rules as a JSON element.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> GetSmartPlaylistRulesAsync(this MusicAssistantClientWs c, string playlistId)
    {
        return await SendAsync<JsonElementResponse>(c, ClientHelpers.JustId(Commands.SmartPlaylistsGetRules, playlistId, "playlist_id"));
    }

    /// <summary>
    /// Returns a list of all smart playlist IDs and their rule summaries.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task returning the list of smart playlists.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> GetSmartPlaylistsListAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.SmartPlaylistsList);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Returns a preview of tracks matching the given rules.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="rules">SmartPlaylistRules fields as dictionary.</param>
    /// <param name="limit">Maximum number of preview tracks to return.</param>
    /// <returns>A task returning the preview tracks.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> PreviewSmartPlaylistTracksAsync(this MusicAssistantClientWs c, object rules, int? limit = null)
    {
        var args = new Dictionary<string, object>
        {
            { "rules", rules }
        };

        if (limit.HasValue)
        {
            args.Add("limit", limit.Value);
        }

        var m = new Message(Commands.SmartPlaylistsPreviewTracks)
        {
            Args = args
        };

        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Updates the rules for an existing smart playlist.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="playlistId">Provider playlist ID (UUID) or library DB ID.</param>
    /// <param name="rules">Updated SmartPlaylistRules fields as dictionary.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<TempResponse> UpdateSmartPlaylistRulesAsync(this MusicAssistantClientWs c, string playlistId, object rules)
    {
        var m = new Message(Commands.SmartPlaylistsUpdateRules)
        {
            Args = new Dictionary<string, object>
            {
                { "playlist_id", playlistId },
                { "rules", rules }
            }
        };

        return await SendAsync<TempResponse>(c, m);
    }
}

