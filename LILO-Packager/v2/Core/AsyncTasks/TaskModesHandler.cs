namespace LILO_Packager.v2.Core.AsyncTasks
{
    public class TaskModesHandler
    {
        public static Dictionary<TaskMode, string> ModeDescriptions = new Dictionary<TaskMode, string>
        {
            { TaskMode.None, "No Task (Idle and waiting)" },
            { TaskMode.Compressing, "Compressing (Squishing files into a smaller package)" },
            { TaskMode.Checking, "Checking (Ensuring everything is in order)" },
            { TaskMode.Copying, "Copying (Creating duplicates)" },
            { TaskMode.Deleting, "Deleting (Removing the clutter)" },
            { TaskMode.Updating, "Updating (Making things current and fresh)" },
            { TaskMode.Refresing, "Preparing youre Files" }
        };

        public static string GetTaskValue(TaskMode mode)
        {
            return ModeDescriptions[mode];
        }
    }
}
