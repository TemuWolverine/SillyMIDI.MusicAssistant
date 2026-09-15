using SillyMIDI.MusicAssistant.Generators.Attributes;
using SillyMIDI.MusicAssistant.Messages;
using SillyMIDI.MusicAssistant.Models;
using SillyMIDI.MusicAssistant.Responses;

namespace SillyMIDI.MusicAssistant.WsExtensions;

public static partial class MusicAssistantClientWsExtensions
{
    /// <summary>
    /// Cancels a pending or running background task.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task to cancel.</param>
    /// <returns>A task returning the updated <see cref="BackgroundTaskResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> CancelTaskAsync(this MusicAssistantClientWs c, string taskId)
    {
        return await SendAsync<BackgroundTaskResponse>(c, ClientHelpers.JustId(Commands.TasksCancel, taskId, "task_id"));
    }

    /// <summary>
    /// Removes finished non-scheduled tasks from history.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<TempResponse> ClearFinishedTasksAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.TasksClearFinished);
        return await SendAsync<TempResponse>(c, m);
    }

    /// <summary>
    /// Returns a single task by ID.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task to retrieve.</param>
    /// <returns>A task returning the <see cref="BackgroundTaskResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> GetTaskAsync(this MusicAssistantClientWs c, string taskId)
    {
        return await SendAsync<BackgroundTaskResponse>(c, ClientHelpers.JustId(Commands.TasksGet, taskId, "task_id"));
    }

    /// <summary>
    /// Returns all visible managed background tasks.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <returns>A task returning the list of <see cref="BackgroundTasksResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTasksResponse> GetTasksAsync(this MusicAssistantClientWs c)
    {
        var m = new Message(Commands.TasksList);
        return await SendAsync<BackgroundTasksResponse>(c, m);
    }

    /// <summary>
    /// Returns the log buffer for a single task.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task.</param>
    /// <returns>A task returning the log string.</returns>
    [ToRpc]
    public static async Task<StringResponse> GetTaskLogAsync(this MusicAssistantClientWs c, string taskId)
    {
        return await SendAsync<StringResponse>(c, ClientHelpers.JustId(Commands.TasksLog, taskId, "task_id"));
    }

    /// <summary>
    /// Removes a finished task from history.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task to remove.</param>
    /// <returns>A task representing the operation outcome.</returns>
    [ToRpc]
    public static async Task<TempResponse> RemoveTaskAsync(this MusicAssistantClientWs c, string taskId)
    {
        return await SendAsync<TempResponse>(c, ClientHelpers.JustId(Commands.TasksRemove, taskId, "task_id"));
    }

    /// <summary>
    /// Retries a failed or cancelled task.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task to retry.</param>
    /// <returns>A task returning the updated <see cref="BackgroundTaskResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> RetryTaskAsync(this MusicAssistantClientWs c, string taskId)
    {
        return await SendAsync<BackgroundTaskResponse>(c, ClientHelpers.JustId(Commands.TasksRetry, taskId, "task_id"));
    }

    /// <summary>
    /// Queues a task for immediate execution.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task to run.</param>
    /// <returns>A task returning the updated <see cref="BackgroundTaskResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> RunTaskAsync(this MusicAssistantClientWs c, string taskId)
    {
        return await SendAsync<BackgroundTaskResponse>(c, ClientHelpers.JustId(Commands.TasksRun, taskId, "task_id"));
    }

    /// <summary>
    /// Enables or disables automatic scheduling for a recurring task.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task.</param>
    /// <param name="enabled">Whether scheduling is enabled.</param>
    /// <returns>A task returning the updated <see cref="BackgroundTaskResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> SetTaskEnabledAsync(this MusicAssistantClientWs c, string taskId, bool enabled)
    {
        var m = new Message(Commands.TasksSetEnabled)
        {
            Args = new Dictionary<string, object>
            {
                { "task_id", taskId },
                { "enabled", enabled }
            }
        };

        return await SendAsync<BackgroundTaskResponse>(c, m);
    }

    /// <summary>
    /// Updates the schedule definition for a recurring task.
    /// </summary>
    /// <param name="c">The Music Assistant WebSocket client.</param>
    /// <param name="taskId">The ID of the task.</param>
    /// <param name="schedule">The updated schedule definition.</param>
    /// <returns>A task returning the updated <see cref="BackgroundTaskResponse"/>.</returns>
    [ToRpc]
    public static async Task<BackgroundTaskResponse> UpdateTaskScheduleAsync(this MusicAssistantClientWs c, string taskId, TaskSchedule schedule)
    {
        var m = new Message(Commands.TasksUpdateSchedule)
        {
            Args = new Dictionary<string, object>
            {
                { "task_id", taskId },
                { "schedule", schedule }
            }
        };

        return await SendAsync<BackgroundTaskResponse>(c, m);
    }
}

