using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Models;
using SillyMIDI.MusicAssistant.Models.Enums;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Add the currently playing item/track on given player to the favorites.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersAddCurrentlyPlayingToFavoritesAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersAddCurrentlyPlayingToFavoritesDirect)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle GROUP command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdGroupAsync(this MusicAssistantClientWs c, string playerId, string targetPlayer)
    {
        var m = new Message(Commands.PlayersCmdGroup)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("target_player", targetPlayer);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Join given player(s) to target player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdGroupManyAsync(this MusicAssistantClientWs c, string targetPlayer, List<string> childPlayerIds)
    {
        var m = new Message(Commands.PlayersCmdGroupMany)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("target_player", targetPlayer);
        m.Args.Add("child_player_ids", childPlayerIds);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle adjusting the overall/group volume to a playergroup (or synced players).
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdGroupVolumeAsync(this MusicAssistantClientWs c, string playerId, int volumeLevel)
    {
        var m = new Message(Commands.PlayersCmdGroupVolume)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("volume_level", volumeLevel);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send VOLUME_DOWN command to given playergroup.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdGroupVolumeDownAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdGroupVolumeDown)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle muting a playergroup (or synced players) as a whole.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdGroupVolumeMuteAsync(this MusicAssistantClientWs c, string playerId, bool muted)
    {
        var m = new Message(Commands.PlayersCmdGroupVolumeMute)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("muted", muted);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send VOLUME_UP command to given playergroup.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdGroupVolumeUpAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdGroupVolumeUp)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle NEXT TRACK command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdNextAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdNext)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send PAUSE command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdPauseAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdPause)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle playback of an announcement on given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdPlayAnnouncementAsync(this MusicAssistantClientWs c, string playerId, string? url = null, bool? preAnnounce = null, int? volumeLevel = null, string? preAnnounceUrl = null, string? message = null, string? ttsEngine = null, string? language = null)
    {
        var m = new Message(Commands.PlayersCmdPlayAnnouncement)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        if (url != null)
            m.Args.Add("url", url);
        if (preAnnounce != null)
            m.Args.Add("pre_announce", preAnnounce);
        if (volumeLevel != null)
            m.Args.Add("volume_level", volumeLevel);
        if (preAnnounceUrl != null)
            m.Args.Add("pre_announce_url", preAnnounceUrl);
        if (message != null)
            m.Args.Add("message", message);
        if (ttsEngine != null)
            m.Args.Add("tts_engine", ttsEngine);
        if (language != null)
            m.Args.Add("language", language);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send PLAY (unpause) command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdPlayAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdPlay)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Toggle play/pause on given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdPlayPauseAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdPlayPause)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send POWER command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdPowerAsync(this MusicAssistantClientWs c, string playerId, bool powered)
    {
        var m = new Message(Commands.PlayersCmdPower)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("powered", powered);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle PREVIOUS TRACK command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdPreviousAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdPrevious)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle REPEAT command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdRepeatAsync(this MusicAssistantClientWs c, string playerId, RepeatMode repeatMode, string? sourceId = null)
    {
        var m = new Message(Commands.PlayersCmdRepeat)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("repeat_mode", repeatMode);
        if (sourceId != null)
            m.Args.Add("source_id", sourceId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send RESUME command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdResumeAsync(this MusicAssistantClientWs c, string playerId, string? source = null, object? media = null)
    {
        var m = new Message(Commands.PlayersCmdResume)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        if (source != null)
            m.Args.Add("source", source);
        if (media != null)
            m.Args.Add("media", media);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle SEEK command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdSeekAsync(this MusicAssistantClientWs c, string playerId, int position)
    {
        var m = new Message(Commands.PlayersCmdSeek)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("position", position);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle SELECT SOUND MODE command on given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdSelectSoundModeAsync(this MusicAssistantClientWs c, string playerId, string soundMode)
    {
        var m = new Message(Commands.PlayersCmdSelectSoundMode)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("sound_mode", soundMode);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle SELECT SOURCE command on given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdSelectSourceAsync(this MusicAssistantClientWs c, string playerId, string source)
    {
        var m = new Message(Commands.PlayersCmdSelectSource)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("source", source);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Join/unjoin given player(s) to/from target player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdSetMembersAsync(this MusicAssistantClientWs c, string targetPlayer, List<string>? playerIdsToAdd = null, List<string>? playerIdsToRemove = null)
    {
        var m = new Message(Commands.PlayersCmdSetMembers)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("target_player", targetPlayer);
        if (playerIdsToAdd != null)
            m.Args.Add("player_ids_to_add", playerIdsToAdd);
        if (playerIdsToRemove != null)
            m.Args.Add("player_ids_to_remove", playerIdsToRemove);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle SET_OPTION command on given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdSetOptionAsync(this MusicAssistantClientWs c, string playerId, string optionKey, string optionValue)
    {
        var m = new Message(Commands.PlayersCmdSetOption)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("option_key", optionKey);
        m.Args.Add("option_value", optionValue);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle SHUFFLE command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdShuffleAsync(this MusicAssistantClientWs c, string playerId, bool shuffleEnabled, string? sourceId = null)
    {
        var m = new Message(Commands.PlayersCmdShuffle)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("shuffle_enabled", shuffleEnabled);
        if (sourceId != null)
            m.Args.Add("source_id", sourceId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send STOP command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdStopAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdStop)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle UNGROUP command for given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdUngroupAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdUngroup)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Handle UNGROUP command for all the given players.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdUngroupManyAsync(this MusicAssistantClientWs c, List<string> playerIds)
    {
        var m = new Message(Commands.PlayersCmdUngroupMany)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_ids", playerIds);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send VOLUME_DOWN command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdVolumeDownAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdVolumeDown)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send VOLUME_MUTE command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdVolumeMuteAsync(this MusicAssistantClientWs c, string playerId, bool muted)
    {
        var m = new Message(Commands.PlayersCmdVolumeMute)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("muted", muted);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send VOLUME_SET command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdVolumeSetAsync(this MusicAssistantClientWs c, string playerId, int volumeLevel)
    {
        var m = new Message(Commands.PlayersCmdVolumeSet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        m.Args.Add("volume_level", volumeLevel);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Send VOLUME_UP command to given player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersCmdVolumeUpAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersCmdVolumeUp)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Create a new (permanent) Group Player.
    /// </summary>
    [ToRpc]
    public static async Task<SinglePlayerResponse> PlayersCreateGroupPlayerAsync(this MusicAssistantClientWs c, string provider, string name, List<string> members, bool? dynamic = null)
    {
        var m = new Message(Commands.PlayersCreateGroupPlayer)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("provider", provider);
        m.Args.Add("name", name);
        m.Args.Add("members", members);
        if (dynamic != null)
            m.Args.Add("dynamic", dynamic);
        return await SendAsync<SinglePlayerResponse>(c, m);
    }

    /// <summary>
    /// Return PlayerState by player_id.
    /// </summary>
    [ToRpc]
    public static async Task<SinglePlayerResponse> PlayersGetAsync(this MusicAssistantClientWs c, string playerId, bool? raiseUnavailable = null)
    {
        var m = new Message(Commands.PlayersGet)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        if (raiseUnavailable != null)
            m.Args.Add("raise_unavailable", raiseUnavailable);
        return await SendAsync<SinglePlayerResponse>(c, m);
    }

    /// <summary>
    /// Return PlayerState by name.
    /// </summary>
    [ToRpc]
    public static async Task<SinglePlayerResponse> PlayersGetByNameAsync(this MusicAssistantClientWs c, string name)
    {
        var m = new Message(Commands.PlayersGetByName)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("name", name);
        return await SendAsync<SinglePlayerResponse>(c, m);
    }

    /// <summary>
    /// Return PlayerControl by control_id.
    /// </summary>
    [ToRpc]
    public static async Task<PlayerControlResponse> PlayersPlayerControlAsync(this MusicAssistantClientWs c, string controlId)
    {
        var m = new Message(Commands.PlayersPlayerControl)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("control_id", controlId);
        return await SendAsync<PlayerControlResponse>(c, m);
    }

    /// <summary>
    /// Return all registered playercontrols.
    /// </summary>
    [ToRpc]
    public static async Task<PlayerControlsResponse> PlayersPlayerControlsAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.PlayersPlayerControls);
        return await SendAsync<PlayerControlsResponse>(c, m);
    }

    /// <summary>
    /// Remove a player from a provider.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersRemoveAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersRemove)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Remove a group player.
    /// </summary>
    [ToRpc]
    public static async Task<TempResponse> PlayersRemoveGroupPlayerAsync(this MusicAssistantClientWs c, string playerId)
    {
        var m = new Message(Commands.PlayersRemoveGroupPlayer)
        {
            Args = new Dictionary<string, object>()
        };
        m.Args.Add("player_id", playerId);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Return the TTS engines that can speak an announcement.
    /// </summary>
    [ToRpc]
    public static async Task<StringArrayResponse> PlayersTtsEnginesAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.PlayersTtsEngines);
        return await SendAsync<StringArrayResponse>(c, m);
    }
}