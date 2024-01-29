using JWLimited.Types;

namespace LILO_Packager.v2.Core.AsyncTasks
{
    public enum TaskMode
    {
        None,
        Compressing,
        Checking,
        Copying,
        Deleting,
        Updating,
        Refresing
    }

    public class TaskModes : Enumeration
    {
        public static TaskModes None = new(0, "None");
        public static TaskModes Compressing = new(1, "Compressing");
        public static TaskModes Checking = new(2, "Analizing");
        public static TaskModes Copying = new(3, "Coping a data blop");
        public static TaskModes Deleting = new(4, "Deleting Files");
        public static TaskModes Updating = new(5, "Updating Registry");
        public static TaskModes Refresing = new(6, "Refreshing Items");

        public TaskModes(int id, string name) : base(id, name)
        {
        }
    }
}
