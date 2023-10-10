namespace LILO_Packager.v2.Core.AsyncTasks.Interface
{
    public interface ILILOAsyncTask
    {
        string Description { get; }
        DateTime EndTime { get; }
        TaskMode Mode { get; }
        string Name { get; }
        DateTime StartTime { get; }
        Func<IProgress<int>, Task> TaskFunc { get; }

        event EventHandler<TaskStatus> StatusUpdated;
        event EventHandler<string> TaskCompleted;
        event EventHandler<string> TaskFailed;

        Task ExecuteAsync(IProgress<int> progress = null);
    }
}