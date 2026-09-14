using WateryTart.MusicAssistant.Generators.Attributes;
using WateryTart.MusicAssistant.Messages;
using WateryTart.MusicAssistant.Responses;

namespace WateryTart.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Adds a media item to the party queue.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="uri">The URI of the media item to add (e.g. spotify://track/xxx).</param>
    /// <param name="boost">If true, inserts at the front of the guest section (play next).</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> PartyAddToQueueAsync(this MusicAssistantClientWs c, string uri, bool? boost = null)
    {
        var args = new Dictionary<string, object>
        {
            { "uri", uri }
        };

        if (boost.HasValue)
        {
            args.Add("boost", boost.Value);
        }

        var m = new Message(Commands.PartyAddToQueue)
        {
            Args = args
        };

        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Boosts an existing queue item by moving it to the boosted section.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="queueItemId">The queue_item_id of the item to boost.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> PartyBoostQueueItemAsync(this MusicAssistantClientWs c, string queueItemId)
    {
        var m = new Message(Commands.PartyBoostQueueItem)
        {
            Args = new Dictionary<string, object>
            {
                { "queue_item_id", queueItemId }
            }
        };

        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Returns whether the given guest web player can listen in on the party audio.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="webPlayerId">The player_id of the guest's web player.</param>
    /// <returns>A task containing a boolean indicating if listening in is allowed.</returns>
    [ToRpc]
    public static async Task<BooleanResponse> PartyCanListenInAsync(this MusicAssistantClientWs c, string webPlayerId)
    {
        var m = new Message(Commands.PartyCanListenIn)
        {
            Args = new Dictionary<string, object>
            {
                { "web_player_id", webPlayerId }
            }
        };

        return await SendAsync<BooleanResponse>(c, m);
    }

    /// <summary>
    /// Gets the party configuration for guest rate limiting and UI settings.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task containing the <see cref="PartyConfigResponse"/>.</returns>
    [ToRpc]
    public static async Task<PartyConfigResponse> GetPartyConfigAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.PartyConfig);
        return await SendAsync<PartyConfigResponse>(c, m);
    }

    /// <summary>
    /// Attaches a guest's web player to the party audio.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="webPlayerId">The player_id of the guest's web player.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> PartyListenInAsync(this MusicAssistantClientWs c, string webPlayerId)
    {
        var m = new Message(Commands.PartyListenIn)
        {
            Args = new Dictionary<string, object>
            {
                { "web_player_id", webPlayerId }
            }
        };

        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Gets the configured party player/queue ID.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task containing the player/queue ID as a string response.</returns>
    [ToRpc]
    public static async Task<StringResponse> GetPartyPlayerAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.PartyPlayer);
        return await SendAsync<StringResponse>(c, m);
    }

    /// <summary>
    /// Skips the currently playing party track.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> PartySkipAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.PartySkip);
        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Detaches a guest's web player from the party audio.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="webPlayerId">The player_id of the guest's web player.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<JsonElementResponse> PartyStopListenInAsync(this MusicAssistantClientWs c, string webPlayerId)
    {
        var m = new Message(Commands.PartyStopListenIn)
        {
            Args = new Dictionary<string, object>
            {
                { "web_player_id", webPlayerId }
            }
        };

        return await SendAsync<JsonElementResponse>(c, m);
    }

    /// <summary>
    /// Gets the guest access URL for the party mode.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task containing the guest URL as a string response.</returns>
    [ToRpc]
    public static async Task<StringResponse> GetPartyUrlAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.PartyUrl);
        return await SendAsync<StringResponse>(c, m);
    }
}

