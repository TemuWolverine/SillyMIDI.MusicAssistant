using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SillyMIDI.MusicAssistant.Messages
{
    public static partial class Commands
    {
        public const string TasksCancel = "tasks/cancel";
        public const string TasksClearFinished = "tasks/clear_finished";
        public const string TasksGet = "tasks/get";
        public const string TasksList = "tasks/list";
        public const string TasksLog = "tasks/log";
        public const string TasksRemove = "tasks/remove";
        public const string TasksRetry = "tasks/retry";
        public const string TasksRun = "tasks/run";
        public const string TasksSetEnabled = "tasks/set_enabled";
        public const string TasksUpdateSchedule = "tasks/update_schedule";
    }
}
