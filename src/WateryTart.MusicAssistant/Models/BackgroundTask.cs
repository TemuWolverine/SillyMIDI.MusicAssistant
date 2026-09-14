using System.Text.Json.Serialization;

namespace WateryTart.MusicAssistant.Models;

public class BackgroundTask
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("status")]
    public TaskStatus Status { get; set; } = TaskStatus.Pending;

    [JsonPropertyName("translation_key")]
    public string? TranslationKey { get; set; }

    [JsonPropertyName("translation_args")]
    public List<object>? TranslationArgs { get; set; }

    [JsonPropertyName("logs")]
    public List<string>? Logs { get; set; }

    [JsonPropertyName("schedule")]
    public TaskSchedule? Schedule { get; set; }

    [JsonPropertyName("last_run")]
    public string? LastRun { get; set; }

    [JsonPropertyName("next_run")]
    public string? NextRun { get; set; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }

    [JsonPropertyName("last_run_user_id")]
    public string? LastRunUserId { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("started_at")]
    public string? StartedAt { get; set; }

    [JsonPropertyName("finished_at")]
    public string? FinishedAt { get; set; }

    [JsonPropertyName("last_error")]
    public string? LastError { get; set; }

    [JsonPropertyName("failure_count")]
    public int FailureCount { get; set; }

    [JsonPropertyName("failure_messages")]
    public List<string>? FailureMessages { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("progress_text")]
    public string? ProgressText { get; set; }

    [JsonPropertyName("allow_retry")]
    public bool AllowRetry { get; set; }

    [JsonPropertyName("allow_cancel")]
    public bool AllowCancel { get; set; } = true;

    [JsonPropertyName("report")]
    public string? Report { get; set; }
}

