using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class PartyConfig
{
    [JsonPropertyName("enable_rate_limiting")]
    public bool EnableRateLimiting { get; set; }

    [JsonPropertyName("enable_add_queue")]
    public bool EnableAddQueue { get; set; }

    [JsonPropertyName("enable_boost")]
    public bool EnableBoost { get; set; }

    [JsonPropertyName("enable_skip_song")]
    public bool EnableSkipSong { get; set; }

    [JsonPropertyName("add_queue_limit")]
    public int AddQueueLimit { get; set; }

    [JsonPropertyName("add_queue_refill_minutes")]
    public int AddQueueRefillMinutes { get; set; }

    [JsonPropertyName("boost_limit")]
    public int BoostLimit { get; set; }

    [JsonPropertyName("boost_refill_minutes")]
    public int BoostRefillMinutes { get; set; }

    [JsonPropertyName("skip_song_limit")]
    public int SkipSongLimit { get; set; }

    [JsonPropertyName("skip_song_refill_minutes")]
    public int SkipSongRefillMinutes { get; set; }

    [JsonPropertyName("karaoke_mode")]
    public bool KaraokeMode { get; set; }

    [JsonPropertyName("highlight_ahead")]
    public bool HighlightAhead { get; set; }

    [JsonPropertyName("request_badge_color")]
    public string? RequestBadgeColor { get; set; }

    [JsonPropertyName("boost_badge_color")]
    public string? BoostBadgeColor { get; set; }

    [JsonPropertyName("anti_burn_in")]
    public bool AntiBurnIn { get; set; }

    [JsonPropertyName("party_name")]
    public string? PartyName { get; set; }

    [JsonPropertyName("qr_text")]
    public string? QrText { get; set; }

    [JsonPropertyName("hide_back_button")]
    public bool HideBackButton { get; set; }

    [JsonPropertyName("show_progress_bar")]
    public bool ShowProgressBar { get; set; }

    [JsonPropertyName("prevent_duplicate_tracks")]
    public bool PreventDuplicateTracks { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

