using WateryTart.MusicAssistant.Generators.Attributes;
using WateryTart.MusicAssistant.Messages;
using WateryTart.MusicAssistant.Models;
using WateryTart.MusicAssistant.Models.Enums;
using WateryTart.MusicAssistant.Responses;

namespace WateryTart.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Configure Autoplay setting on the queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesAutoplayAsync(this MusicAssistantClientWs c, string queueId, bool autoplayEnabled)
    {
        var m = new Message(Commands.PlayerQueuesAutoplay)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("autoplay_enabled", autoplayEnabled);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Enable or disable crossfade on the queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesCrossfadeAsync(this MusicAssistantClientWs c, string queueId, bool crossfadeEnabled)
    {
        var m = new Message(Commands.PlayerQueuesCrossfade)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("crossfade_enabled", crossfadeEnabled);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Delete item (by id or index) from the queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesDeleteItemAsync(this MusicAssistantClientWs c, string queueId, string itemIdOrIndex)
    {
        var m = new Message(Commands.PlayerQueuesDeleteItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("item_id_or_index", itemIdOrIndex);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return PlayerQueue by queue_id or None if not found.
    /// </summary>
    [ToRpc]
    public static async Task<PlayerQueueResponse> PlayerQueuesGetAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<PlayerQueueResponse>(c, m);
    }

    /// <summary>
    /// Return the current active/synced queue for a player.
    /// </summary>
    [ToRpc]
    public static async Task<PlayerQueueResponse> PlayerQueuesGetActiveQueueAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayerQueuesGetActiveQueue)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<PlayerQueueResponse>(c, m);
    }

    /// <summary>
    /// Return all QueueItems for given PlayerQueue.
    /// </summary>
    [ToRpc]
    public static async Task<PlayerQueueItemsResponse> PlayerQueuesItemsAsync(this MusicAssistantClientWs c, string queueId, int? limit = null, int? offset = null)
    {
        var m = new Message(Commands.PlayerQueuesItems)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        if (limit != null)
            m.Args.Add("limit", limit);
        if (offset != null)
            m.Args.Add("offset", offset);
        return await SendAsync<PlayerQueueItemsResponse>(c, m);
    }

    /// <summary>
    /// Move queue item x up/down the queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesMoveItemAsync(this MusicAssistantClientWs c, string queueId, string queueItemId, int? posShift = null)
    {
        var m = new Message(Commands.PlayerQueuesMoveItem)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("queue_item_id", queueItemId);
        if (posShift != null)
            m.Args.Add("pos_shift", posShift);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Move queue item to the end the queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesMoveItemEndAsync(this MusicAssistantClientWs c, string queueId, string queueItemId)
    {
        var m = new Message(Commands.PlayerQueuesMoveItemEnd)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("queue_item_id", queueItemId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle NEXT TRACK command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesNextAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesNext)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Configure the audio overlay for the given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesOverlayAsync(this MusicAssistantClientWs c, string queueId, bool? enabled = null, string? source = null, int? volume = null)
    {
        var m = new Message(Commands.PlayerQueuesOverlay)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        if (enabled != null)
            m.Args.Add("enabled", enabled);
        if (source != null)
            m.Args.Add("source", source);
        if (volume != null)
            m.Args.Add("volume", volume);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle PAUSE command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesPauseAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesPause)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle PLAY command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesPlayAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesPlay)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Play item at index (or item_id) X in queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesPlayIndexAsync(this MusicAssistantClientWs c, string queueId, string index, int? seekPosition = null, bool? fadeIn = null)
    {
        var m = new Message(Commands.PlayerQueuesPlayIndex)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("index", index);
        if (seekPosition != null)
            m.Args.Add("seek_position", seekPosition);
        if (fadeIn != null)
            m.Args.Add("fade_in", fadeIn);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Play media item(s) on the given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesPlayMediaAsync(this MusicAssistantClientWs c, string queueId, List<object> media, object? option = null, bool? radioMode = null, string? startItem = null, string? sortBy = null, bool? startFromBeginning = null, bool? shuffle = null, string? user = null)
    {
        var m = new Message(Commands.PlayerQueuesPlayMedia)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("media", media);
        if (option != null)
            m.Args.Add("option", option);
        if (radioMode != null)
            m.Args.Add("radio_mode", radioMode);
        if (startItem != null)
            m.Args.Add("start_item", startItem);
        if (sortBy != null)
            m.Args.Add("sort_by", sortBy);
        if (startFromBeginning != null)
            m.Args.Add("start_from_beginning", startFromBeginning);
        if (shuffle != null)
            m.Args.Add("shuffle", shuffle);
        if (user != null)
            m.Args.Add("user", user);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Toggle play/pause on given playerqueue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesPlayPauseAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesPlayPause)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle PREVIOUS TRACK command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesPreviousAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesPrevious)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle RESUME command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesResumeAsync(this MusicAssistantClientWs c, string queueId, bool? fadeIn = null)
    {
        var m = new Message(Commands.PlayerQueuesResume)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        if (fadeIn != null)
            m.Args.Add("fade_in", fadeIn);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Save the current queue items as a new playlist.
    /// </summary>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> PlayerQueuesSaveAsPlaylistAsync(this MusicAssistantClientWs c, string queueId, string name)
    {
        var m = new Message(Commands.PlayerQueuesSaveAsPlaylist)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("name", name);
        return await SendAsync<BackgroundTaskResponse>(c, m);
    }

    /// <summary>
    /// Set the playback speed for the given queue item.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesSetPlaybackSpeedAsync(this MusicAssistantClientWs c, string queueId, double speed, string? queueItemId = null)
    {
        var m = new Message(Commands.PlayerQueuesSetPlaybackSpeed)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        m.Args.Add("speed", speed);
        if (queueItemId != null)
            m.Args.Add("queue_item_id", queueItemId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle SKIP command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesSkipAsync(this MusicAssistantClientWs c, string queueId, int? seconds = null)
    {
        var m = new Message(Commands.PlayerQueuesSkip)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        if (seconds != null)
            m.Args.Add("seconds", seconds);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle STOP command for given queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesStopAsync(this MusicAssistantClientWs c, string queueId)
    {
        var m = new Message(Commands.PlayerQueuesStop)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("queue_id", queueId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Transfer queue to another queue.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayerQueuesTransferAsync(this MusicAssistantClientWs c, string sourceQueueId, string targetQueueId, bool? autoPlay = null)
    {
        var m = new Message(Commands.PlayerQueuesTransfer)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("source_queue_id", sourceQueueId);
        m.Args.Add("target_queue_id", targetQueueId);
        if (autoPlay != null)
            m.Args.Add("auto_play", autoPlay);
        return await SendAsync<TempResponse>(c, m);
    }

}