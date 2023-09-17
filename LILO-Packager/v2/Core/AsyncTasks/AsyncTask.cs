using LILO_Packager.v2.shared;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.AsyncTasks
{
    public class AsyncTask
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public TaskMode Mode { get; }
        public Func<IProgress<int>, Task> TaskFunc { get; }
        public event EventHandler<string> TaskCompleted;
        public event EventHandler<string> TaskFailed;
        public event EventHandler<TaskStatus> StatusUpdated;

        public AsyncTask(string name, TaskMode mode, Func<IProgress<int>, Task> taskFunc)
            : this(name, null, mode, taskFunc)
        {
        }

        public AsyncTask(string name, string description, TaskMode mode, Func<IProgress<int>, Task> taskFunc)
        {
            Name = name;
            Description = description;
            Mode = mode;
            TaskFunc = taskFunc;
        }

        public async Task ExecuteAsync(IProgress<int> progress = null)
        {
            StartTime = DateTime.Now;
            try
            {
                if (progress != null)
                {
                    await TaskFunc(progress);
                }
                else
                {
                    await TaskFunc(null);
                }

                EndTime = DateTime.Now;
                OnTaskCompleted($"{Name} completed in {(EndTime - StartTime).TotalSeconds:F2} seconds.");
                OnStatusUpdated(TaskStatus.Completed);
            }
            catch (Exception ex)
            {
                OnTaskFailed($"Task failed with error: {ex.Message}");
                OnStatusUpdated(TaskStatus.Failed);
            }
        }

        protected virtual void OnTaskCompleted(string message)
        {
            ConsoleManager.Instance().WriteLineWithColor(message);
            TaskCompleted?.Invoke(this, message);
        }

        protected virtual void OnTaskFailed(string message)
        {
            ConsoleManager.Instance().WriteLineWithColor(message,ConsoleColor.DarkRed);
            TaskFailed?.Invoke(this, message);
        }

        protected virtual void OnStatusUpdated(TaskStatus status)
        {
            StatusUpdated?.Invoke(this, status);
        }
    }
}
